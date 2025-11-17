using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavrentevVA.Sprint5.Task4.V29.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V29.txt";
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}

