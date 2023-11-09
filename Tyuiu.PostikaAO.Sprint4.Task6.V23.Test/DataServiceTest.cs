using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PostikaAO.Sprint4.Task6.V23.Lib;

namespace Tyuiu.PostikaAO.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var word = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(word);
            int wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
