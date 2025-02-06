using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math myMath=new Math(); diyemezsin!! hata verir çünkü static bir method nesne üretemezsin
            UsefulTools tools = new UsefulTools(); //diyebiliriz static method değil
            UsefulTools.SayHi("Mike");
            Console.WriteLine(Math.Sqrt(144));

            Console.ReadLine();
        }
    }
}
