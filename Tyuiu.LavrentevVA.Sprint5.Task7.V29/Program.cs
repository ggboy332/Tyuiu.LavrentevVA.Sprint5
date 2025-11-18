using System;
using Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

            // Для локального тестирования создаем директорию и файл если их нет
            string testContent = "сегодня 12 завтра 4 послезавтра 34 и потом 4 5 6";
            Directory.CreateDirectory(@"C:\DataSprint5");
            File.WriteAllText(path, testContent);

            string resultPath = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен в файл: " + resultPath);

            // Выводим содержимое результата для проверки
            string resultContent = File.ReadAllText(resultPath);
            Console.WriteLine("Содержимое результата: " + resultContent);

            Console.ReadKey();
        }
    }
}