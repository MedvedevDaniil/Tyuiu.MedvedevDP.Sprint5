using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {

        public string SaveToFileTextData(int x)
        {
            double numerator = 4 * Math.Pow(x, 3);
            double denominator = Math.Pow(x, 3) - 1;

            if (denominator == 0)
                throw new DivideByZeroException("Знаменатель равен нулю!");

            double result = numerator / denominator;

            result = Math.Round(result, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(result);
            }

            return filePath;
        }
    }
}