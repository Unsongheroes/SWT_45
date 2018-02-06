using NUnit.Framework;
using SimpleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add2And4_results6()
        {
            var uut = new SimpleCalculator1();

            Assert.That(uut.Add(2, 4), Is.EqualTo(6));
        }


        [TestCase(2, 3,5)]
        [TestCase(2, -3,-1)]
        [TestCase(-2, -3, -5)]
        [TestCase(0, 0, 0)]
        public void Add_Testcases_VaryResult(int a, int b, int d)
        {
            var uut = new SimpleCalculator1();
            Assert.AreEqual(d,uut.Add(a,b));
        }

        [Test]
        public void Subtract_Sub2from4_resultNeg2()
        {
            var uut = new SimpleCalculator1();

            Assert.That(uut.Subtract(2, 4), Is.EqualTo(-2));

        }
    }
}
