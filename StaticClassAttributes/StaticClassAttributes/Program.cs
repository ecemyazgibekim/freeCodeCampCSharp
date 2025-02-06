using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
     class Program
    {
        static void Main(string[] args)
        {

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount()); //sınıfa ait olduğu için nesne oluşturmadan direkt çağrılabiliyor

            Console.WriteLine(holiday.artist); //title her nesneye özel ama static songcount ise sınıa özel
            Console.WriteLine(kashmir.artist); 
            Console.ReadLine();


            //---ÖZETLE
            /* 
             
             *  Static değişken (songCount) → Tüm nesneler için ortak, class'a ait.
                Normal değişken (title, artist) → Her nesneye özel, instance'a ait.
                Static metodlar (GetSongCount()) → Nesne oluşturmadan doğrudan sınıftan çağrılır (Song.GetSongCount()).
                Kod daha iyi yazılmalıydı çünkü songCount zaten static olduğu için getSongCount() da static olmalıydı.

                Eğer bir değişken her nesne için farklı olmalıysa → Normal (non-static) değişken kullan.
                Eğer bir değişken tüm nesneler için ortak olmalıysa → static kullan.
             */

        }
    }
}
