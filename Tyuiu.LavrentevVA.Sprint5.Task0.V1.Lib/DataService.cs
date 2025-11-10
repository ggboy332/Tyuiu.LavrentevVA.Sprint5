using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavremtevVA.Sprint5.Task0.V1.Lib


{
    public class DataService : ISprint5Task0V1
    {
        public string SaveToFileTextData(int x)
        {
            // Дано выражение  F(x) = x^3 + 2x^2 + 5x + 4  вычислить его значение при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх знаков после запятой. Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом. Интерфейс консольного приложения оfформить по шаблону. Для составления пути используйте Path.Combine() (не слеши) Директорию берите через Path.GetTempPath() Или, чтобы не составлять путь можно использовать Path.GetTempFileName(), он сразу создает файл с случайным именем в темп папке
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
