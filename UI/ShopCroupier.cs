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
    public partial class ShopCroupier : Form
    {
        public ShopCroupier()
        {
            InitializeComponent();
        }

        private void buttonStartOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.FormClosed += Close_MenuShopCroupier;
            order.Show();
        }

        private void Close_MenuShopCroupier(object? sender, FormClosedEventArgs e)
        {
            this.Show();//הצגה מחדש של החלון הראשון
        }
    }
}
