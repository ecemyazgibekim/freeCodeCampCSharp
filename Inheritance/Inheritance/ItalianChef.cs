using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class ItalianChef:Chef  //italyan chef, cheften miras alındı yani onun yapabildiği her şeyi yapabiliyor ve kendisi de spesifik özel şeyler yapabiliyor bunlara ek olarak

    {
        //cheftekileri gelip buraya yapıştırmana gerek yok inheritance yaptığında program.cs de direkt kullanabileceksin. işlevselliği devraldı.
        public void MakePasta()
        {
            Console.WriteLine("Italian chef makes pasta");
        }
        //italian chefe gelince override edeceğin metota override yazıyorsun, superclassta o metot virtualdı
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The  Chef makes chicken parm");
        }
    }
}
