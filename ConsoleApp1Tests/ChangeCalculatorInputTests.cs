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
    public class ChangeCalculatorInputTests
    {
        [TestMethod()]
        public void ChangeCalculatorInputTest0()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.AreEqual(1, inpTest.EuroOne);
            Assert.AreEqual(2, inpTest.FiftyCent);
            Assert.AreEqual(3, inpTest.TwentyCent);
            Assert.AreEqual(4, inpTest.TenCent);
            Assert.AreEqual(5, inpTest.FiveCent);
            Assert.AreEqual(6, inpTest.TwoCent);
            Assert.AreEqual(7, inpTest.SingleCent);
            Assert.AreEqual(8, inpTest.Price);
            Assert.AreEqual(9, inpTest.Given);
            
        }

        [TestMethod()]
        public void ChangeCalculatorInputTest1()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(9, 8, 7, 6, 5, 4, 3, 2, 1);
            Assert.AreEqual(9, inpTest.EuroOne);
            Assert.AreEqual(8, inpTest.FiftyCent);
            Assert.AreEqual(7, inpTest.TwentyCent);
            Assert.AreEqual(6, inpTest.TenCent);
            Assert.AreEqual(5, inpTest.FiveCent);
            Assert.AreEqual(4, inpTest.TwoCent);
            Assert.AreEqual(3, inpTest.SingleCent);
            Assert.AreEqual(2, inpTest.Price);
            Assert.AreEqual(1, inpTest.Given);

        }

        [TestMethod()]
        public void ChangeCalculatorInputTest2()
        {
            ChangeCalculatorInput inpTest = new ChangeCalculatorInput(13, 45, 66, 11, 4, 19, 69, 1085.76m, 8900.34m);
            Assert.AreEqual(13, inpTest.EuroOne);
            Assert.AreEqual(45, inpTest.FiftyCent);
            Assert.AreEqual(66, inpTest.TwentyCent);
            Assert.AreEqual(11, inpTest.TenCent);
            Assert.AreEqual(4, inpTest.FiveCent);
            Assert.AreEqual(19, inpTest.TwoCent);
            Assert.AreEqual(69, inpTest.SingleCent);
            Assert.AreEqual(1085.76m, inpTest.Price);
            Assert.AreEqual(8900.34m, inpTest.Given);
        }
    }
}