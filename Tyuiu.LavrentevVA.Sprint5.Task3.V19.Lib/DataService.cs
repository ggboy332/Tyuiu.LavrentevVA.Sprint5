using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.LavrentevVA.Sprint5.Task3.V19.Lib
{
    public class DataService : ISprint5Task3V19
    {
        public string SaveToFileTextData(int x)
        {
            // Дано выражение вычислить его значение при x = 3, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой. y(x) = 2x^2 - 1 / sqrt(x^2 -2) Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом. Интерфейс консольного приложения оформить по шаблону. 
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool fileExists = FileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = 2 * Math.Pow(x, 2) - 1 / Math.Sqrt(Math.Pow(x, 2) - 2);
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File
                    .Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }
            return path;
        }
    }
}
