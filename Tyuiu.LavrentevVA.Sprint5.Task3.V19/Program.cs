using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavrentevVA.Sprint5.Task3.V19.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + path);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
