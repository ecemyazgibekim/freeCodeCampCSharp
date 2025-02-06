using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
     class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount=0;

        //static anahtar kelimesi, bir değişkenin veya metodun tüm sınıfa (class) ait olmasını sağlar.
        //static olduğu için song classa ait bir değişken,her song nesnesi oluşturulunca da soungcount bir artırılacak
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
