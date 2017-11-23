using myStudy.Console.LoggingLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStudy.Console.Tests
{
    [TestFixture]
    class TestClass
    {
        [Test]
        public void foo()
        {
            var i1 = Singleton.Instance.Config;
            var i2 = Singleton.Instance.Config;            

            Assert.AreEqual(i1,i2);            
        }

        [Test]
        public void TestLogStrategy()
        {
            var logger = LoggerFactory.CreateLogStrategy("NULL");
            Assert.NotNull(logger);
            Assert.IsInstanceOf(typeof(NullLogStrategy), logger);

            logger = LoggerFactory.CreateLogStrategy("FILE");
            Assert.NotNull(logger);
            Assert.IsInstanceOf(typeof(FileLogStrategy), logger);
        }
    }
}
