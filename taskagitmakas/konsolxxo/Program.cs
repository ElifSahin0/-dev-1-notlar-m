using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace konsolxxo
{
    internal class Program { 
    
        static void Main(string[] args)
        {
        Console.WriteLine("Merhaba Oyuncu! Taş Kağıt Makas Oyununa Hoş Geldin. İyi Eğlenceler!");
        string deger = Convert.ToString(Console.ReadLine());
        Random rnd = new Random();
        int sayi =rnd.Next (1, 3);
            //1-t 2-k 3-m
            if (sayi == 1)
            {
                Console.WriteLine("Bilgisayar taşı seçti");
                if (deger == "tas" || deger == "taş")
                {
                    Console.WriteLine("Berabere.");
                }
                else if (deger == "kagit" || deger == "kağıt")
                {

                    Console.WriteLine("Kazandınız.Tebrikler.");
                }
                else if (deger == "makas")
                {

                    Console.WriteLine("Kaybettiniz.Üzgünümm :P");
                }
                else


                {
                    Console.WriteLine("Yanlış bir değer girdiniz.");
                }
            }
            else if (sayi==2)
            {
                Console.WriteLine("Bilgisayar kağıtı seçti");
                if (deger == "kagit" || deger == "kağıt")
                {
                    Console.WriteLine("Berabere.");
                }
                else if (deger == "makas")
                {

                    Console.WriteLine("Kazandınız.Tebrikler.");
                }
                else if (deger == "tas" || deger=="taş" )
                {

                    Console.WriteLine("Kaybettiniz.Üzgünümmm :(");
                }
                else


                {
                    Console.WriteLine(" Yanlış bir değer girdiniz.");
                }
            }
            else 
            {
                Console.WriteLine("Bilgisayar makası seçti");
                if (deger == "makas" )
                {
                    Console.WriteLine("Berabere.");
                }
                else if (deger == "tas" || deger == "taş")
                {

                    Console.WriteLine("Kazandınız.Tebrikler.");
                }
                else if (deger == "kagit")
                {

                    Console.WriteLine("Kaybettiniz.Üzgünümm :P");
                }
                else

                {
                    Console.WriteLine("Yanlış bir değer girdiniz.");
                }
            }

        Console.ReadLine();

        }
    }
}
