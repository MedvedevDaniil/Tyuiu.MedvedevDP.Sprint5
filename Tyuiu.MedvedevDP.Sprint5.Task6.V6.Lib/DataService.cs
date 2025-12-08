using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MedvedevDP.Sprint5.Task6.V6.Lib
{
    public class DataService : ISprint5Task6V6
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string content = File.ReadAllText(path);

            foreach (char c in content)
            {

                if ((c >= 'а' && c <= 'я'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
