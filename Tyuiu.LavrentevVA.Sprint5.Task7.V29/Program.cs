using System;
using System.IO;
using Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

            // Создаем папку и файл если их нет
            Directory.CreateDirectory(@"C:\DataSprint5");

            // Создаем тестовое содержимое как в задании
            string testContent = "сегодня 12 завтра 4 послезавтра 34 и потом 4 5 6";
            File.WriteAllText(path, testContent);

            Console.WriteLine("Файл создан: " + path);
            Console.WriteLine("Содержимое: " + testContent);

            string resultPath = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен в файл: " + resultPath);

            // Читаем и выводим результат
            string resultContent = File.ReadAllText(resultPath);
            Console.WriteLine("Результат: " + resultContent);

            Console.ReadKey();
        }
    }
}