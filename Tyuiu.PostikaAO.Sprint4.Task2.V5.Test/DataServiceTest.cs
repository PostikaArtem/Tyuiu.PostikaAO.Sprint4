using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint4.Task2.V5.Lib;

namespace Tyuiu.PostikaAO.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int res = ds.Calculate(numsArray);
            int a = 30;
            Assert.AreEqual(30, res);
        }
    }
}
