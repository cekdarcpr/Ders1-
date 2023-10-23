using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2
{
    internal class MatFonksiyonlar
    {
        public static void Main(string[] args)
        {
            #region Abs - Mutlak Değer...
            /*
                        int sayi1 = -1000;
                        int sayi2 = 5;

                        int abs1 = Math.Abs(sayi1);
                        int abs2 = Math.Abs(sayi2);

                        Console.WriteLine("Sayım : {0} Abs : {1}",sayi1,abs1);
                        Console.WriteLine("Sayım : {0} Abs : {1}", sayi2, abs2);
            */
            #endregion

            #region Pow
            /*
            double sayi1 = 4;
            double sayi2 = 5;

            double sonuc = Math.Pow(sayi1, sayi2);

            Console.WriteLine("Sonuç : {0}",sonuc);
            */

            #endregion

            // String fonkisyonlar...

            #region Length

            //string metin = "Arı Bilgide C# Öğren";

            //Console.WriteLine("Metnin uzunluğu {0} karakterdir...",metin.Length);

            #endregion

            #region Compare()
            /*
                        string metin1 = "Mcsd";
                        string metin2 = "Mcsd";

                        int sonuc = String.Compare(metin1, metin2);
                        Console.WriteLine();

                        switch (sonuc)
                        {
                            case 0:
                                Console.WriteLine("Her iki metinde aynı...");
                                break;
                            case 1:
                                Console.WriteLine("1.Metin daha büyük");
                                break;
                            case -1:
                                Console.WriteLine("2.Metin daha büyük");
                                break;
                            default:
                                break;
                        }
            */

            #endregion

            Console.WriteLine("Lütfen adınızı giriniz : ");
            string userıd = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen Soyadınızı giriniz : ");
            string lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Yaşınızı Giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} kendini beyinsel olarak {1} yaşında hissediyor",String.Concat(userıd," ",lastname),yas);
            


            // ekrandan userıd/sifre alınacak. gerekli sitring fonksiyonlar kulanırak doğrulu kontrol mesajı verilecek... (compare fonksiyonu?)
        }
    }
}
