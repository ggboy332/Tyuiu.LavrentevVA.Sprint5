using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task4.V29.Lib
{
    public class DataService : ISprint5Task4V29
    {
        public double LoadFromDataFile(string path)
        {
            // Дан файл С:\DataSprint5\InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\DataSprint5\ и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х в формуле y = (x / 2 * x)  + sin(x ^ 2) Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((x / 2 * x) + Math.Sin(Math.Pow(x, 2)), 3);
            return res;
        }
    }
}
