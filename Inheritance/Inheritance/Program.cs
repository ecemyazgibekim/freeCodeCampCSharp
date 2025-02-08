using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //superclass 
            chef.MakeChicken();

            ItalianChef italianchef = new ItalianChef();  //subclass
            italianchef.MakeChicken();
            italianchef.MakePasta();
            italianchef.MakeSpecialDish();

            Console.ReadLine(); 
        }
    }
}
