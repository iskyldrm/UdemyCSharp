using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Udemy_İnharetance_Kalıtım_
{
    public  class BaseEntity
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string SoyAdi { get; set; }

        public void InharetenceMethods()
        {
            Console.WriteLine("Bu calistiysa BaseEntityden miras alınmıstır");
        }

    }
}
