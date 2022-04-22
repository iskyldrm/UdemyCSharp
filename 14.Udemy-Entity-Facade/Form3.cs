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
using _14.BLL;

namespace _14.Udemy_Entity_Facade
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            btnCompanyAdd.Click += BtnCompanyAdd_Click;
        }

        private void BtnCompanyAdd_Click(object? sender, EventArgs e)
        {
            string mesaj = string.Empty;

            EShipper shipper = new EShipper();
            shipper.CompanyName = txtCNE.Text;
            shipper.CompanyPhone = txtCPE.Text;

            bool sonuc = BLLShippers.BLL_INSERT(shipper);

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
