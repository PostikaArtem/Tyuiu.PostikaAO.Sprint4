using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint4.Task7.V25.Lib;

namespace Tyuiu.PostikaAO.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "348561792486";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 38;
            Assert.AreEqual(wait, res);

        }
    }
}
