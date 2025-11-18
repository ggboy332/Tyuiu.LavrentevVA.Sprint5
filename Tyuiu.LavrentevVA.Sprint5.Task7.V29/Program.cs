using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavrentevVA.Sprint5.Task7.V29.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V29.txt";
            string resultPath = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен в файл: " + resultPath);
            Console.ReadKey();
        }
    }
}