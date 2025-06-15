using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void product_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            this.Hide();
            products.FormClosed += Menu_FormClosed;
            products.Show();

        }

     
        private void customer_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();
            customers.FormClosed += Menu_FormClosed;
            customers.Show();
        }
        private void sale_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            this.Hide();
            sales.FormClosed += Menu_FormClosed;
            sales.Show();
        }
        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();//הצגה מחדש של החלון הראשון
        }

    }
}
