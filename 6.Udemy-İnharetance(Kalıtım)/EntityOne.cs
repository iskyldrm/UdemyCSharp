using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Udemy_İnharetance_Kalıtım_
{
    public class EntityOne:BaseEntity
    {
        public int Yas { get; set; }

        public string Memlekteti { get; set; }

        private int Sayi1;  

        private int Sayi2; 

        /// <summary>
        /// Sınıfın matematiksel işlemleri için direk sayı girenilirsiniz. 
        /// sonra metdou çağırmanı yetecektir.
        /// </summary>
        /// <param name="Sayim1"></param>
        /// <param name="Sayim2"></param>
        public EntityOne(int Sayim1, int Sayim2)
        {
            this.Sayi1 = Sayim1;
            this.Sayi2 = Sayim2;
        }
        /// <summary>
        /// Sınıfı örnekleyebilirsiniz ve özellikleirni kullanabilirsiniz 
        /// </summary>
        public EntityOne()
        {

        }
        public int Topla()
        {
            int sonuc = 0;
            sonuc = this.Sayi1 + this.Sayi2;

            return sonuc;
        }



    }
}
