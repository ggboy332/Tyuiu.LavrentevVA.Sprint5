using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavremtevVA.Sprint5.Task0.V1.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int z = 3;

            Console.WriteLine("z = " + z);


            string path = ds.SaveToFileTextData(z);

            Console.WriteLine("File: " + path);
            Console.WriteLine("Слздан!");
            Console.ReadKey();

        }
    }
}
