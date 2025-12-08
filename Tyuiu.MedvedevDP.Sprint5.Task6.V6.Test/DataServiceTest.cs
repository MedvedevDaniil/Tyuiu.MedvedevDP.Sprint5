using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task6.V6.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();


            File.WriteAllText(path, "Hello Мир! abc фыва");

            var res = ds.LoadFromDataFile(path);
            int wait = 6;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V6.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
