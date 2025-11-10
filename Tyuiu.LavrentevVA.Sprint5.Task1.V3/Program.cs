using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavrentevVA.Sprint5.Task1.V3.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Start Value = " + startValue);
            Console.WriteLine("Stop Value = " + stopValue);
            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("File: " + path);
            Console.WriteLine("Created!");
            Console.ReadKey();
        }
    }
}