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
    public class ProgramTests
    {
        [TestMethod()]
        public void Calc_CoinsTest()
        {
            int[] result = Program.Calc_Coins(4.57, 6, new int[] { 5, 5, 5, 5, 5, 5, 5 });
            CollectionAssert.AreEqual(new int[] { 1, 0, 2, 0, 0, 1, 1 }, result);

            result = Program.Calc_Coins(2.28, 5, new int[] { 1, 5, 5, 5, 5, 0, 5 });
            CollectionAssert.AreEqual(new int[] { 1, 3, 1, 0, 0, 0, 2 }, result);

            result = Program.Calc_Coins(3.53, 4, new int[] { 5, 5, 1, 1, 1, 5, 1 });
            Assert.AreEqual(null, result);

            result = Program.Calc_Coins(0, 0, new int[] { 1, 5, 5, 5, 5, 0, 5 });
            Assert.AreEqual(null, result);

            result = Program.Calc_Coins(1, 6, new int[] { 1, 4, 5, 5, 5, 20, 20 });
            CollectionAssert.AreEqual(new int[] { 1, 4, 5, 5, 5, 12, 1 }, result);

            result = Program.Calc_Coins(6, 1, new int[] { 1, 5, 5, 5, 5, 0, 5 });
            Assert.AreEqual(null, result);

            result = Program.Calc_Coins(6, 6, new int[] { 1, 4, 5, 5, 5, 20, 20 });
            CollectionAssert.AreEqual(new int[] { 0, 0, 0, 0, 0, 0, 0 }, result);
        }
    }
}