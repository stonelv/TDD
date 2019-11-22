using System;
using System.Collections.Generic;

namespace Args
{
    public class ArgsParser
    {
        private Schemas schemas;
        private Dictionary<string, string> commandDic;

        public ArgsParser(string schema, string commands)
        {
            schemas = new Schemas(schema);
            ConvertCommandStringToDictionary(commands);
        }

        private void ConvertCommandStringToDictionary(string commands)
        {
            commandDic = new Dictionary<string, string>();
            var cmdParts = commands.Split(' ');
            Command cmd = null;
            foreach (var part in cmdParts)
            {
                if (part.StartsWith("-")) //this is a command
                {
                    if (cmd == null)
                    {
                        cmd = CreateNewCommand(part);
                    }
                    else
                    {
                        cmd.value = getDefaultValueFromSchema(cmd.flag);
                        commandDic.Add(cmd.flag, cmd.value);
                        cmd = CreateNewCommand(part);
                    }
                }
                else
                {
                    if (cmd != null)
                    {
                        cmd.value = part;
                        commandDic.Add(cmd.flag, cmd.value);
                        cmd = null;
                    }
                }
            }
            if (cmd != null && cmd.value == null)
            {
                cmd.value = getDefaultValueFromSchema(cmd.flag);
                commandDic.Add(cmd.flag, cmd.value);
            }
        }

        private static Command CreateNewCommand(string part)
        {
            Command cmd = new Command();
            cmd.flag = part.Substring(1);
            return cmd;
        }

        private string getDefaultValueFromSchema(string flag)
        {
            return schemas.GetValue(flag);
        }

        public string getValue(string flag)
        {
            return commandDic.GetValueOrDefault(flag);
        }
    }

    internal class Command
    {
        internal string flag;
        internal string value;
    }
}