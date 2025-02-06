using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Book
    {

        public string title;
        public string author;
        public int pages;

        //constructor(yapıcı metot) bir classtan object oluşturduğumuzda ilk çalışacak olan özel bir metot
        //nesneye başlangıç değeri vermek, kod tekrarını önlemek ve oluşturulan nesneyi kullanıma hazır hale getirmek  için kullanıyoruz
        // constr olmazsa elle değer atamak zorunda kalırız
        public Book()
        {
            //aynı isimli başka bir constr bunun parametresi yok
        }

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
