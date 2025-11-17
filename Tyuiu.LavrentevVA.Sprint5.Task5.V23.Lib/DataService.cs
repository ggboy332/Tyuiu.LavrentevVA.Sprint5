using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrentevVA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string data = File.ReadAllText(path);
            string[] numbers = data.Split(' ');
            double min = double.MaxValue;
            foreach (string number in numbers)
            {
                if (double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    if (value < min)
                    {
                        min = value;
                    }
                }
            }

            min = Math.Round(min, 3);
            return min;
        }
    }
}