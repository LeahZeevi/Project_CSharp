using BLApi;
using BO;
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
    public partial class Order : Form
    {
        IBI bi_o = BLApi.Factory.Get();
        BO.Order order = new BO.Order { ProductList = new List<ProductInOrder>() };
        
        public Order()
        {
            InitializeComponent();
            panelAllProducts.Visible = false;
            panelOrderDetails.Visible = false;
            panelChooseAddProduct.Visible = false;
            panelAddProductById.Visible = false;
        }
        public void PrintOrder()
        {
            if (panelOrderDetails.Visible == false)
                panelOrderDetails.Visible = true;
            dataGridViewOrderdetails.DataSource = order.ProductList.ToList();
            labelTotalPrice.Text = order.OrderPrice.ToString();
        }

        private void AddProductToOrder_Click(object sender, EventArgs e)
        {
            panelAllProducts.Visible = true;
            try
            {
                List<BO.Product> products = bi_o.products.ReadAll();
                dataGridViewAllProduct.DataSource = products;

                bi_o.order.CalcTotalPrice(order);
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            panelAllProducts.Visible = false;
            panelChooseAddProduct.Visible = true;
        }
        private void buttonShowAllProducts_Click(object sender, EventArgs e)
        {
            panelChooseAddProduct.Visible = false;
            panelAddProductById.Visible = false;
            panelAllProducts.Visible = true;
            try
            {
                List<BO.Product> products = bi_o.products.ReadAll();
                dataGridViewAllProduct.DataSource = products;
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddProductFromDataGridView_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewAllProduct.CurrentRow;
            if (currentRow == null || currentRow.Cells.Count <= 0)
            {
                MessageBox.Show("לא נבחר מוצר להזמנה!");
                return;
            }
            try
            {
                int id = (int)currentRow.Cells[0].Value;
                int amount = (int)inputCountToOrder.Value;
                if (id <= 0 || amount <= 0)
                {
                    MessageBox.Show("לא הוזנו מספיק נתונים עבור הוספת מוצר זה!!");
                    return;
                }
                bi_o.order.AddProductToOrder(order, id, amount);
                bi_o.order.CalcTotalPrice(order);
                PrintOrder();
                panelAllProducts.Visible = false;
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEnterProductId_Click(object sender, EventArgs e)
        {
            panelChooseAddProduct.Visible = false;
            panelAllProducts.Visible = false;
            panelAddProductById.Visible = true;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int id = (int)InputProductId.Value;
            int amount = (int)InputAmountToOrder.Value;
            if (id <= 0 || amount <= 0)
            {
                MessageBox.Show("לא הוזנו מספיק נתונים עבור הוספת מוצר זה!!");
                return;
            }
            try
            {
                bi_o.order.AddProductToOrder(order, id, amount);
                bi_o.order.CalcTotalPrice(order);
            }

            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PrintOrder();
            panelAddProductById.Visible = false;
        }

        private void panelOrderDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonFinishOrder_Click(object sender, EventArgs e)
        {
            bi_o.order.DoOrder(order);
            panelAllProducts.Visible = false;
            panelAddProductById.Visible = false;
            panelOrderDetails.Visible = false;
            MessageBox.Show($"ההזמנה בוצעה בהצלחה! סכום לתשלום: {order.OrderPrice}");
            this.Close(); 
        }
    }
}
