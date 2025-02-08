using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish() //virtual yapınca mesela italian chef bunu yapmak istemiyorsa ama chef onun superclassıysa override edebilecek!
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
