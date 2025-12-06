using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task5.V5.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task5.V5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V5.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            if (File.Exists(path))
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine("Разница между макс. и мин. целыми числами = " + res);
            }
            else
            {
                Console.WriteLine("Файл не найден! Создайте файл " + path);
            }

            Console.ReadKey();
        }
    }
}
