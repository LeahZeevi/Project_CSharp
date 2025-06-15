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
    public partial class Customers : Form
    {
        IBI bi_c = BLApi.Factory.Get();
        public Customers()
        {
            InitializeComponent();
            PanelAddCustomer.Visible = false;
            panelDeleteCustomer.Visible = false;
            panelAllCustomers.Visible = false;
            panelCustomerUpdate.Visible = false;
            panelShowCustomer.Visible = false;
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            panelDeleteCustomer.Visible = false;
            panelAllCustomers.Visible = false;
            panelShowCustomer.Visible = false;
            panelCustomerUpdate.Visible = false;
            PanelAddCustomer.Visible = true;
        }

        private void ButtonSaveCustomer_Click(object sender, EventArgs e)
        {
            string name = InputCustomerName.Text, addres = InputAddres.Text;
            int id = (int)InputCustomerId.Value, phone =(int) InputPhoneCustomer.Value;
            if (id == 0|| name == null || addres == null || phone == 0)
            {
                MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                return;
            }
            try
            {
                bi_c.customer.Create(new BO.Customer(id, name, addres, phone));
            }
            catch (BLIdExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PanelAddCustomer.Visible = false;
        }

        private void ShowAllCustomers_Click(object sender, EventArgs e)
        {
            panelDeleteCustomer.Visible = false;
            PanelAddCustomer.Visible = false;
            panelShowCustomer.Visible = false;
            panelCustomerUpdate.Visible = false;
            panelAllCustomers.Visible = true;
            try
            {
                List<BO.Customer> customers = bi_c.customer.ReadAll();
                dataGridViewAllCustomers.DataSource = customers;
            }
            catch (BLMissingDataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            panelAllCustomers.Visible = false;
            PanelAddCustomer.Visible = false;
            panelShowCustomer.Visible = false;
            panelCustomerUpdate.Visible = false;
            panelDeleteCustomer.Visible = true;
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = (int)InputDeleteCustomer.Value;
            if (id == 0)
            {
                MessageBox.Show("נא הקש תעודת זהות");
                return;
            }
            try
            {
                bi_c.customer.Delete(id);
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            panelDeleteCustomer.Visible = false;
        }

        private void buttonShowCustomer_Click(object sender, EventArgs e)
        {
            PanelAddCustomer.Visible = false;
            panelAllCustomers.Visible = false;
            panelDeleteCustomer.Visible = false;
            panelCustomerUpdate.Visible = false;
            panelShowCustomer.Visible = true;
        }

        private void button_showCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCustomerId.Text);
            if (id == 0)
            {
                MessageBox.Show("נא הקש תעודת זהות");
                return;
            }
            try
            {
                BO.Customer customer = bi_c.customer.Read(id);
                showCustomer.Text = customer.ToString();
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            panelAllCustomers.Visible = false;
            panelDeleteCustomer.Visible = false;
            panelShowCustomer.Visible = false;
            PanelAddCustomer.Visible = false;
            panelCustomerUpdate.Visible = true;
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            int id=int.Parse(CustomerId.Text),phone=int.Parse(CustomerPhone.Text);
            string name=CustomerName.Text,address=Address.Text;
            if (id == 0 || phone == 0 || name == null || address == null)
            {
                MessageBox.Show("אופס! יש בעיה באחד מהנתונים בדוק שכל השדות הושלמו בצורה תקינה");
                return;
            }
            try
            {
                bi_c.customer.Update(new BO.Customer(id, name, address, phone));
                MessageBox.Show("הלקוח עודכן בהצלחה");
                panelCustomerUpdate.Visible = false;
            }
            catch (BlIdNotExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
