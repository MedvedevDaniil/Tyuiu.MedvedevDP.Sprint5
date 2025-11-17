using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MedvedevDP.Sprint5.Task0.V23.Lib;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(path));

            string content = File.ReadAllText(path);

            double expected = Math.Round((1 + Math.Pow(x, 3)) / x, 3);
            double actual = Convert.ToDouble(content);
            Assert.AreEqual(expected, actual);
        }
    }
}