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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            string mesaj = string.Empty;

            EShipper shipper = new EShipper();
            shipper.CompanyName = txtCNG.Text;
            shipper.CompanyPhone = txtCPG.Text;
            shipper.ShipperId = Convert.ToInt32(txtIDG.Text);

            bool sonuc = BLLShippers.BLL_UPDATE(shipper);

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
