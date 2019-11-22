using Args;
using NUnit.Framework;

namespace ArgsTest
{
    [TestFixture]
    class ArgsTest
    {
        [Test]
        public void test_normal_situation()
        {
            ArgsParser argsParser = new ArgsParser("l:bool,p:int,d:string", "-l false -p 8080 -d /usr/logs");
            Assert.AreEqual(argsParser.getValue("l"), "false");
            Assert.AreEqual(argsParser.getValue("p"), "8080");
            Assert.AreEqual(argsParser.getValue("d"), "/usr/logs");
        }

        [Test]
        public void test_situation_need_default_values()
        {
            ArgsParser argsParser = new ArgsParser("l:bool,p:int,d:string", "-l -p -d");
            Assert.AreEqual(argsParser.getValue("l"), "false");
            Assert.AreEqual(argsParser.getValue("p"), "0");
            Assert.AreEqual(argsParser.getValue("d"), "");
        }

        [Test]
        public void test_situation_with_given_and_default_values()
        {
            ArgsParser argsParser = new ArgsParser("l:bool,p:int,d:string", "-l -p 8080 -d /usr/logs");
            Assert.AreEqual(argsParser.getValue("l"), "false");
            Assert.AreEqual(argsParser.getValue("p"), "8080");
            Assert.AreEqual(argsParser.getValue("d"), "/usr/logs");
        }
    }
}
