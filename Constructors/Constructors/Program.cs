using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book book1=new Book();
           Book book2=new Book("Harry Potter","JK Rowling", 400);
           Book book3 = new Book("LOTR", "JRR Tolkien", 700);

           Console.WriteLine(book2.title);
            //Overwrite işlemi ,  deconstructor C++ ama C# da doğrudan öyle geçmiyo ezme işlemi yaptık  overwrite etmek
            book3.title = "Hobbit";
            Console.WriteLine(book3.title);
           Console.ReadLine();
        }
    }
}
