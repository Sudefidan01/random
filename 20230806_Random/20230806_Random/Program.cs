using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random Sınıfı
            // Programımızı içerisinde rastgele sayı üretmek için Random sınıfını uygulamamız içerisinde çağırmamız gerekmektedir

            Random rastgeleSayi=new Random();

            //Sayı üretmek için

            int rSayi1=rastgeleSayi.Next();
            Console.WriteLine(rSayi1);
            //0'dan başlayıp int veri tipinin max olmuş olduğu değer aralığında rastgele bir sayı oluşturur

            Console.WriteLine("--------------------");

            int rSayi2=rastgeleSayi.Next(100); //belirtilen sayı dahil edilmiyor
            Console.WriteLine(rSayi2);
            //0'dan başlayıp belirtilen değer aralğında rastgele bir sayı oluşturuyor


            Console.WriteLine("---------------------");
            int rsayi3 = rastgeleSayi.Next(5,26);//Sağdaki sayı dahil edilmiyor
            Console.WriteLine(rsayi3);
            //Belirtilen  sayı ile diğer belirtilen  sayı arasında rastgele sayı oluşturuyor

            Console.WriteLine("-----------");
            //0.0. ile 1 arasında rastgele sayı üretmek için
            double rSayi4=rastgeleSayi.NextDouble();
            Console.WriteLine(rSayi4);


            //Ornek 1
            //Sayısal loto çekilişinde çıkan sayıları ekrana yazdıran bir uygulama yazalım
            Console.Clear();
            Random rastgele=new Random();

            for (int i = 0; i <=5; i++)
            {
                Console.Write(rastgele.Next(1,51) + " ");

            }

            //Ornek 2
            //1-10 arasında rastgele sayı oluşturalım
            //Kullanıcıdan sayıyı bulana kadar tahmin etmesini isteyelim
            //Doğru tahmin yapınca "Tebrikler " mesajını yazdıralım

            Console.WriteLine();
            int rastgeleOlusturulanSayi=rastgele.Next(1,11);
            bool tahmin = true;

            while (tahmin)
            {
                Console.Write("Sayı Tahmininizi Giriniz : ");
                int tahminEdilenSayi = int.Parse(Console.ReadLine());
                if (tahminEdilenSayi==rastgeleOlusturulanSayi)
                {
                    tahmin = false;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tebrikler doğru tahmin");
            


            Console.ReadKey();

        }
    }
}
