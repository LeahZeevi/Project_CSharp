using BLApi;
using BO;

namespace UI
{
    public partial class Products : Form
    {
        IBI bi_p = BLApi.Factory.Get();
        public Products()
        {
            InitializeComponent();
            PanelProduct.Visible = false;
            panelUpdate.Visible = false;
            panelDeleteProduct.Visible = false;
            panelAllProduct.Visible = false;
            panelShowProduct.Visible = false;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            panelDeleteProduct.Visible = false;
            panelAllProduct.Visible = false;
            panelShowProduct.Visible = false;
            panelUpdate.Visible = false;
            PanelProduct.Visible = true;
        }


        private void ButtonSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productId= (int)InputProductId.Value, amountInStock= (int)InputAmountInStock.Value;
                BO.Category category = (BO.Category)Enum.Parse(typeof(BO.Category), SelectCategory.Text);
                string productName = InputProductName.Text;
                double price = (double)InputPrice.Value;
                if (productId == 0 || amountInStock == 0 || category == null || productName == null || price == 0)
                {
                    MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                    return;
                }
                bi_p.products.Create(new BO.Product(productId, productName, category, price, amountInStock));
             
                PanelProduct.Visible = false;
            }
            catch(BLIdExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            panelDeleteProduct.Visible = false;
            panelAllProduct.Visible = false;
            panelShowProduct.Visible = false;
            PanelProduct.Visible = false;
            panelUpdate.Visible = true;
        }
        private void ButtenUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = (int)updateProductId.Value, amountInStock = (int)UpdateProductAmount.Value;
                BO.Category category = (BO.Category)Enum.Parse(typeof(BO.Category), UpdateSelectProduct.Text);
                string productName = UpdateProductName.Text;
                double price = (double)UpdateProductPrice.Value;
                if (productId == 0 || amountInStock == 0 || category == null || productName == null || price == 0)
                {
                    MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                    return;
                }
                bi_p.products.Update(new BO.Product(productId,productName,category,price,amountInStock));
                panelUpdate.Visible = false;
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            panelAllProduct.Visible = false;
            panelShowProduct.Visible = false;
            PanelProduct.Visible = false;
            panelDeleteProduct.Visible = true;
        }

        private void Button_SaveDelet_Click(object sender, EventArgs e)
        {
            try
            {
                int id =(int) InputDeletProduct.Value;
                if (id == 0)
                {
                    MessageBox.Show("לא הוקש קוד מוצר!");
                }
                bi_p.products.Delete((int)InputDeletProduct.Value);
                panelDeleteProduct.Visible = false;
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowAllProduct_Click(object sender, EventArgs e)
        {
            try
            {
                panelUpdate.Visible = false;
                panelDeleteProduct.Visible = false;
                panelShowProduct.Visible = false;
                PanelProduct.Visible = false;
                panelAllProduct.Visible = true;
                List<BO.Product> products = bi_p.products.ReadAll();
                    dataGridViewAllProduct.DataSource = products;
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Category category = (BO.Category)Enum.Parse(typeof(BO.Category), comboBoxFilter.Text);
                List<BO.Product> products = bi_p.products.ReadAll(p => p.CategoryName == category);
                if (products.Count > 0)
                {
                    dataGridViewAllProduct.DataSource = products;
                }
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductShow_Click(object sender, EventArgs e)
        {
            PanelProduct.Visible = false;
            panelUpdate.Visible = false;
            panelDeleteProduct.Visible = false;
            panelAllProduct.Visible = false;
            panelShowProduct.Visible = true;

        }

        private void button_SaveShowProduct_Click(object sender, EventArgs e)
        {
            int id = (int)ShowProductId.Value;
            if (id == 0)
            {
                MessageBox.Show("נא הקש קוד!");
            }
            else
            {
                try
                {
                    BO.Product product = bi_p.products.Read(id);
                    labelShowProduct.Text = product.ToString();
                }
                catch (BlIdNotExistsException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
