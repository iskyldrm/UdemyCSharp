using System;
using System.Reflection;
using System.Text;

namespace _6.Udemy_İnharetance_Kalıtım_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EntityOne entityOne = new EntityOne(3,6);
            entityOne.Id = 0;
            entityOne.Adi = "isak";
            entityOne.SoyAdi = "Yildirim";
            entityOne.Memlekteti = "Erzincan";
            entityOne.Yas = 27;

            



            StringBuilder builder = new StringBuilder();

            builder.Append($"ID:        "+$"{entityOne.Id}" + "\n");    
            builder.Append($"ADI:       "+$"{entityOne.Adi}" + "\n");
            builder.Append($"SOYADI:    "+$"{entityOne.SoyAdi}" + "\n");
            builder.Append($"YASI:      "+$"{entityOne.Yas}" + "\n");
            builder.Append($"MEMLEKETİ: "+$"{entityOne.Memlekteti}" + "\n");
            builder.Append($"TOPLAMI:   "+$"{entityOne.Topla()}" + "\n");


            Console.WriteLine(builder);
        }


        public static void Bosluk()
        {
            Console.WriteLine("\n");
        }
    }
}
