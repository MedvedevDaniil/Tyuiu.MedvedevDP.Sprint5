using Tyuiu.MedvedevDP.Sprint5.Task3.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double resultFromFile = reader.ReadDouble();

                double expected = Math.Round(108.0 / 26.0, 3); // 4.154

                Assert.AreEqual(expected, resultFromFile, 0.001, "Значение в файле не соответствует ожидаемому.");
            }
        }
    }
}