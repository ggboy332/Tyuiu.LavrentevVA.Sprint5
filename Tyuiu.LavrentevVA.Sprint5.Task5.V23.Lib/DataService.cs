using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            string[] tokens = content.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;
            foreach (var token in tokens)
            {
                // Проверяем, что число вещественное (содержит точку или запятую)
                if ((token.Contains('.') || token.Contains(',')) &&
                    double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (number < min)
                        min = number;
                }
            }
            return Math.Round(min, 3);
        }
    }
}
