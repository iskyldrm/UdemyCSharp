using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Udemy_PolyMorphism
{
    public enum SampuanType
    {
        KepegeKarsı = 0,
        Parlak = 1,
    }

    public enum SampuanLt
    {
        Yüz = 100,
        İkiYüz = 200
    }
    public class Sampuan:Product
    {
        public SampuanType SampuanType { get; set; }
        public SampuanLt SampuanLt { get; set; }

    }
}
