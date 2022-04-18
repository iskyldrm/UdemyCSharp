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

namespace _12.Udemy_ADO.NET
{
    public partial class Form1 : Form
    {
        //VERİ TABANI BAĞLANTIIS OLUŞTURMAK İÇİN SQL CONNECTİON OLUŞTURYORUZ

        SqlConnection sqlConnection = new SqlConnection("Data Source=.; Initial Catalog=Northwind; Integrated Security=SSPI");
        public Form1()
        {
            InitializeComponent(); 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

            try
            {
                sqlConnection.Open();
                
                if (sqlConnection.State == ConnectionState.Open) 
                { 
                    
                    label1.Text = "Bağlanti Açık";
                }
                else if (sqlConnection.State == ConnectionState.Closed)
                {
                    label1.Text = "Bağlanti Kapalı";
                }
                else
                {
                    label1.Text = "Bağlantıda pronlem var";
                }
            }
            catch (Exception exm)
            {
                label2.Text ="SQL erro: " + exm.Message;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Close();

                if (sqlConnection.State == ConnectionState.Open)
                {

                    label1.Text = "Bağlanti Açık";
                }
                else if (sqlConnection.State == ConnectionState.Closed)
                {
                    label1.Text = "Bağlanti Kapalı";
                }
                else
                {
                    label1.Text = "Bağlantıda pronlem var";
                }
            }
            catch (Exception exm)
            {
                label2.Text = "SQL erro: " + exm.Message;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open)
                {

                    label1.Text = "Bağlanti Açık";
                }
                else if (sqlConnection.State == ConnectionState.Closed)
                {
                    label1.Text = "Bağlanti Kapalı";
                }
                else
                {
                    label1.Text = "Bağlantıda pronlem var";
                }
            }
            catch (Exception exm)
            {
                label2.Text = "SQL erro: " + exm.Message;

            }
        }
    }
}
