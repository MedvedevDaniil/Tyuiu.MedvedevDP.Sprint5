using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MedvedevDP.Sprint5.Task1.V16.Lib;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path));


            string content = File.ReadAllText(path);
            Assert.IsFalse(string.IsNullOrEmpty(content));


            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            Assert.AreEqual(stopValue - startValue + 1, lines.Length);


            double expectedFirst = Math.Round(Math.Sin(-5) + (2.0 * -5) / 3.0 - Math.Cos(-5) * 4 * -5, 2);
            double expectedLast = Math.Round(Math.Sin(5) + (2.0 * 5) / 3.0 - Math.Cos(5) * 4 * 5, 2);

            double actualFirst = Convert.ToDouble(lines[0]);
            double actualLast = Convert.ToDouble(lines[^1]); // Последний элемент

            Assert.AreEqual(expectedFirst, actualFirst, 0.01); // Погрешность 0.01 из-за округления
            Assert.AreEqual(expectedLast, actualLast, 0.01);
        }
    }
}