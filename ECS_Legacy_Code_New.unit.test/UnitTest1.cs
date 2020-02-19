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
        private fakeHeater _fakeHeater;
        private fakeTempSensor _fakeTempSensor;

        [SetUp]
        public void Setup()
        {
            _fakeHeater = new fakeHeater();
            _fakeTempSensor = new fakeTempSensor();
            _uut = new ECS(20, _fakeHeater, _fakeTempSensor);
        }

        [Test]
        public void TestThatECSWillTurnOnHeaterWhenTempIsTooLow()
        {
            _fakeTempSensor.temp = 18;
            _uut.Regulate();
            Assert.That(_fakeHeater.TurnedOnCount, Is.EqualTo(1));
        }

        private class fakeHeater : IHeater
        {
            public void TurnOn() { TurnedOnCount++; }
            public void TurnOff() { TurnedOnCount--; }
            public bool RunSelfTest() { return true; }

            public int TurnedOnCount = 0;
        }

        private class fakeTempSensor : ITempSensor
        {
            public int GetTemp() { return temp; }
            public bool RunSelfTest() { return true; }

            public int temp = 20;
        }
    }
}