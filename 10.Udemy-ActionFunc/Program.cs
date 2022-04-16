using System;

namespace _10.Udemy_ActionFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Action<int, string> action = new Action<int, string>(KullaniciBilgileri);
            action.Invoke(3,"İsak Yıldırım");
        }


        static void KullaniciBilgileri(int KulId, string KulAdi)
        {
            Console.WriteLine("Kullanıcı Id:  " + KulId);
            Console.WriteLine("Kullanıcı Adi: " + KulAdi);
        }
    }

}
