using ECS_Legacy_Code_New;
using NUnit.Framework;
using System.Text;
using System;

namespace ECS_Legacy_Code_New.unit.test
{
    [TestFixture]
    public class Tests
    {
        private ECS _uut;
        private IHeater _heater;
        private ITempSensor _tempSensor;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}