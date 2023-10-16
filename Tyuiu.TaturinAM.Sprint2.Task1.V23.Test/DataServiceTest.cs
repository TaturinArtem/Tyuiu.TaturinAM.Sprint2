using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint2.Task1.V23.Lib;
namespace Tyuiu.TaturinAM.Sprint2.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] wait = new bool[6] { false, false, false, true, true, true};

            CollectionAssert.AreEqual(wait, ds.GetLogicOperations(242, 571, 325, 155));
        }
    }
}
