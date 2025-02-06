using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsAndClasses
{
    class UsefulTools //eğer static yaparsam bundan bir nesne yaratamayız!!
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
}
