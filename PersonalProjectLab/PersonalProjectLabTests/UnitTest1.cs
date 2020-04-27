using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateInertiaTest()
        {
            CalculatorEngine testCalculator = new CalculatorEngine();

            decimal inertia = testCalculator.CalculateInertia(12, 1);

            Assert.AreEqual(1, inertia);


        }
        [TestMethod]
        public void CalculateDeflectionTest()
        {
            CalculatorEngine testCalculator = new CalculatorEngine();

            decimal deflection = testCalculator.CalculateDeflection(100, 144, 100, 180000, 10.67m);

            Assert.AreEqual(28.8104m, deflection);
        }
    }
}
