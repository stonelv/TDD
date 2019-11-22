using Args;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArgsTest
{
    [TestFixture]
    class SchemaTest
    {
        [Test]
        public void test_normal_schema()
        {
            Schemas schemas = new Schemas("l:bool,p:int,d:string");
            Assert.AreEqual(schemas.GetValue("l"), "false");
            Assert.AreEqual(schemas.GetValue("p"), "0");
            Assert.AreEqual(schemas.GetValue("d"), "");
        }
    }
}
