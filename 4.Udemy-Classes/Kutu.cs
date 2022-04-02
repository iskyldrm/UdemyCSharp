using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4.Udemy_Classes
{
    class Kutu
    {
        /// field (alanlar)
        //erişim berliteçleri
        /*
        public GopherStyleUriParser yerden erişebilir
        private sadece tanımlandığı sınıf içerisnde erişebilir.
        internal sadece bulunduğu projede erişilebilir
        protected sadece tanımlandığı sındı ve miras verdiği sınıfta kullanılır. 
        */

        //field ler olabildiğince dışarı erşime kapalı olamlıdır
        private double genislik;
        private double yukseklik;

        private double uzunluk;

        public double Uzunluk
        {
            get { return this.uzunluk; }
            set { this.uzunluk = value; }
        }

        

        /*
         Ctor yaprak bi clasın constructerı yapılırsa eğer c# arka planda boş constructer oluşturmayı bırakıyor.
        bu durumda kendimiz oluşturmamız lazım bunun sebebi instance alabilmemiz için. Eğer boş ctor oluşmaz ise instance almak için
        parametreli örneklememiz lazım.
        */
        public Kutu()
        {

        }
        public Kutu(double Uzunluk , double Genislik, double Yukseklik)
        {
            this.uzunluk = Uzunluk ;
            this.genislik = Genislik;
            this.yukseklik = Yukseklik;
        }

        

        //Destructur yıkıcı metod
        ~Kutu()
        {
            Console.WriteLine("kapatılıyor");
            Thread.Sleep(3000); 
            Console.ReadLine();
        }

        // capsilation ve uncpsilation 
        // bu özellik kontrollü veri alıp vermek için kullanılır
        //propfull kullanılarak get ve set metdoları çağrılır.
        // kontrol etmek istedğin metodun altına yazılacaklar yazılır.
        //for example
        /*
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */






    }
}
