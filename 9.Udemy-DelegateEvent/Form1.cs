using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Udemy_DelegateEvent
{
    delegate int del(int x);
    delegate string del2(string x);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += Form1_Click;

            del goster = x => x * x;
            int y = goster(3);
            MessageBox.Show(y.ToString());

            Button button = new Button();

            button.Text = "tıkla";
            button.Name = "btntikla";
            button.Width = 100;
            button.Height = 50;
            button.Left = 200;
            button.Top = 200;
            button.Click += delegate (object sender, EventArgs e)
            {
                string mesaj = (sender as Button).Text;
                MessageBox.Show(mesaj);
            };
            this.Controls.Add(button);

        }

        private void Form1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).Location.ToString());
        }
    }
}
