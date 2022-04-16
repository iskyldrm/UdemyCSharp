using System;

namespace _8.Udemy_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Delgate ler metod temsilcileri olarak geçer. ve metod imzası aynı olan tüm metdoları temsil edebilirler.

            Hesap<string> hesap = new Hesap<string>(Ekle);

            //int sonuc = hesap(3, 5);

            //Console.WriteLine(sonuc);

            //hesap = Cıkar;

            //Console.WriteLine(hesap(9,7));

            hesap("alimmmm");

            //Console.WriteLine(hesap.ToString());

            static int Topla(int sayi1,int sayi2)
            {
                return sayi1 + sayi2;
            }

            static void Ekle(string mesaj)
            {
                Console.WriteLine(mesaj);
                
            }
            static int Cıkar(int sayi1, int sayi2)
            {
                return (sayi1 - sayi2);
            }




            


           



        }
    }
    delegate void Hesap<T>(T x);
}
