using _14.BLL;
using _14.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14.Udemy_Entity_Facade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string mesaj = string.Empty;

            EShipper shipper = new EShipper();
            
            var shipperID = Convert.ToInt32(txtIDS.Text);

            bool sonuc = BLLShippers.BLL_DELETE(shipperID);

            if (sonuc)
            {
                mesaj = "İşlem Başarılı";

            }
            else
            {
                mesaj = "İşlem Başarız";
            }

            MessageBox.Show(mesaj, "İşlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
