using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //gerçek dünyadaki nesneleri düşün bir telefonu int bool ile ifade edemeyiz daha karmaşık
            //nesneler kendi özel veri tiplerimizi oluşturmamızı sağlar(objects)
            // sınıf ile gerçek dünyadakileri modelleyebiliriz. Karmaşık bir veri türü yaratabiliriz mesela book sınıfı ile

            Book book1=new Book(); //book classının bir instanceı(örneğini) yarattık. nesne yarattım yani
            book1.title = "Harry Potter";
            book1.author = "JK  Rowling";
            book1.pages = 400;


            Book book2= new Book(); 
            book2.title = "LOTR";
            book2.author = "JRR Tolkien";
            book2.pages = 700;


            Console.WriteLine("Book 1 Title:" + book1.title);
            Console.WriteLine("Book 2 Author:" + book2.author);


            //Yani kitabımın ne özellikleri olacaksa . yazıp kullanacaksam onu gidip o classta(sınıfta) belirliyorum attribute olarak
            //program.cs de ise  nesnemi yaratıyorum yani o classın instanceını üretiyorum ve değerler atayabiliyorum attributelara
        }
    }
}
