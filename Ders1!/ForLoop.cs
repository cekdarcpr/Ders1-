using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1_
{
     internal class ForLoop
    {
        public static void Main(string[] args)
        {
            //1 den 100 e kadar olan sayıların toplamı

            //int toplam = 0;

            //for (int sayac = 1; sayac  <= 100; sayac ++)
            //{
            //    toplam = toplam + sayac; // toplam += sayac;

            //    Console.Write("Sayaç : {0} - Toplam : {1} \n",sayac,toplam);
            //}

            /*
             





            int toplam = 0;
            int adet = 0;
            Console.WriteLine("Sayını Gir : ");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayını gir");
            int sayı3 = Convert.ToInt32(Console.ReadLine());    

            for (int sayi = sayı2; sayi <= sayı3 ; sayi++)
            {
                if (sayi % 5 == 0 && sayi % 7 != 0) //5'e bölünümünde 0 kalıcak...
                {
                    adet++;

                    toplam += sayi;

                    Console.WriteLine("Sayı : {0} - Toplam : {1}",sayi,toplam);

                }
            }

            Console.WriteLine("5'e bölünen 7'ye bölünemeyen sayıların adedi = {0}",adet);


            */


            double toplam = 0;
            int bnot = 0 ,knot = 0;

            //Console.WriteLine("1.Sayı : ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı : ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayı : ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            for (int sayac = 0,not; sayac < 10; sayac++)//Satırda yeni değişken tanımlana biliyor...
            {
                Console.WriteLine("Lütfen {0}. Notunuzu Giriniz",sayac+1);//Dinamik mesaj veriliyord...

                not = Convert.ToInt32(Console.ReadLine());

                if (not > 100 || not < 0) // 0 100 aralığında olmalı... 
                {
                    Console.WriteLine("Yanlış Not Girdiniz...");
                    sayac--;
                    continue; 
                }
                if (sayac == 0) //İlk sayıyı okumak
                {
                    bnot = not;
                    knot = not; 
                }
                else
                {
                    if (not > bnot) 
                    {
                        bnot = not;
                    }
                    if (not <knot)
                    {
                        knot = not;
                    }
                }

                toplam += not;

            }

            Console.WriteLine("En büyük not : {0}\nEn küçük not: {1}\nOrtalama : {2}",bnot,knot,toplam/3);

            



            Console.ReadKey();  







        }

    }
}
