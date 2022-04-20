using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Udemy_ADO.NET_Northwind.Bussines
{
    public class Shipper
    {
        public int ShipperId { get; set; }

        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public Shipper()
        {

        }

        public Shipper(int ShipperId, string CompanyName, string Phone)
        {
            this.ShipperId = ShipperId;
            this.CompanyName = CompanyName;
            this.Phone = Phone;
        }

    }
}
