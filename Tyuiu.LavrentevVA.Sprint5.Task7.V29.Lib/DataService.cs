using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            // Читаем содержимое файла
            string content = File.ReadAllText(path);

            // Удаляем однозначные sdчисла с помощью регулярного выражения
            string result = Regex.Replace(content, @"\b\d\b", "");

            // Формируем путь для выходного файла в той же папке, что и входной файл
            string outputPath = Path.Combine(Path.GetDirectoryName(path), "OutPutDataFileTask7V29.txt");

            // Записываем результат в выходной файл
            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}