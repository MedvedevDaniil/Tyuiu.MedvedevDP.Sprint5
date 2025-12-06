using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevDP.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double maxInt = double.MinValue; 
            double minInt = double.MaxValue; 
            bool foundInt = false; 

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string number in numbers)
                    {
                        string numStr = number.Replace('.', ',');

                        if (double.TryParse(numStr, out double value))
                        {
                            if (value % 1 == 0)
                            {
                                if (value > maxInt) maxInt = value;
                                if (value < minInt) minInt = value;
                                foundInt = true;
                            }
                        }
                    }
                }
            }

            if (foundInt)
            {
                res = maxInt - minInt;
            }
            else
            {
                res = 0;
            }
            return Math.Round(res, 3);
        }
    }
}
