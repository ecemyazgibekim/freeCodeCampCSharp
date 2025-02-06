using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US"); //hata mesajlarını ingilizce çıktı olarak vermek için
            //try bloğundaki kod çalıştırılır ve hata oluşursa catch bloğuna yönlendirilir.
            //Böylece program çökmek yerine hatayı yönetebilir.
            try
            {
                Console.Write("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine(num1 / num2);

            }
            catch(Exception e) {

                Console.Write(e.Message);
            }
            Console.ReadLine();

            //finally bloğu, try ve catch bloklarından sonra her durumda çalışan bir bloktur.
            //İster hata olsun, ister olmasın finally her zaman çalışır. kaynakları temizlemek için kullanılabilir.
            //return ile çıkış yapılsa bile finally çalışır!

            //--Ne zaman finally çalışmaz?--
            //Environment.Exit(0); çağrılırsa(Program doğrudan sonlandırıldığı için finally çalışmaz.)
            //Bilgisayar kapanırsa veya uygulama zorla kapatılırsa.
            //Sistem kritik bir hata(örn.StackOverflowException) ile çökerse.

        }
    }
}
