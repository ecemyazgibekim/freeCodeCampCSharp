using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-40)); //mutlak değerini döner yani sonuç 40
            Console.WriteLine(Math.Pow(3,2)); // 3 ün 2.kuvveti yani 9
            Console.WriteLine(Math.Pow(3.8,2)); 
            Console.WriteLine(Math.Sqrt(36)); //sonuç 6 kökünü alma
            Console.WriteLine(Math.Max(4,90)); //büyük olanı ver
            Console.WriteLine(Math.Min(4,90)); //küçük olanı ver
            Console.WriteLine(Math.Round(4.3)); // yuvarlama
            Console.WriteLine(Math.Round(4.6)); // yuvarlama


        }
    }
}
