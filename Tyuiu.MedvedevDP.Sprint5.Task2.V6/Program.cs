using Tyuiu.MedvedevDP.Sprint5.Task2.V6.Lib;
using System;

namespace Tyuiu.MedvedevDP.Sprint5.Task2.V6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите элементы массива 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }

            DataService ds = new DataService();

            string filePath = ds.SaveToFileTextData(matrix);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Файл создан: {filePath}");
            Console.WriteLine("Файл успешно сохранён в формате CSV.");

            Console.ReadKey();
        }
    }
}