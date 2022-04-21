using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Facade
{
    public class Connection
    {
        public static string ConnectionName
        {
            get
            {
               return "Data Source=.; Initial Catalog= Northwind; Integrated Security = SSPI";
            }
        }
    }
}
