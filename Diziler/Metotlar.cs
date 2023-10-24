using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Metotlar
    {
        public static void Main(string[] args) 
        {
            /*
            // Metotlara Örnek 'Büyük Sayıyı Bulmak...'
            Console.WriteLine("Lütfen Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Lütfen 2. Sayınızı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int buyuk = KucukBuyuk(sayi, sayi2);
            Console.WriteLine("Girilen Büyük Sayı {0}",buyuk);
            */

            // Aynı isimlerde farkılı metotlar...
            /*
                   Console.WriteLine("2'li toplama İşlemi sonucu : {0}", ToplamaIslemi(5,15));
                   Console.WriteLine("3'lü toplama işlemi Sonucu : {0}", ToplamaIslemi(5,15,23));
                   Console.WriteLine("4'lü toplama işlemi sonucu : {0}", ToplamaIslemi(5,15,65,10));

            */

            /*

            // Erkeklerin 25 yıl, kadınların 20 yıl çalıştıktan sonra emekli olacağı varsayıln bir ortamda klavyeden girilen cinsiyet 
            // ve sigorta prim gün sayısına göre kişinin emekliliğine ne kadar kaldığını bulan program...

            //Hints
            //1 yıl = 360 gün kabul edilecek
            //1 ay = 30 gün kabul edilecek
            //örnek = 1943 --> 5 yıl 4 ay 23 gün vardır...

            int yıl = 360;
            int ay = 30;
            int gün;
            char cinsiyet;

            Console.WriteLine("Lütfen Cinsiyet Giriniz (E,K) : ");
            cinsiyet = Convert.ToChar(Console.ReadLine().ToUpper()); // ToUpper girilen harfleri büyütür 

            Console.WriteLine("Lütfen Prim Gün Sayısını Giriniz : ");
            gün = Convert.ToInt32(Console.ReadLine());

            int yıl2 = emeklilik(cinsiyet, gün) / yıl;
            gün %= yıl2;

            int ay2 = emeklilik(cinsiyet, gün) / ay;
            gün %= ay2;

            int gün2 = gün;

            Console.WriteLine("Emekliliğinize {0} yıl {1} ay {2} gün kalmıştır...",yıl2,ay2,gün2);


            */

            // Metot yapısı kullanarak 4 işlem ( +, -, *, / ) sonuçlarını veren program...

            /*

            Console.WriteLine("1. Sayıyı Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama işleminin Sonucu : {0}",topla(sayi1,sayi2));
            Console.WriteLine("Çıkarma işleminin Sonucu : {0}", cıkar(sayi1, sayi2));
            Console.WriteLine("Çarpma işleminin Sonucu : {0}", carp(sayi1, sayi2));
            Console.WriteLine("Bölme işleminin Sonucu : {0}", bol(sayi1, sayi2));

            */
            //********************************************************************************

            //Örnek 'METOT ADI - SAYI TUT
            //Eğer bu metoda true değeri gönderilirse 1-100 arasında rastgele tek sayı 
            //Eğer bu metoda false değeri gönderilirse 1-100 arasında rastgele çift sayı
            //tutuğu sayıyı ekranda gösterecek gerekli mesajlarla

            //********************************************************************************


            Console.WriteLine("Sayı : {0}\n\n",SayiTut(true));
            Console.WriteLine("Sayı : {0}\n\n", SayiTut(false));




        }
        private static int SayiTut(bool prmYD)
        {
            int sayi;
            if (prmYD) // (prmYD != true) yada (!prmYD)
            {
                do
                {

                Random rastgele = new Random();

                sayi = rastgele.Next(1, 100);

                } 
                while (sayi % 2 ==0);

            }
            else
            {
                do
                {

                    Random rastgele = new Random();

                    sayi = rastgele.Next(1, 100);

                }
                while (sayi % 2 == 1);

            }

            return sayi;
        }
        private static int topla(int psayi ,int psayi2)
        {
            return psayi + psayi2;
        }
        private static int cıkar(int psayi, int psayi2)
        {
            return psayi - psayi2;
        }
        private static int carp(int psayi, int psayi2)
        {
            return psayi * psayi2;
        }
        private static double bol(double psayi, double psayi2)
        {
            if (psayi == 0 || psayi2 == 0)
            {
                Console.WriteLine("Tanımsız");
                return 0;
            }
            else
            {
                return psayi / psayi2;
            }
            
        }

        private static int emeklilik(char cnsyt,int günsayısı)
        {

            int günkadın = 7200;
            int günerkek = 9000;

            switch (cnsyt)
            {
                case 'E':
                    günsayısı = günerkek - günsayısı;
                    break;

                case 'K':
                    günsayısı = günkadın - günsayısı;
                    break;

                default:
                    break;
            }

            return günsayısı;
        }
        private static int ToplamaIslemi (int sayi1,int sayi2)
        {
            // iki Sayıyı Toplayan Metot

            return sayi1 + sayi2;

        }
        private static int ToplamaIslemi(int sayi1, int sayi2,int sayi3)
        {
            // iki Sayıyı Toplayan Metot
            return sayi1 + sayi2 + sayi3;

        }
        private static int ToplamaIslemi(int sayi1, int sayi2, int sayi3,int sayi4)
        {
            // iki Sayıyı Toplayan Metot
            return sayi1 + sayi2 + sayi3 + sayi4;

        }

        private static int KucukBuyuk(int a , int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
            
        }
    }
}
