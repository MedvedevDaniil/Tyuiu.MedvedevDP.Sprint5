using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevDP.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            strX = strX.Replace('.', ',');

            double x = Convert.ToDouble(strX);
            double res = (3 * Math.Pow(x, 3)) / Math.Sin(x);

            return Math.Round(res, 3);
        }
    }
}
