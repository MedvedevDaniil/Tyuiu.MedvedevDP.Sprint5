using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task7.V11.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            File.WriteAllText(path, "Hello Мир! test пробел");

            string pathSave = ds.LoadDataAndSave(path);

            string fileContent = File.ReadAllText(pathSave);

            string wait = "HelloМ!test";

            Assert.AreEqual(wait, fileContent.Trim());
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V11.txt");

            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V11.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

        }
    }
}
