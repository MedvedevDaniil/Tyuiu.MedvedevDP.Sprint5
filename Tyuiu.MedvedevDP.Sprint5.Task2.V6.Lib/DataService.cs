using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.MedvedevDP.Sprint5.Task2.V6.Lib
{
    public class DataService : ISprint5Task2V6
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
            }

            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                        result += matrix[i, j] + ";";
                    else
                        result += matrix[i, j];
                }
                if (i != rows - 1)
                    result += Environment.NewLine;
            }

            File.WriteAllText(filePath, result);

            return filePath;
        }
    }
}