using Tyuiu.MedvedevDP.Sprint5.Task3.V14.Lib;
using System;

namespace Tyuiu.MedvedevDP.Sprint5.Task3.V14
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int x = 3;

            Console.WriteLine("Исходные данные:");
            Console.WriteLine($"x = {x}");
            Console.WriteLine();
            Console.WriteLine("Вычисляем значение функции:");
            Console.WriteLine("y(x) = (4 * x^3) / (x^3 - 1)");

            DataService ds = new DataService();
            string filePath = ds.SaveToFileTextData(x);

            double numerator = 4 * Math.Pow(x, 3);
            double denominator = Math.Pow(x, 3) - 1;
            double result = numerator / denominator;
            result = Math.Round(result, 3);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"y({x}) = {result:F3}");

            Console.WriteLine();
            Console.WriteLine($"Файл создан: {filePath}");
            Console.WriteLine("Результат успешно сохранён в бинарном файле.");

            Console.ReadKey();
        }
    }
}