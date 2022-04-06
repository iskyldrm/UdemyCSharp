using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Udemy_PolyMorphism
{
    
    public class Product
    {
        public List<Product> products = new List<Product>();

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public int ProductPrice { get; set; }

        public int ProductKDV { get; set; }

       
        public List<Product> Add(Product product)
        {
            products.Add(product);
            
            return products;
        }

        public double TotalPrice()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total += product.ProductPrice;
            }

            return total;
        }



    }
}
