using _3.Udemy_Methods;
using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Bosluk();
            Deneme deneme = new Deneme();

            

            Console.WriteLine("Hello World!");

            deneme.Yaz( GetAccountName(7));

            Bosluk();

            
            
            deneme.Yaz(EnBuyuk(1111,4,3333,99,888).ToString());

        }

        static void Bosluk()
        {
            Console.WriteLine(Environment.NewLine);
        }

        

        public enum AccounName
        {
            Ali,
            İsak,
            Cop,
            Mehmet,
            Adil
        }

        static string GetAccountName(int Id)
        {
            switch (Id)
            {
                case 0:
                    return AccounName.Ali.ToString();
                    break;

                case 1:
                    return AccounName.Adil.ToString();
                    break;
                case 2:
                    return AccounName.Cop.ToString();
                    break;
                case 3:
                    return AccounName.Mehmet.ToString();
                    break;
                case 4:
                    return AccounName.İsak.ToString();
                default:
                    return "Uknowen";
                    break;
            }

        }


        static int EnBuyuk(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
                return b;
        }
        static int EnBuyuk(int a,int b, params int[] ps)
        {
            
            if (ps == null)
            {
                if (a > b)
                {
                    int EnBuyukSayı = 0;
                    
                    EnBuyukSayı = a;
                    return EnBuyukSayı;
                }
                    
                else
                    return b;
            }
            else
            {
                int c = 0;
                foreach (var item in ps)
                {
                    c = EnBuyuk(item, EnBuyuk(a,b));
                    
                }
                return c;
            } 
        }
    }
}
