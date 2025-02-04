using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Contains("Academy")); //t f döner
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.IndexOf('z')); //yok ise -1 döner
            Console.WriteLine(phrase.Substring(8)); 
            Console.WriteLine(phrase.Substring(8,3)); 

        }
    }
}
