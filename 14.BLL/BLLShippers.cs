using _14.Entity;
using _14.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BLL
{
    public class BLLShippers
    {
        public static bool BLL_INSERT(EShipper shipper) 
        {
            bool sonuc;

            if (!string.IsNullOrEmpty(shipper.CompanyName) && !string.IsNullOrEmpty(shipper.CompanyPhone))
            {
                if (shipper.CompanyName.Length <=40 && shipper.CompanyPhone.Length <= 24)
                {
                    sonuc = FShippers.Insert(shipper);
                }
                else
                {
                    sonuc=false;
                }
            }
            else
            {
                sonuc=false;
            }
            return sonuc;
        }
        public static bool BLL_UPDATE(EShipper shipper)
        {
            bool sonuc;

            if (shipper.ShipperId > 0 && !string.IsNullOrEmpty(shipper.CompanyName) && !string.IsNullOrEmpty(shipper.CompanyPhone))
            {
                if (shipper.CompanyName.Length <= 40 && shipper.CompanyPhone.Length <= 24)
                {
                    sonuc = FShippers.Update(shipper);
                }
                else
                {
                    sonuc = false;
                }
            }
            else
            {
                sonuc = false;
            }
            return sonuc ;
        }
        public static bool BLL_DELETE(int shipperId)
        {
            bool sonuc;

            
                if (shipperId > 0)
                {
                    sonuc = FShippers.Delete(shipperId);
                }
                else
                {
                    sonuc = false;
                }
           
             
            
            return sonuc;
        }
    }
}
