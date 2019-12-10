using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace QUTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyParametherTest()
        {
            var calc = new StringCalculatorClass();

            var result = calc.StringCalculator("");

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void OneParametherTest()
        {
            var calc = new StringCalculatorClass();

            var result = calc.StringCalculator("2");

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ManyParamethersTest()
        {
            var calc = new StringCalculatorClass();

            var result = calc.StringCalculator("1,2,3,4");

            Assert.AreEqual(10, result);
        }
    }
}
