using _13.Udemy_ADO.NET_Northwind.Bussines;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace _13.Udemy_ADO.NET_Northwind.Datebase
{
    
    public class SqlDbContext
    {
        SqlConnection conn;
        SqlCommand cmd;
        public const string DATABASE_NAME = "Data Source=.; Initial Catalog=Northwind; Integrated Security= SSPI";
        public SqlDbContext()
        {
                
        }
        

        public SqlDbContext(string path)
        {
            if (path == null)
            {
            path = DATABASE_NAME;
            this.conn = new SqlConnection(path);
            }
            else
            {
                path = DATABASE_NAME;
                this.conn = new SqlConnection(path);
            }
            
        }

        public void BaglantiAc()
        {
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                
            }
           
            
           
            
        }
        public void BaglantiKapat()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }

        public SqlDataReader Sorgu(string sorgu) 
        {
            cmd = new SqlCommand();
            cmd.CommandText = sorgu;
            cmd.Connection = this.conn;
            BaglantiAc();

            return cmd.ExecuteReader();
        }
    }
}
