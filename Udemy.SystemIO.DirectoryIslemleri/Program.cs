using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Udemy.SystemIO.DirectoryIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //YeniKlasorOlustur("c:\\Udemy");
            //KlasorVarlikKontrolu("c:\\Udemy");
            //KlasorSilmeIslemleri("c:\\Udemy");
            //KlasorTasima("c:\\Udemy", "c:\\TasimaIslemi\\Udemy");
        }

        static void YeniKlasorOlustur(string path)
        {
            DirectoryInfo DI = Directory.CreateDirectory(path);
        }

        static void KlasorVarlikKontrolu(string path)
        {
            bool kontrol = Directory.Exists(path);
        }

        static void KlasorSilmeIslemleri(string path)
        {
            Directory.Delete(path,true);
        }

        static void OdevI()
        {

            /*
             * C sürücüsü içerisinde Udemy adında bir klasör oluşturun oluşturmadan önce varlık kontorlü yapın eğer klasor var ise silin daha sonra oluşturun 
             * eğer klasor yok ise oluşturun fakat bu adımların bilgisini ekrana yazdırın .
             */

            string dosyaYol = @"c:\Udemy";
            bool kontrol = Directory.Exists(dosyaYol);
            if(kontrol)
            {
                Console.WriteLine("Eklemek istediğiniz klasör sistemde mevcut");
                Console.Write("Silmek ve yerine yeni olarak oluşturmak istiyor musunuz [E/H]");
                string cevap = Console.ReadLine().ToUpper();
                if(cevap == "E")
                {
                    Directory.Delete(dosyaYol, true);
                    Console.WriteLine("Dosya silme işlemi tamamlandı");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(dosyaYol + " sisteminize oluşturuluyor");
                    Directory.CreateDirectory(dosyaYol);
                }
                else
                {
                    Console.WriteLine("İşlem Bitti");
                }

            }
            else
            {
                DirectoryInfo DI =  Directory.CreateDirectory(dosyaYol);
                if(DI.Exists)
                {
                    Console.WriteLine("Dosya sistemde oluşturuldu");
                }
            }

        }

        static void KlasorTasima(string kaynak,string hedef)
        {
            Directory.Move(kaynak, hedef);
        }

    
    }
}
