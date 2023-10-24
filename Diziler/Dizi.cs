using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Dizi
    {
        public static void Main(string[] args)
        {
            #region Dizi tanımlama,değer atama, kullanma
            /*
            int[] dizi = new int[20]; // 20 elamanlı dizi isiminde int dizi...

            dizi[0] = 30; // Değer atama

            Console.WriteLine("Dizi elemanın içeriği : {0}", dizi[9]);


            */


            #endregion

            //Girilen dizileri tersden yani en sondan sıralamak...
            /*
                    string[] Myteam = { "Çekdar", "ahmet", "mehmet", "ayşe", "fatma", "öykü", "emre", "tarık", "alper", "bilge", "eyüp","scart","ümit" };

                    int diziSayilari = Myteam.Length - 1;

                    for (int i = diziSayilari; i >=0; i--)
                    {
                        Console.WriteLine("\t\t\t\tElemanın adı : {0}\n\n",Myteam[i]);
                    }

            */
            #region for/foreach döngüleri

            //Verilen bir tam sayı dizisinin toplamını for ve foreach döngülerini kullanarak yazınız...
            /*
            int[] sayilar = { 1, 2, 78, 89, 99, 45, 123, 51, 62, 2, 3, 48, 52 };
            
            int toplam = 0;

            for (int index = 0; index < sayilar.Length; index++)
            {
                toplam += sayilar[index];
            }

            Console.WriteLine(toplam);

            int toplam1 = 0;

            foreach (int deger in sayilar)
            {
                toplam1+= deger;

                

            }
            Console.WriteLine(toplam1);
            */

            /*
            // Tanımlanan sayısal bir dizi içindeki elamanlarn negatif/pozitif/işaretsiz olma durumlarını elamanın yanına yazınız...

            int pozitifAdet = 0, negatifAdet = 0,NötrAdet = 0; 
            int[] sayilar = { 5, 6, -15, 22, -34, 3, 0, -7, 8, 100, -100 };

            foreach (int sayi in sayilar) 
            {
                switch (sayi)
                {
                    case > 0:
                        pozitifAdet++;
                        Console.WriteLine("Sayı : {0} Pozitiftir...",sayi);
                        break;
                    case < 0:
                        negatifAdet++;
                        Console.WriteLine("Sayı : {0} Negatiftir...", sayi);
                        break;
                    default:
                        NötrAdet++;
                        Console.WriteLine("Sayı : {0} Nötrdür...",sayi);
                        break;
             
                }
               
            }
            Console.WriteLine("Pozitif adet {0}", pozitifAdet);
            Console.WriteLine("Negatif adet {0}", negatifAdet);
            Console.WriteLine("Nötr adet {0}", NötrAdet);
            */

            // Kullanıcıdan alınan bir metin içindeki sesli harfleri bulup ekrana yazdırma..
            /*
            char[] sesliler = { 'a', 'e', 'ı','i','o','ö','u','ü' };

            char[] hangileri = new char[30];

            int hindex = 0;

            string metin = "";

            int adet = 0;

            Console.WriteLine("Metninizi Giriniz : ");
            metin = Console.ReadLine().ToLower(); //bütün harfleri küçültü toLower

            // Benim tanımladığım sesli harfler(sesliler dizisi) üzerinden dolaşacak...

            for (int i = 0; i < sesliler.Length; i++)
            {
                //ikinci for döngüsü ekrandan alınan metin için

                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == sesliler[i])
                    {
                        hangileri[hindex] = metin[j]; // bulduğun karakteri hangileri adlı diziye göm
                        hindex++;
                        adet++;
                    }


                }
            }

            Console.WriteLine("Girmiş olduğunuz metinde {0} adet sesli harf vardır",adet);
            Console.WriteLine(hangileri);
            */
            #endregion

            //10 elamanlı sayısal bir dizim var bu dizideki negatif / pozitif / 0 değerlerin kaç adet olduğunu bulunuz...

            /*

            int pozitifAdet = 0, negatifAdet = 0, NötrAdet = 0;
            int[] sayilar = { 1, 7, -8, -100, 1001, -10, 20, 0, 0, 0, 0, 0, 0, 5 };

            foreach (int sayi in sayilar)
            {
                switch (sayi)
                {
                    case > 0:
                        pozitifAdet++;
                        Console.WriteLine("Sayı : {0} Pozitiftir...", sayi);
                        break;
                    case < 0:
                        negatifAdet++;
                        Console.WriteLine("Sayı : {0} Negatiftir...", sayi);
                        break;
                    default:
                        NötrAdet++;
                        Console.WriteLine("Sayı : {0} Nötrdür...", sayi);
                        break;

                }

            }
            Console.WriteLine("Pozitif adet {0}", pozitifAdet);
            Console.WriteLine("Negatif adet {0}", negatifAdet);
            Console.WriteLine("Nötr adet {0}", NötrAdet);

            */
            
            int sifirsayi = 0, pozsayi = 0, negsayi = 0;
            int[] sayilar = { 1, 7, -8, -100, 1001, -10, 20, 0, 0, 0, 0, 0, 0, 5 };

            for (int i = 0; i < sayilar.Count(); i++)
            {
                switch (sayilar[i])
                {
                    case > 0:
                        pozsayi++;

                        break;
                    case < 0:
                        negsayi++;

                        break;
                    default:
                        sifirsayi++;
                        break;
                }
            }
            Console.WriteLine("Pozitif adet {0}", pozsayi);
            Console.WriteLine("Negatif adet {0}", negsayi);
            Console.WriteLine("Nötr adet {0}", sifirsayi);


            

        }
    }
}
