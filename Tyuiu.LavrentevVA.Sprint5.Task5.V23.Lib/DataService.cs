using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            double res = double.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number))
                    {
                        if (number < res)
                        {
                            res = number;
                        }
                    }
                }
            }
            res = Math.Round(res, 3);
            return res;
        }
    }
}
