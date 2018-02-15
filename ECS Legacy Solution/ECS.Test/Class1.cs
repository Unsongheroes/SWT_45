using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;

namespace ECS.Test
{
    public class FakeHeater : IHeater
    {
        public bool _Turn { get; set; }

        public void TurnOn()
        {
            _Turn = true;
        }

        public void TurnOff()
        {
            _Turn = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            Console.WriteLine("GetTemp fra fake TempSensor");
            return 10;
        }

        public bool RunSelfTest()
        {
            Console.WriteLine("Selftest fra fake TempSensor");
            return true;
        }
    }

    [TestFixture]
    public class ECSUnitTest
    {
        [Test]
        public void ECS_RunSelfTest_ReturnTrue()
        {
            var uut = new Legacy.ECS(28, new FakeTempSensor(), new FakeHeater());
            Assert.That(uut.RunSelfTest(), Is.EqualTo(true));
        }

        [Test]
        public void ECS_RegulateTest_Heater_ReturnTrue()
        {
            var fakeHeater = new FakeHeater();
            var uut = new Legacy.ECS(28, new FakeTempSensor(), fakeHeater);
            uut.Regulate();
            Assert.That(fakeHeater._Turn, Is.EqualTo(true));
        }


        [Test]
        public void ECS_RegulateTest_Heater_ReturnFalse()
        {
            var fakeHeater = new FakeHeater();
            var uut = new Legacy.ECS(0, new FakeTempSensor(), fakeHeater);
            uut.Regulate();
            Assert.That(fakeHeater._Turn, Is.EqualTo(false));
        }





    }
}
