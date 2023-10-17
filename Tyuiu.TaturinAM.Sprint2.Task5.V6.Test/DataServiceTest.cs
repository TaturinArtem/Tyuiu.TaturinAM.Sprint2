using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint2.Task5.V6.Lib;
namespace Tyuiu.TaturinAM.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            int value1 = 14;
            int value2 = 2;
            string wait = "Туз треф";

            string res = ds.FindCardNameAndValue(value1, value2);

            Assert.AreEqual(wait, res);

        }
    }
}
