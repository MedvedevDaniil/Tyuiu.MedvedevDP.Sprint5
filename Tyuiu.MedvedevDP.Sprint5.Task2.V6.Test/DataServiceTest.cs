using Tyuiu.MedvedevDP.Sprint5.Task2.V6.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = new int[3, 3]
            {
                {-2, 1, 8 },
                {-4, -7, 8 },
                {6, 5, 5 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);


            string expected = "0;1;1\r\n0;0;1\r\n1;1;1";

            Assert.AreEqual(expected, fileContent.Trim());
        }
    }
}