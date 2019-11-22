using System;
using System.Collections.Generic;
using System.Linq;

namespace Args
{
    public class Schemas
    {
        private Dictionary<string, string> _schemas;

        public Schemas(string schemaString)
        {
            _schemas = new Dictionary<string, string>();
            Enumerable.ToList(schemaString.Split(',')).ForEach(
                str =>
                {
                    var schemaParts = str.Split(':');
                    _schemas.Add(schemaParts[0], schemaParts[1]);
                }
                );
        }

        public string GetValue(string flag)
        {
            var type = _schemas.GetValueOrDefault(flag);
            switch(type)
            {
                case "bool":
                    return "false";
                case "int":
                    return "0";
                default:
                    return "";
            }
        }
    }
}