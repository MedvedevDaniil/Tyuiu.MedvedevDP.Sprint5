using Tyuiu.MedvedevDP.Sprint5.Task1.V16.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine($"Начальное значение: {startValue}");
        Console.WriteLine($"Конечное значение: {stopValue}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string filePath = ds.SaveToFileTextData(startValue, stopValue);

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine("Результаты табулирования:");
        Console.WriteLine(fileContent);

        Console.WriteLine();
        Console.WriteLine($"Файл создан по пути: {filePath}");
        Console.ReadKey();
    }
}