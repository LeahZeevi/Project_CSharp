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
    public partial class Sales : Form
    {
        IBI bi_s = BLApi.Factory.Get();
        public Sales()
        {
            InitializeComponent();
            panelSaleUpdate.Visible = false;
            panelAllsales.Visible = false;
            PanelAddSale.Visible = false;
            panelShowSale.Visible = false;
            panelDeletSale.Visible = false;
        }



        private void ButtonSaleUpdate_Click(object sender, EventArgs e)
        {


            int saleId, productId, amountForSale;
            bool isForAll;
            double totalPrice;
            DateTime dateStart, dateEnd;
            saleId = (int)UpdateSaleId.Value;
            productId = (int)UpdateSaleProdctId.Value;
            amountForSale = (int)saleUpdateAmountSale.Value;
            totalPrice = (double)saleUpdateProductPrice.Value;
            isForAll = saleUpdateIsForAll.Checked;
            dateStart = saleUpdateStartSale.Value;
            dateEnd = saleUpdateEndSale.Value;
            if (saleId == 0 || productId == 0 || amountForSale <= 0 || totalPrice <= 0)
            {
                MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                return;
            }
            try
            {
                bi_s.sale.Update(new BO.Sale((int)UpdateSaleId.Value, (int)UpdateSaleProdctId.Value, (int)saleUpdateAmountSale.Value, saleUpdateIsForAll.Checked, (double)saleUpdateProductPrice.Value, saleUpdateStartSale.Value, saleUpdateEndSale.Value));

            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("המבצע עודכן בהצלחה!!");
            panelSaleUpdate.Visible = false;
        }
        private void UpdateSale_Click(object sender, EventArgs e)
        {
            panelShowSale.Visible = false;
            PanelAddSale.Visible = false;
            panelAllsales.Visible = false;
            panelDeletSale.Visible = false;
            panelSaleUpdate.Visible = true;
        }

        private void ShowAllSale_Click(object sender, EventArgs e)
        {
            panelShowSale.Visible = false;
            PanelAddSale.Visible = false;
            panelSaleUpdate.Visible = false;
            panelDeletSale.Visible = false;
            panelAllsales.Visible = true;
            try
            {
                List<Sale> allSales = bi_s.sale.ReadAll();
                dataGridViewAllsalses.DataSource = allSales;
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<BO.Sale> sales = bi_s.sale.ReadAll(s => s.DateStartSale.Date >= dateTimePicker.Value.Date);
                dataGridViewAllsalses.DataSource = sales;
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void AddSale_Click(object sender, EventArgs e)
        {
            panelShowSale.Visible = false;
            panelAllsales.Visible = false;
            panelSaleUpdate.Visible = false;
            panelDeletSale.Visible = false;
            PanelAddSale.Visible = true;
        }



        private void ButtonSaveSale_Click(object sender, EventArgs e)
        {
            int saleId, productId, amountForSale;
            bool isForAll;
            double totalPrice;
            DateTime dateStart, dateEnd;
            saleId = (int)InputSaleId.Value;
            productId = (int)InputProductId.Value;
            amountForSale = (int)InputAmountForSale.Value;
            totalPrice = (double)inputTotalPrice.Value;
            isForAll = checkBoxSale.Checked;
            dateStart = dateTimePickerStartSale.Value;
            dateEnd = dateTimePickerEndSale.Value;
            if (saleId == 0 || productId == 0 || amountForSale <= 0 || totalPrice <= 0 || dateStart == DateTime.MinValue || dateEnd == DateTime.MinValue)
            {
                MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                return;
            }
            try
            {
                bi_s.sale.Create(new Sale(saleId, productId, amountForSale, totalPrice, isForAll, dateStart, dateEnd));
            }
            catch (BlIdNotExistsException ex)//If the product type does not exist!
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (BLIdExistsException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("המבצע נוסף בהצלחה!!");
            PanelAddSale.Visible = false;
        }

        private void button_showSale_Click(object sender, EventArgs e)
        {
            int id = (int)numericUpDownSaleId.Value;
            if (id == null)
            {
                MessageBox.Show("נא הקש קוד!");
            }
            try
            {
                BO.Sale sale = bi_s.sale.Read(id);
                labelshowSale.Text = sale.ToString();
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void SaleShow_Click(object sender, EventArgs e)
        {
            panelSaleUpdate.Visible = false;
            panelAllsales.Visible = false;
            PanelAddSale.Visible = false;
            panelDeletSale.Visible = false;
            panelShowSale.Visible = true;
        }

        private void buttonDeletSale_Click(object sender, EventArgs e)
        {
            int id = (int)InputDeleteSaleID.Value;
            if (id == null)
            {
                MessageBox.Show("נא הקש קוד!");
                return;
            }
            try
            {
                bi_s.sale.Delete(id);
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("המבצע נמחק בהצלחה");
            panelDeletSale.Visible = false;
        }

        private void DeleteSale_Click(object sender, EventArgs e)
        {
            panelSaleUpdate.Visible = false;
            panelAllsales.Visible = false;
            PanelAddSale.Visible = false;
            panelShowSale.Visible = false;
            panelDeletSale.Visible = true;
        }

        private void PanelAddSale_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

