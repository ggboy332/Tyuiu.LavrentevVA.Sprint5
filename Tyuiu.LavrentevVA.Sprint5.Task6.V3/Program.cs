using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Tyuiu.LavrentevVA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.LavrentevVA.Sprint5.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";
            int result = ds.LoadFromDataFile(path);
            Console.WriteLine("Результат: " + result);

            Console.ReadKey();
        }
    }
}

