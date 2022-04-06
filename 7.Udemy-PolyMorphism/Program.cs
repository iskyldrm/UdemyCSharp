using System;

namespace _7.Udemy_PolyMorphism
{
    /*
     Polimorfizm bir sınıfın miras aldığı sınfı gibi daranabilmesidir.
    bu sayede MİRAS ALDIĞI SINIFIN ÖZELLİKLERİNİ GÖSTEREBİLİR. VE MİRAS ALDIĞI SINIFIN KULLANILABİLDEĞİ
    HER YERDE KULLANILABİKLİR DURUMA GELİR.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();



            Sampuan sampuan = new Sampuan();
            sampuan.ProductId = 1;
            sampuan.ProductName = "Elidor";
            sampuan.ProductCategory = "Hijyen";
            sampuan.SampuanType = SampuanType.KepegeKarsı;
            sampuan.SampuanLt = SampuanLt.İkiYüz;
            sampuan.ProductPrice = 300;

            Bread bread = new Bread();

            bread.ProductId = 1;
            bread.ProductName = "Ekmek";
            bread.ProductCategory = "Yiyecek";
            bread.BreadType = BreadType.Kepek;
            bread.BreadGr = BreadGr.İkiYüz;
            bread.ProductPrice = 600;

            product.Add(bread);
            product.Add(sampuan);

            

            Console.WriteLine("Toplam Tutar" + product.TotalPrice());
        }
    }
}
