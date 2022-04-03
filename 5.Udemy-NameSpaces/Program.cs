using System;

namespace _5.Udemy_NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            EkCalisma.Ogrenci ogrenci = new EkCalisma.Ogrenci();

            ogrenci.Yaz();
        }
    }
}

namespace EkCalisma
{
    class Ogrenci
    {
        public void Yaz()
        {
            Console.WriteLine("Denendi Çalıştı");
        }
    }
}
      