using _3.Udemy_Methods;
using System;

namespace _4.Udemy_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Kutu kutu = new Kutu(85,66,99);
            

            kutu.Uzunluk = 100;

            Console.WriteLine(kutu.Uzunluk);
            Console.WriteLine(kutu);
            Console.WriteLine(kutu);

            Deneme deneme = new Deneme();

            deneme.Yaz("skjdbaksdasd");
            
        }
        

        
        
        
    }
}
