using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ChangeCalculatorCalcTests
    {
        [TestMethod()]
        public void CalculateTest0()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(5, 5, 5, 5, 5, 5, 5, 4.57m, 6m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(1, outTest.EuroOne);
            Assert.AreEqual(0, outTest.FiftyCent);
            Assert.AreEqual(2, outTest.TwentyCent);
            Assert.AreEqual(0, outTest.TenCent);
            Assert.AreEqual(0, outTest.FiveCent);
            Assert.AreEqual(1, outTest.TwoCent);
            Assert.AreEqual(1, outTest.SingleCent);
            Assert.AreEqual(true, outTest.CanChange);            
        }

        [TestMethod()]
        public void CalculateTest1()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(1, 5, 5, 5, 5, 0, 5, 2.28m, 5m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(1, outTest.EuroOne);
            Assert.AreEqual(3, outTest.FiftyCent);
            Assert.AreEqual(1, outTest.TwentyCent);
            Assert.AreEqual(0, outTest.TenCent);
            Assert.AreEqual(0, outTest.FiveCent);
            Assert.AreEqual(0, outTest.TwoCent);
            Assert.AreEqual(2, outTest.SingleCent);
            Assert.AreEqual(true, outTest.CanChange);
        }
        [TestMethod()]
        public void CalculateTest2()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(5, 5, 1, 1, 1, 5, 1, 3.53m, 4m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(0, outTest.EuroOne);
            Assert.AreEqual(0, outTest.FiftyCent);
            Assert.AreEqual(1, outTest.TwentyCent);
            Assert.AreEqual(1, outTest.TenCent);
            Assert.AreEqual(1, outTest.FiveCent);
            Assert.AreEqual(5, outTest.TwoCent);
            Assert.AreEqual(1, outTest.SingleCent);
            Assert.AreEqual(false, outTest.CanChange);
        }
        [TestMethod()]
        public void CalculateTest3()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(5, 5, 5, 5, 5, 5, 5, 6m, 4m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(0, outTest.EuroOne);
            Assert.AreEqual(0, outTest.FiftyCent);
            Assert.AreEqual(0, outTest.TwentyCent);
            Assert.AreEqual(0, outTest.TenCent);
            Assert.AreEqual(0, outTest.FiveCent);
            Assert.AreEqual(0, outTest.TwoCent);
            Assert.AreEqual(0, outTest.SingleCent);
            Assert.AreEqual(false, outTest.CanChange);
        }

        [TestMethod()]
        public void CalculateTest4()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(5, 5, 5, 5, 5, 5, 5, 6, 6m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(0, outTest.EuroOne);
            Assert.AreEqual(0, outTest.FiftyCent);
            Assert.AreEqual(0, outTest.TwentyCent);
            Assert.AreEqual(0, outTest.TenCent);
            Assert.AreEqual(0, outTest.FiveCent);
            Assert.AreEqual(0, outTest.TwoCent);
            Assert.AreEqual(0, outTest.SingleCent);
            Assert.AreEqual(true, outTest.CanChange);
        }

        [TestMethod()]
        public void CalculateTest5()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(5, 5, 5, 5, 5, 5, 5, 4.57m, 6m);
            ChangeCalculatorOutput outTest = ChangeCalculatorCalc.Calculate(inpTest);

            Assert.AreEqual(1, outTest.EuroOne);
            Assert.AreEqual(0, outTest.FiftyCent);
            Assert.AreEqual(2, outTest.TwentyCent);
            Assert.AreEqual(0, outTest.TenCent);
            Assert.AreEqual(0, outTest.FiveCent);
            Assert.AreEqual(1, outTest.TwoCent);
            Assert.AreEqual(1, outTest.SingleCent);
            Assert.AreEqual(true, outTest.CanChange);
        }

    }
}