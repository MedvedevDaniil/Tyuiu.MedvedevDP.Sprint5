using System;
using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task7.V11.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V11.txt");

            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V11.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("Находится в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
