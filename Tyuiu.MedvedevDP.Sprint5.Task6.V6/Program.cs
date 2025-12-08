using System;
using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task6.V6.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V6.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
