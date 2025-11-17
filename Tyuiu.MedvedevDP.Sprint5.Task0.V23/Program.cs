using Tyuiu.MedvedevDP.Sprint5.Task0.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string filePath = ds.SaveToFileTextData(x);

        string resultFromFile = File.ReadAllText(filePath);
        Console.WriteLine($"Результат записан в файл: {filePath}");
        Console.WriteLine($"Значение выражения: {resultFromFile}");

        Console.ReadKey();
    }
}