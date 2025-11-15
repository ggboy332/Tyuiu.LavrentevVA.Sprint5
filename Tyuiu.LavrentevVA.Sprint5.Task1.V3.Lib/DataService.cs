using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task1.V3.Lib
{
    public class DataService : ISprint5Task1V3
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Дана функция: F(x) = cos(2x) + sin(x)/(x + 2.5) + 2x Произвести табулирование функции f(x) на заданном диапазоне[-5; 5] с шагом 1. Произвести проверку деления на ноль.При делении на ноль вернуть значение 0. Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить до двух знаков после запятой.
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;

            if (exists)
            {
                file.Delete();
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(2 * x) + Math.Sin(x) / (x + 2.5) + 2 * x;
                }
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);
                File.AppendAllText(path, strY + "\n");
            }
            return path;

        }  
    }
}
