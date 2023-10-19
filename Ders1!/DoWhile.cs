using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1_
{
    internal class DoWhile
    {
        public static void Main(string[] args) 
        {

            //Başlangıç ve bitiş değerleri alınacak ve toplamları ekrana yazılacak
            //  Ödev


            // sabit olan kullanıcı adı ve şifreyi...

            const string kullanıcı_adi = "admin";
            const string sifre = "12345";
           
            string k_adı = "";
            string k_sifre = "";

            bool esit = false;

            do
            {
                Console.WriteLine("Kullanıcı Adı : ");
                k_adı = Console.ReadLine();

                Console.WriteLine("Şifre : ");
                k_sifre = Console.ReadLine();

                if (kullanıcı_adi == k_adı && sifre == k_sifre)
                {
                    Console.WriteLine("Hoşgeldiniz...");
                    esit= true; 
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış bilgi...");
                }
                
                
            } while (esit ==false);

                


        }
    }
}
