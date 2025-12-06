using System.IO;
using Tyuiu.MedvedevDP.Sprint5.Task4.V28.Lib;

namespace Tyuiu.MedvedevDP.Sprint5.Task4.V28
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (File.Exists(path))
            {
                double res = ds.LoadFromDataFile(path);
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Файл не найден! Проверьте путь: " + path);
            }

            Console.ReadKey();
        }
    }
}
