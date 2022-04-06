using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Udemy_PolyMorphism
{
    public enum BreadType
    {
        Odun = 0,
        Somun = 1,
        TasFırın = 2,
        Kepek= 3

    }

    public enum BreadGr
    {
        Yüz = 100,
        İkiYüz =200
    }
    
    public class Bread:Product
    {
        public BreadType BreadType { get; set; }
        public BreadGr BreadGr { get; set; }
        
    }
}
