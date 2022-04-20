using _13.Udemy_ADO.NET_Northwind.Bussines;
using _13.Udemy_ADO.NET_Northwind.Datebase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Udemy_ADO.NET_Northwind
{
    public partial class Form1 : Form
    {
        List<Shipper> shippers = new List<Shipper>();
        SqlDbContext sqlDbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDbContext = new SqlDbContext("Data Source=.; Initial Catalog=Northwind; Integrated Security= SSPI");

            sqlDbContext.BaglantiAc();
            label1.Text = "Bağlantı Açık";

            SqlDataReader sqlData = sqlDbContext.Sorgu("Select s.ShipperID, CompanyName, Phone from shippers s");
            while (sqlData.Read())
            {
                shippers.Add(new Shipper((int)sqlData[0], sqlData[1].ToString(), sqlData[2].ToString()));
            }
            sqlDbContext.BaglantiKapat();

            dataGridView1.DataSource = shippers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlDbContext = new SqlDbContext("Data Source=.; Initial Catalog=Northwind; Integrated Security= SSPI");
            sqlDbContext.BaglantiKapat();
            label1.Text = "Bağlantı Kapalı";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
