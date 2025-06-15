namespace UI
{
    partial class Customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCustomerUpdate = new Panel();
            CustomerName = new TextBox();
            Address = new TextBox();
            CustomerPhone = new TextBox();
            CustomerId = new TextBox();
            buttonUpdateCustomer = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PanelAddCustomer = new Panel();
            InputCustomerId = new NumericUpDown();
            InputPhoneCustomer = new NumericUpDown();
            InputCustomerName = new TextBox();
            InputAddres = new TextBox();
            ButtonSaveCustomer = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelShowCustomer = new Panel();
            showCustomer = new Label();
            textBoxCustomerId = new TextBox();
            labelshowSale = new Label();
            label19 = new Label();
            button_showCustomer = new Button();
            label20 = new Label();
            panelDeleteCustomer = new Panel();
            buttonDeleteCustomer = new Button();
            label21 = new Label();
            InputDeleteCustomer = new NumericUpDown();
            SaleShow = new Button();
            panelAllCustomers = new Panel();
            label12 = new Label();
            ButtonFilter = new Button();
            dataGridViewAllCustomers = new DataGridView();
            ShowAllCustomers = new Button();
            DeleteCustomer = new Button();
            UpdateCustomer = new Button();
            AddCustomer = new Button();
            buttonShowCustomer = new Button();
            label7 = new Label();
            label8 = new Label();
            panelCustomerUpdate.SuspendLayout();
            PanelAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputCustomerId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPhoneCustomer).BeginInit();
            panelShowCustomer.SuspendLayout();
            panelDeleteCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeleteCustomer).BeginInit();
            panelAllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).BeginInit();
            SuspendLayout();
            // 
            // panelCustomerUpdate
            // 
            panelCustomerUpdate.Controls.Add(label8);
            panelCustomerUpdate.Controls.Add(CustomerName);
            panelCustomerUpdate.Controls.Add(Address);
            panelCustomerUpdate.Controls.Add(CustomerPhone);
            panelCustomerUpdate.Controls.Add(CustomerId);
            panelCustomerUpdate.Controls.Add(buttonUpdateCustomer);
            panelCustomerUpdate.Controls.Add(label4);
            panelCustomerUpdate.Controls.Add(label5);
            panelCustomerUpdate.Controls.Add(label6);
            panelCustomerUpdate.Location = new Point(224, 41);
            panelCustomerUpdate.Margin = new Padding(3, 4, 3, 4);
            panelCustomerUpdate.Name = "panelCustomerUpdate";
            panelCustomerUpdate.Size = new Size(599, 555);
            panelCustomerUpdate.TabIndex = 43;
            // 
            // CustomerName
            // 
            CustomerName.Location = new Point(142, 131);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(125, 27);
            CustomerName.TabIndex = 56;
            // 
            // Address
            // 
            Address.Location = new Point(142, 190);
            Address.Name = "Address";
            Address.Size = new Size(125, 27);
            Address.TabIndex = 55;
            // 
            // CustomerPhone
            // 
            CustomerPhone.Location = new Point(142, 284);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.Size = new Size(125, 27);
            CustomerPhone.TabIndex = 54;
            // 
            // CustomerId
            // 
            CustomerId.Location = new Point(142, 69);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(125, 27);
            CustomerId.TabIndex = 53;
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(190, 430);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(167, 56);
            buttonUpdateCustomer.TabIndex = 52;
            buttonUpdateCustomer.Text = "עידכון";
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 287);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 51;
            label4.Text = "טלפון";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 124);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 50;
            label5.Text = "שם מלא";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 69);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 49;
            label6.Text = "תעודת זהות";
            // 
            // PanelAddCustomer
            // 
            PanelAddCustomer.Controls.Add(label7);
            PanelAddCustomer.Controls.Add(InputCustomerId);
            PanelAddCustomer.Controls.Add(InputPhoneCustomer);
            PanelAddCustomer.Controls.Add(InputCustomerName);
            PanelAddCustomer.Controls.Add(InputAddres);
            PanelAddCustomer.Controls.Add(ButtonSaveCustomer);
            PanelAddCustomer.Controls.Add(label3);
            PanelAddCustomer.Controls.Add(label2);
            PanelAddCustomer.Controls.Add(label1);
            PanelAddCustomer.Location = new Point(189, 64);
            PanelAddCustomer.Margin = new Padding(3, 4, 3, 4);
            PanelAddCustomer.Name = "PanelAddCustomer";
            PanelAddCustomer.Size = new Size(591, 528);
            PanelAddCustomer.TabIndex = 42;
            // 
            // InputCustomerId
            // 
            InputCustomerId.Location = new Point(228, 70);
            InputCustomerId.Margin = new Padding(3, 4, 3, 4);
            InputCustomerId.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            InputCustomerId.Name = "InputCustomerId";
            InputCustomerId.Size = new Size(137, 27);
            InputCustomerId.TabIndex = 50;
            // 
            // InputPhoneCustomer
            // 
            InputPhoneCustomer.Location = new Point(234, 260);
            InputPhoneCustomer.Margin = new Padding(3, 4, 3, 4);
            InputPhoneCustomer.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            InputPhoneCustomer.Name = "InputPhoneCustomer";
            InputPhoneCustomer.Size = new Size(137, 27);
            InputPhoneCustomer.TabIndex = 49;
            // 
            // InputCustomerName
            // 
            InputCustomerName.Location = new Point(209, 126);
            InputCustomerName.Name = "InputCustomerName";
            InputCustomerName.Size = new Size(125, 27);
            InputCustomerName.TabIndex = 48;
            // 
            // InputAddres
            // 
            InputAddres.Location = new Point(216, 194);
            InputAddres.Name = "InputAddres";
            InputAddres.Size = new Size(125, 27);
            InputAddres.TabIndex = 47;
            // 
            // ButtonSaveCustomer
            // 
            ButtonSaveCustomer.Location = new Point(257, 425);
            ButtonSaveCustomer.Name = "ButtonSaveCustomer";
            ButtonSaveCustomer.Size = new Size(167, 56);
            ButtonSaveCustomer.TabIndex = 36;
            ButtonSaveCustomer.Text = "הוספה";
            ButtonSaveCustomer.Click += ButtonSaveCustomer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 258);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "טלפון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 119);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "שם מלא";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 64);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 6;
            label1.Text = "תעודת זהות";
            // 
            // panelShowCustomer
            // 
            panelShowCustomer.Controls.Add(showCustomer);
            panelShowCustomer.Controls.Add(textBoxCustomerId);
            panelShowCustomer.Controls.Add(labelshowSale);
            panelShowCustomer.Controls.Add(label19);
            panelShowCustomer.Controls.Add(button_showCustomer);
            panelShowCustomer.Controls.Add(label20);
            panelShowCustomer.Location = new Point(170, 94);
            panelShowCustomer.Margin = new Padding(3, 4, 3, 4);
            panelShowCustomer.Name = "panelShowCustomer";
            panelShowCustomer.Size = new Size(504, 446);
            panelShowCustomer.TabIndex = 46;
            // 
            // showCustomer
            // 
            showCustomer.AutoSize = true;
            showCustomer.Location = new Point(173, 215);
            showCustomer.Name = "showCustomer";
            showCustomer.Size = new Size(0, 20);
            showCustomer.TabIndex = 47;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(140, 128);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(125, 27);
            textBoxCustomerId.TabIndex = 46;
            // 
            // labelshowSale
            // 
            labelshowSale.AutoSize = true;
            labelshowSale.Location = new Point(50, 202);
            labelshowSale.Name = "labelshowSale";
            labelshowSale.Size = new Size(0, 20);
            labelshowSale.TabIndex = 9;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(79, 227);
            label19.Name = "label19";
            label19.Size = new Size(0, 20);
            label19.TabIndex = 8;
            // 
            // button_showCustomer
            // 
            button_showCustomer.Location = new Point(49, 111);
            button_showCustomer.Margin = new Padding(3, 4, 3, 4);
            button_showCustomer.Name = "button_showCustomer";
            button_showCustomer.Size = new Size(72, 61);
            button_showCustomer.TabIndex = 7;
            button_showCustomer.Text = "הצג";
            button_showCustomer.UseVisualStyleBackColor = true;
            button_showCustomer.Click += button_showCustomer_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(69, 79);
            label20.Name = "label20";
            label20.Size = new Size(121, 20);
            label20.TabIndex = 6;
            label20.Text = "הקש תעודת זהות";
            // 
            // panelDeleteCustomer
            // 
            panelDeleteCustomer.Controls.Add(buttonDeleteCustomer);
            panelDeleteCustomer.Controls.Add(label21);
            panelDeleteCustomer.Controls.Add(InputDeleteCustomer);
            panelDeleteCustomer.Location = new Point(133, 125);
            panelDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            panelDeleteCustomer.Name = "panelDeleteCustomer";
            panelDeleteCustomer.Size = new Size(466, 239);
            panelDeleteCustomer.TabIndex = 47;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(16, 121);
            buttonDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(169, 60);
            buttonDeleteCustomer.TabIndex = 27;
            buttonDeleteCustomer.Text = "מחיקה";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(84, 28);
            label21.Name = "label21";
            label21.Size = new Size(121, 20);
            label21.TabIndex = 26;
            label21.Text = "הקש תעודת זהות";
            // 
            // InputDeleteCustomer
            // 
            InputDeleteCustomer.Location = new Point(32, 76);
            InputDeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            InputDeleteCustomer.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            InputDeleteCustomer.Name = "InputDeleteCustomer";
            InputDeleteCustomer.Size = new Size(137, 27);
            InputDeleteCustomer.TabIndex = 25;
            // 
            // SaleShow
            // 
            SaleShow.Location = new Point(660, -54);
            SaleShow.Margin = new Padding(3, 4, 3, 4);
            SaleShow.Name = "SaleShow";
            SaleShow.Size = new Size(159, 47);
            SaleShow.TabIndex = 45;
            SaleShow.Text = "הצגת מבצע";
            SaleShow.UseVisualStyleBackColor = true;
            // 
            // panelAllCustomers
            // 
            panelAllCustomers.Controls.Add(label12);
            panelAllCustomers.Controls.Add(ButtonFilter);
            panelAllCustomers.Controls.Add(dataGridViewAllCustomers);
            panelAllCustomers.Location = new Point(249, 23);
            panelAllCustomers.Margin = new Padding(3, 4, 3, 4);
            panelAllCustomers.Name = "panelAllCustomers";
            panelAllCustomers.Size = new Size(777, 580);
            panelAllCustomers.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(132, 418);
            label12.Name = "label12";
            label12.Size = new Size(260, 20);
            label12.TabIndex = 5;
            label12.Text = "הצגת כל המבצעים החל מתאריך מסוים";
            // 
            // ButtonFilter
            // 
            ButtonFilter.Location = new Point(287, 476);
            ButtonFilter.Margin = new Padding(3, 4, 3, 4);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(63, 44);
            ButtonFilter.TabIndex = 4;
            ButtonFilter.Text = "סינון";
            ButtonFilter.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllCustomers
            // 
            dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllCustomers.Location = new Point(48, 14);
            dataGridViewAllCustomers.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            dataGridViewAllCustomers.RowHeadersWidth = 51;
            dataGridViewAllCustomers.Size = new Size(702, 339);
            dataGridViewAllCustomers.TabIndex = 0;
            // 
            // ShowAllCustomers
            // 
            ShowAllCustomers.Location = new Point(1091, 511);
            ShowAllCustomers.Margin = new Padding(3, 4, 3, 4);
            ShowAllCustomers.Name = "ShowAllCustomers";
            ShowAllCustomers.Size = new Size(159, 70);
            ShowAllCustomers.TabIndex = 41;
            ShowAllCustomers.Text = "הצגת כל הלקוחות";
            ShowAllCustomers.UseVisualStyleBackColor = true;
            ShowAllCustomers.Click += ShowAllCustomers_Click;
            // 
            // DeleteCustomer
            // 
            DeleteCustomer.Location = new Point(1091, 394);
            DeleteCustomer.Margin = new Padding(3, 4, 3, 4);
            DeleteCustomer.Name = "DeleteCustomer";
            DeleteCustomer.Size = new Size(169, 76);
            DeleteCustomer.TabIndex = 40;
            DeleteCustomer.Text = "מחיקת לקוח";
            DeleteCustomer.UseVisualStyleBackColor = true;
            DeleteCustomer.Click += DeleteCustomer_Click;
            // 
            // UpdateCustomer
            // 
            UpdateCustomer.Location = new Point(1091, 287);
            UpdateCustomer.Margin = new Padding(3, 4, 3, 4);
            UpdateCustomer.Name = "UpdateCustomer";
            UpdateCustomer.Size = new Size(159, 77);
            UpdateCustomer.TabIndex = 39;
            UpdateCustomer.Text = "עידכון לקוח";
            UpdateCustomer.UseVisualStyleBackColor = true;
            UpdateCustomer.Click += UpdateCustomer_Click;
            // 
            // AddCustomer
            // 
            AddCustomer.Location = new Point(1091, 169);
            AddCustomer.Margin = new Padding(3, 4, 3, 4);
            AddCustomer.Name = "AddCustomer";
            AddCustomer.Size = new Size(159, 83);
            AddCustomer.TabIndex = 38;
            AddCustomer.Text = "הוספת לקוח";
            AddCustomer.UseVisualStyleBackColor = true;
            AddCustomer.Click += AddCustomer_Click;
            // 
            // buttonShowCustomer
            // 
            buttonShowCustomer.Location = new Point(1091, 41);
            buttonShowCustomer.Margin = new Padding(3, 4, 3, 4);
            buttonShowCustomer.Name = "buttonShowCustomer";
            buttonShowCustomer.Size = new Size(159, 83);
            buttonShowCustomer.TabIndex = 46;
            buttonShowCustomer.Text = "הצגת לקוח";
            buttonShowCustomer.UseVisualStyleBackColor = true;
            buttonShowCustomer.Click += buttonShowCustomer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 201);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 51;
            label7.Text = "שם מלא";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(286, 197);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 57;
            label8.Text = "כתובת";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 616);
            Controls.Add(panelShowCustomer);
            Controls.Add(PanelAddCustomer);
            Controls.Add(panelCustomerUpdate);
            Controls.Add(buttonShowCustomer);
            Controls.Add(panelDeleteCustomer);
            Controls.Add(SaleShow);
            Controls.Add(ShowAllCustomers);
            Controls.Add(panelAllCustomers);
            Controls.Add(DeleteCustomer);
            Controls.Add(UpdateCustomer);
            Controls.Add(AddCustomer);
            Name = "Customers";
            Text = "Customers";
            panelCustomerUpdate.ResumeLayout(false);
            panelCustomerUpdate.PerformLayout();
            PanelAddCustomer.ResumeLayout(false);
            PanelAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputCustomerId).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPhoneCustomer).EndInit();
            panelShowCustomer.ResumeLayout(false);
            panelShowCustomer.PerformLayout();
            panelDeleteCustomer.ResumeLayout(false);
            panelDeleteCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeleteCustomer).EndInit();
            panelAllCustomers.ResumeLayout(false);
            panelAllCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCustomerUpdate;
        private Panel panelShowCustomer;
        private Label labelshowSale;
        private Label label19;
        private Button button_showCustomer;
        private Label label20;
        private Panel panelDeleteCustomer;
        private Button buttonDeleteCustomer;
        private Label label21;
        private NumericUpDown InputDeleteCustomer;
        private Button SaleShow;
        private Panel panelAllCustomers;
        private Label label12;
        private Button ButtonFilter;
        private DataGridView dataGridViewAllCustomers;
        private Panel PanelAddCustomer;
        private Button ButtonSaveCustomer;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ShowAllCustomers;
        private Button DeleteCustomer;
        private Button UpdateCustomer;
        private Button AddCustomer;
        private TextBox InputCustomerName;
        private TextBox InputAddres;
        private TextBox textBoxCustomerId;
        private Button buttonShowCustomer;
        private Label showCustomer;
        private TextBox CustomerName;
        private TextBox Address;
        private TextBox CustomerPhone;
        private TextBox CustomerId;
        private Button buttonUpdateCustomer;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown InputPhoneCustomer;
        private NumericUpDown InputCustomerId;
        private Label label8;
        private Label label7;
    }
}