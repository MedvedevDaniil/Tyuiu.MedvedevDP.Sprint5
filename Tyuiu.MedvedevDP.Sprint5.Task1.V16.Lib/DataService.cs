using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevDP.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;
                try
                {
                    y = Math.Sin(x) + (2.0 * x) / 3.0 - Math.Cos(x) * 4 * x;
                }
                catch (DivideByZeroException)
                {
                    y = 0;
                }

                y = Math.Round(y, 3);

                string strY = y.ToString();

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}