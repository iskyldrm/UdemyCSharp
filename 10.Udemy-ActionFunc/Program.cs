using System;

namespace _10.Udemy_ActionFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Action ve Action<T> delege türleri .Net framework 3.5 ile gelen önceden tanımlanmış 
            bir delege türüdür. Action<T> delege türleri Func<T> delegelerinin aksine hiçbir 
            değer döndürmeyen metodları temsil etmektedir. Action delege türü hiçbir parametre 
            almayan ve değer döndürmeyen metodları temsil eder. Adından da anlaşılacağı üzere 
            bir fonksiyonu değil bir eylemi(action) temsil etmektedirler.
             Action<T> delegeleri birden fazla parametre alabilecek metodları da temsil edebilecek şekilde tasarlanmıştır.
                Action
                Action <T>
                Action <T1,T2 >
                Action <T1,T2,T3>
                Action <T1,T2,…,TN>
            Her bir T, metodların alacağı parametrelerin tiplerini belirtmektedir. 
            Func<T> gibi Action<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
             */

            Console.WriteLine("Hello World!");
            Action<int, string> action = new Action<int, string>(KullaniciBilgileri);
            action.Invoke(3, "İsak Yıldırım");

            /*Func(Önceden Tanımlanmış Delege Türü)
       Func<T> önceden tanımlanmış olan ve T tipinde değerler döndüren metodları temsil eden 
       bir delegedir.Func<T> tipi birden fazla parametre ile beslenebilecek şekilde 
       hazırlanmış bir tiptir. Yani bir veya birden fazla parametre alabilecek metodları 
       temsil eden önceden tanımlanmış bir delege türüdür.

       Func<T> kullandığımızda delege tanımlamamıza gerek kalmamaktadır.
           Func<T>
           Func<T, Tresult>
           Func<T1, T2, Tresult>
           Func<T1, T2,…T3, Tresult>
       Her bir T metodun alacağı parametre tipini ve TResult ise temsil edilen 
       metodun dönüş tipipni temsil etmektedir.
       Func tipi, bir veya birden fazla(16 haneye kadar) parametre alabilen ve geriye T
       tipinde değer döndüren bir delege yapısıdır.Bu delege sayesinde, alacağı parametreler
       ve geriye döndüreceği değeri simgeleyen delegemizi tanımlayabilir ve o
       tanımladığımız yapıdaki herhangi bir metodu bu delegeye işaretletebiliriz.
       Eğer bir işlemde delegeye ihtiyacınız varsa, Func ile hızlı ve pratik bir
       şekilde ihtiyacınızı giderebilir ve delegeyle uğraşmanıza gerek kalmayabilir.*/

            Func<double> func = () => YasHesaplama(new DateTime(1994, 1, 1));

            double sonuc = func();
            Console.WriteLine("Yasadiginiz Gün Sayısı: " + sonuc);


            int[] sayilar = new int[3];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;


            


        }


        static void KullaniciBilgileri(int KulId, string KulAdi)
        {
            Console.WriteLine("Kullanıcı Id:  " + KulId);
            Console.WriteLine("Kullanıcı Adi: " + KulAdi);
        }

        static double YasHesaplama(DateTime yas)
        {
            double YasananGun = (DateTime.Now - yas).Days;

            return YasananGun;
        }

        public static void PredicateSample()
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Predicate<int> tekSayilar = (sayi) =>
            {
                return sayi % 2 == 0;

            };
        }

    }
}
