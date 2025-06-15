namespace UI
{
    partial class Sales
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
            SaleShow = new Button();
            panelAllsales = new Panel();
            dateTimePicker = new DateTimePicker();
            label12 = new Label();
            ButtonFilter = new Button();
            dataGridViewAllsalses = new DataGridView();
            PanelAddSale = new Panel();
            inputTotalPrice = new NumericUpDown();
            checkBoxSale = new CheckBox();
            InputAmountForSale = new NumericUpDown();
            dateTimePickerEndSale = new DateTimePicker();
            dateTimePickerStartSale = new DateTimePicker();
            label18 = new Label();
            label17 = new Label();
            ButtonSaveSale = new Button();
            InputSaleId = new NumericUpDown();
            InputProductId = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panelShowSale = new Panel();
            labelshowSale = new Label();
            label19 = new Label();
            button_showSale = new Button();
            label20 = new Label();
            numericUpDownSaleId = new NumericUpDown();
            panelSaleUpdate = new Panel();
            saleUpdateAmountSale = new NumericUpDown();
            saleUpdateEndSale = new DateTimePicker();
            label16 = new Label();
            label14 = new Label();
            saleUpdateStartSale = new DateTimePicker();
            saleUpdateIsForAll = new CheckBox();
            UpdateSaleProdctId = new NumericUpDown();
            label15 = new Label();
            label8 = new Label();
            ButtonSaleUpdate = new Button();
            UpdateSaleId = new NumericUpDown();
            saleUpdateProductPrice = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            panelDeletSale = new Panel();
            buttonDeletSale = new Button();
            label21 = new Label();
            InputDeleteSaleID = new NumericUpDown();
            ShowAllSale = new Button();
            DeleteSale = new Button();
            UpdateSale = new Button();
            AddSale = new Button();
            panelAllsales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllsalses).BeginInit();
            PanelAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountForSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputSaleId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputProductId).BeginInit();
            panelShowSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).BeginInit();
            panelSaleUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saleUpdateAmountSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleProdctId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleUpdateProductPrice).BeginInit();
            panelDeletSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeleteSaleID).BeginInit();
            SuspendLayout();
            // 
            // SaleShow
            // 
            SaleShow.Location = new Point(711, 31);
            SaleShow.Margin = new Padding(3, 4, 3, 4);
            SaleShow.Name = "SaleShow";
            SaleShow.Size = new Size(159, 47);
            SaleShow.TabIndex = 17;
            SaleShow.Text = "הצגת מבצע";
            SaleShow.UseVisualStyleBackColor = true;
            SaleShow.Click += SaleShow_Click;
            // 
            // panelAllsales
            // 
            panelAllsales.Controls.Add(dateTimePicker);
            panelAllsales.Controls.Add(label12);
            panelAllsales.Controls.Add(ButtonFilter);
            panelAllsales.Controls.Add(dataGridViewAllsalses);
            panelAllsales.Location = new Point(85, 43);
            panelAllsales.Margin = new Padding(3, 4, 3, 4);
            panelAllsales.Name = "panelAllsales";
            panelAllsales.Size = new Size(586, 547);
            panelAllsales.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(76, 477);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(119, 437);
            label12.Name = "label12";
            label12.Size = new Size(260, 20);
            label12.TabIndex = 5;
            label12.Text = "הצגת כל המבצעים החל מתאריך מסוים";
            // 
            // ButtonFilter
            // 
            ButtonFilter.Location = new Point(348, 477);
            ButtonFilter.Margin = new Padding(3, 4, 3, 4);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(63, 44);
            ButtonFilter.TabIndex = 4;
            ButtonFilter.Text = "סינון";
            ButtonFilter.UseVisualStyleBackColor = true;
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // dataGridViewAllsalses
            // 
            dataGridViewAllsalses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllsalses.Location = new Point(20, 28);
            dataGridViewAllsalses.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllsalses.Name = "dataGridViewAllsalses";
            dataGridViewAllsalses.RowHeadersWidth = 51;
            dataGridViewAllsalses.Size = new Size(495, 343);
            dataGridViewAllsalses.TabIndex = 0;
            // 
            // PanelAddSale
            // 
            PanelAddSale.Controls.Add(inputTotalPrice);
            PanelAddSale.Controls.Add(checkBoxSale);
            PanelAddSale.Controls.Add(InputAmountForSale);
            PanelAddSale.Controls.Add(dateTimePickerEndSale);
            PanelAddSale.Controls.Add(dateTimePickerStartSale);
            PanelAddSale.Controls.Add(label18);
            PanelAddSale.Controls.Add(label17);
            PanelAddSale.Controls.Add(ButtonSaveSale);
            PanelAddSale.Controls.Add(InputSaleId);
            PanelAddSale.Controls.Add(InputProductId);
            PanelAddSale.Controls.Add(label5);
            PanelAddSale.Controls.Add(label4);
            PanelAddSale.Controls.Add(label3);
            PanelAddSale.Controls.Add(label2);
            PanelAddSale.Controls.Add(label1);
            PanelAddSale.Location = new Point(102, 39);
            PanelAddSale.Margin = new Padding(3, 4, 3, 4);
            PanelAddSale.Name = "PanelAddSale";
            PanelAddSale.Size = new Size(591, 528);
            PanelAddSale.TabIndex = 12;
            PanelAddSale.Paint += PanelAddSale_Paint;
            // 
            // inputTotalPrice
            // 
            inputTotalPrice.Location = new Point(262, 217);
            inputTotalPrice.Margin = new Padding(3, 4, 3, 4);
            inputTotalPrice.Name = "inputTotalPrice";
            inputTotalPrice.Size = new Size(137, 27);
            inputTotalPrice.TabIndex = 35;
            // 
            // checkBoxSale
            // 
            checkBoxSale.AutoSize = true;
            checkBoxSale.Location = new Point(257, 272);
            checkBoxSale.Margin = new Padding(3, 4, 3, 4);
            checkBoxSale.Name = "checkBoxSale";
            checkBoxSale.Size = new Size(18, 17);
            checkBoxSale.TabIndex = 33;
            checkBoxSale.UseVisualStyleBackColor = true;
            // 
            // InputAmountForSale
            // 
            InputAmountForSale.Location = new Point(257, 158);
            InputAmountForSale.Margin = new Padding(3, 4, 3, 4);
            InputAmountForSale.Name = "InputAmountForSale";
            InputAmountForSale.Size = new Size(137, 27);
            InputAmountForSale.TabIndex = 19;
            // 
            // dateTimePickerEndSale
            // 
            dateTimePickerEndSale.Location = new Point(257, 382);
            dateTimePickerEndSale.Name = "dateTimePickerEndSale";
            dateTimePickerEndSale.Size = new Size(250, 27);
            dateTimePickerEndSale.TabIndex = 18;
            // 
            // dateTimePickerStartSale
            // 
            dateTimePickerStartSale.Location = new Point(257, 323);
            dateTimePickerStartSale.Name = "dateTimePickerStartSale";
            dateTimePickerStartSale.Size = new Size(250, 27);
            dateTimePickerStartSale.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(84, 328);
            label18.Name = "label18";
            label18.Size = new Size(149, 20);
            label18.TabIndex = 16;
            label18.Text = "תאריך תחילת המבצע";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(84, 387);
            label17.Name = "label17";
            label17.Size = new Size(133, 20);
            label17.TabIndex = 15;
            label17.Text = "תאריך סיום המבצע";
            // 
            // ButtonSaveSale
            // 
            ButtonSaveSale.Location = new Point(257, 425);
            ButtonSaveSale.Name = "ButtonSaveSale";
            ButtonSaveSale.Size = new Size(167, 56);
            ButtonSaveSale.TabIndex = 36;
            ButtonSaveSale.Text = "הוספה";
            ButtonSaveSale.Click += ButtonSaveSale_Click;
            // 
            // InputSaleId
            // 
            InputSaleId.Location = new Point(262, 57);
            InputSaleId.Margin = new Padding(3, 4, 3, 4);
            InputSaleId.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            InputSaleId.Name = "InputSaleId";
            InputSaleId.Size = new Size(137, 27);
            InputSaleId.TabIndex = 13;
            // 
            // InputProductId
            // 
            InputProductId.Location = new Point(262, 107);
            InputProductId.Margin = new Padding(3, 4, 3, 4);
            InputProductId.Name = "InputProductId";
            InputProductId.Size = new Size(137, 27);
            InputProductId.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 269);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 10;
            label5.Text = "האם המצע מיועד לכולם?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 158);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 9;
            label4.Text = "כמות למבצע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 219);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 8;
            label3.Text = "מחיר לאחר מבצע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 101);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 7;
            label2.Text = "קוד מוצר";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 54);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "קוד מבצע";
            // 
            // panelShowSale
            // 
            panelShowSale.Controls.Add(labelshowSale);
            panelShowSale.Controls.Add(label19);
            panelShowSale.Controls.Add(button_showSale);
            panelShowSale.Controls.Add(label20);
            panelShowSale.Controls.Add(numericUpDownSaleId);
            panelShowSale.Location = new Point(32, 62);
            panelShowSale.Margin = new Padding(3, 4, 3, 4);
            panelShowSale.Name = "panelShowSale";
            panelShowSale.Size = new Size(345, 287);
            panelShowSale.TabIndex = 37;
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
            // button_showSale
            // 
            button_showSale.Location = new Point(49, 111);
            button_showSale.Margin = new Padding(3, 4, 3, 4);
            button_showSale.Name = "button_showSale";
            button_showSale.Size = new Size(72, 61);
            button_showSale.TabIndex = 7;
            button_showSale.Text = "הצג";
            button_showSale.UseVisualStyleBackColor = true;
            button_showSale.Click += button_showSale_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(69, 79);
            label20.Name = "label20";
            label20.Size = new Size(107, 20);
            label20.TabIndex = 6;
            label20.Text = "הקש קוד מבצע";
            // 
            // numericUpDownSaleId
            // 
            numericUpDownSaleId.Location = new Point(160, 129);
            numericUpDownSaleId.Margin = new Padding(3, 4, 3, 4);
            numericUpDownSaleId.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            numericUpDownSaleId.Name = "numericUpDownSaleId";
            numericUpDownSaleId.Size = new Size(137, 27);
            numericUpDownSaleId.TabIndex = 0;
            // 
            // panelSaleUpdate
            // 
            panelSaleUpdate.Controls.Add(saleUpdateAmountSale);
            panelSaleUpdate.Controls.Add(saleUpdateEndSale);
            panelSaleUpdate.Controls.Add(label16);
            panelSaleUpdate.Controls.Add(label14);
            panelSaleUpdate.Controls.Add(saleUpdateStartSale);
            panelSaleUpdate.Controls.Add(saleUpdateIsForAll);
            panelSaleUpdate.Controls.Add(UpdateSaleProdctId);
            panelSaleUpdate.Controls.Add(label15);
            panelSaleUpdate.Controls.Add(label8);
            panelSaleUpdate.Controls.Add(ButtonSaleUpdate);
            panelSaleUpdate.Controls.Add(UpdateSaleId);
            panelSaleUpdate.Controls.Add(saleUpdateProductPrice);
            panelSaleUpdate.Controls.Add(label6);
            panelSaleUpdate.Controls.Add(label7);
            panelSaleUpdate.Controls.Add(label9);
            panelSaleUpdate.Controls.Add(label10);
            panelSaleUpdate.Location = new Point(163, 31);
            panelSaleUpdate.Margin = new Padding(3, 4, 3, 4);
            panelSaleUpdate.Name = "panelSaleUpdate";
            panelSaleUpdate.Size = new Size(530, 555);
            panelSaleUpdate.TabIndex = 13;
            // 
            // saleUpdateAmountSale
            // 
            saleUpdateAmountSale.Location = new Point(319, 173);
            saleUpdateAmountSale.Margin = new Padding(3, 4, 3, 4);
            saleUpdateAmountSale.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            saleUpdateAmountSale.Name = "saleUpdateAmountSale";
            saleUpdateAmountSale.Size = new Size(137, 27);
            saleUpdateAmountSale.TabIndex = 37;
            // 
            // saleUpdateEndSale
            // 
            saleUpdateEndSale.Location = new Point(240, 421);
            saleUpdateEndSale.Margin = new Padding(3, 4, 3, 4);
            saleUpdateEndSale.Name = "saleUpdateEndSale";
            saleUpdateEndSale.Size = new Size(228, 27);
            saleUpdateEndSale.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(66, 428);
            label16.Name = "label16";
            label16.Size = new Size(133, 20);
            label16.TabIndex = 35;
            label16.Text = "תאריך סיום המבצע";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(66, 355);
            label14.Name = "label14";
            label14.Size = new Size(149, 20);
            label14.TabIndex = 34;
            label14.Text = "תאריך תחילת המבצע";
            // 
            // saleUpdateStartSale
            // 
            saleUpdateStartSale.Location = new Point(240, 353);
            saleUpdateStartSale.Margin = new Padding(3, 4, 3, 4);
            saleUpdateStartSale.Name = "saleUpdateStartSale";
            saleUpdateStartSale.Size = new Size(228, 27);
            saleUpdateStartSale.TabIndex = 33;
            // 
            // saleUpdateIsForAll
            // 
            saleUpdateIsForAll.AutoSize = true;
            saleUpdateIsForAll.Location = new Point(261, 304);
            saleUpdateIsForAll.Margin = new Padding(3, 4, 3, 4);
            saleUpdateIsForAll.Name = "saleUpdateIsForAll";
            saleUpdateIsForAll.Size = new Size(18, 17);
            saleUpdateIsForAll.TabIndex = 32;
            saleUpdateIsForAll.UseVisualStyleBackColor = true;
            // 
            // UpdateSaleProdctId
            // 
            UpdateSaleProdctId.Location = new Point(319, 113);
            UpdateSaleProdctId.Margin = new Padding(3, 4, 3, 4);
            UpdateSaleProdctId.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            UpdateSaleProdctId.Name = "UpdateSaleProdctId";
            UpdateSaleProdctId.Size = new Size(137, 27);
            UpdateSaleProdctId.TabIndex = 31;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(91, 120);
            label15.Name = "label15";
            label15.Size = new Size(65, 20);
            label15.TabIndex = 30;
            label15.Text = "קוד מוצר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(346, 411);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 27;
            // 
            // ButtonSaleUpdate
            // 
            ButtonSaleUpdate.Location = new Point(132, 466);
            ButtonSaleUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonSaleUpdate.Name = "ButtonSaleUpdate";
            ButtonSaleUpdate.Size = new Size(201, 61);
            ButtonSaleUpdate.TabIndex = 26;
            ButtonSaleUpdate.Text = "עדכון מבצע";
            ButtonSaleUpdate.UseVisualStyleBackColor = true;
            ButtonSaleUpdate.Click += ButtonSaleUpdate_Click;
            // 
            // UpdateSaleId
            // 
            UpdateSaleId.Location = new Point(319, 52);
            UpdateSaleId.Margin = new Padding(3, 4, 3, 4);
            UpdateSaleId.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            UpdateSaleId.Name = "UpdateSaleId";
            UpdateSaleId.Size = new Size(137, 27);
            UpdateSaleId.TabIndex = 24;
            // 
            // saleUpdateProductPrice
            // 
            saleUpdateProductPrice.Location = new Point(319, 239);
            saleUpdateProductPrice.Margin = new Padding(3, 4, 3, 4);
            saleUpdateProductPrice.Name = "saleUpdateProductPrice";
            saleUpdateProductPrice.Size = new Size(137, 27);
            saleUpdateProductPrice.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 304);
            label6.Name = "label6";
            label6.Size = new Size(177, 20);
            label6.TabIndex = 21;
            label6.Text = "האם המבצע מיועד לכולם?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 246);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 20;
            label7.Text = "מחיר לאחר מבצע";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 180);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 18;
            label9.Text = "כמות למבצע";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 52);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 17;
            label10.Text = "קוד מבצע";
            // 
            // panelDeletSale
            // 
            panelDeletSale.Controls.Add(buttonDeletSale);
            panelDeletSale.Controls.Add(label21);
            panelDeletSale.Controls.Add(InputDeleteSaleID);
            panelDeletSale.Location = new Point(67, 53);
            panelDeletSale.Margin = new Padding(3, 4, 3, 4);
            panelDeletSale.Name = "panelDeletSale";
            panelDeletSale.Size = new Size(315, 230);
            panelDeletSale.TabIndex = 37;
            // 
            // buttonDeletSale
            // 
            buttonDeletSale.Location = new Point(16, 121);
            buttonDeletSale.Margin = new Padding(3, 4, 3, 4);
            buttonDeletSale.Name = "buttonDeletSale";
            buttonDeletSale.Size = new Size(169, 60);
            buttonDeletSale.TabIndex = 27;
            buttonDeletSale.Text = "מחיקה";
            buttonDeletSale.UseVisualStyleBackColor = true;
            buttonDeletSale.Click += buttonDeletSale_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(49, 40);
            label21.Name = "label21";
            label21.Size = new Size(101, 20);
            label21.TabIndex = 26;
            label21.Text = "הקש קוד מוצר";
            // 
            // InputDeleteSaleID
            // 
            InputDeleteSaleID.Location = new Point(32, 76);
            InputDeleteSaleID.Margin = new Padding(3, 4, 3, 4);
            InputDeleteSaleID.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            InputDeleteSaleID.Name = "InputDeleteSaleID";
            InputDeleteSaleID.Size = new Size(137, 27);
            InputDeleteSaleID.TabIndex = 25;
            // 
            // ShowAllSale
            // 
            ShowAllSale.Location = new Point(711, 492);
            ShowAllSale.Margin = new Padding(3, 4, 3, 4);
            ShowAllSale.Name = "ShowAllSale";
            ShowAllSale.Size = new Size(159, 47);
            ShowAllSale.TabIndex = 11;
            ShowAllSale.Text = "הצגת כל המבצעים";
            ShowAllSale.UseVisualStyleBackColor = true;
            ShowAllSale.Click += ShowAllSale_Click;
            // 
            // DeleteSale
            // 
            DeleteSale.Location = new Point(711, 387);
            DeleteSale.Margin = new Padding(3, 4, 3, 4);
            DeleteSale.Name = "DeleteSale";
            DeleteSale.Size = new Size(159, 53);
            DeleteSale.TabIndex = 10;
            DeleteSale.Text = "מחיקת מבצע";
            DeleteSale.UseVisualStyleBackColor = true;
            DeleteSale.Click += DeleteSale_Click;
            // 
            // UpdateSale
            // 
            UpdateSale.Location = new Point(711, 275);
            UpdateSale.Margin = new Padding(3, 4, 3, 4);
            UpdateSale.Name = "UpdateSale";
            UpdateSale.Size = new Size(159, 47);
            UpdateSale.TabIndex = 9;
            UpdateSale.Text = "עידכון מבצע";
            UpdateSale.UseVisualStyleBackColor = true;
            UpdateSale.Click += UpdateSale_Click;
            // 
            // AddSale
            // 
            AddSale.Location = new Point(711, 149);
            AddSale.Margin = new Padding(3, 4, 3, 4);
            AddSale.Name = "AddSale";
            AddSale.Size = new Size(159, 49);
            AddSale.TabIndex = 8;
            AddSale.Text = "הוספת מבצע";
            AddSale.UseVisualStyleBackColor = true;
            AddSale.Click += AddSale_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 600);
            Controls.Add(panelSaleUpdate);
            Controls.Add(panelShowSale);
            Controls.Add(panelDeletSale);
            Controls.Add(SaleShow);
            Controls.Add(panelAllsales);
            Controls.Add(PanelAddSale);
            Controls.Add(ShowAllSale);
            Controls.Add(DeleteSale);
            Controls.Add(UpdateSale);
            Controls.Add(AddSale);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Sales";
            Text = "Sales";
            panelAllsales.ResumeLayout(false);
            panelAllsales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllsalses).EndInit();
            PanelAddSale.ResumeLayout(false);
            PanelAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountForSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputSaleId).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputProductId).EndInit();
            panelShowSale.ResumeLayout(false);
            panelShowSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).EndInit();
            panelSaleUpdate.ResumeLayout(false);
            panelSaleUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saleUpdateAmountSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleProdctId).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleId).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleUpdateProductPrice).EndInit();
            panelDeletSale.ResumeLayout(false);
            panelDeletSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeleteSaleID).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button SaleShow;
        private Panel panelAllsales;
        private Label label12;
        private Button ButtonFilter;
        private DataGridView dataGridViewAllsalses;
        private Panel PanelAddSale;
        private Button ButtonSaveSale;
        private NumericUpDown InputSaleId;
        private NumericUpDown InputProductId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelSaleUpdate;
        private Button ButtonSaleUpdate;
        private NumericUpDown UpdateSaleId;
        private NumericUpDown saleUpdateProductPrice;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Button ShowAllSale;
        private Button DeleteSale;
        private Button UpdateSale;
        private Button AddSale;
        private NumericUpDown UpdateSaleProdctId;
        private Label label15;
        private Label label8;
        private DateTimePicker saleUpdateStartSale;
        private CheckBox saleUpdateIsForAll;
        private DateTimePicker saleUpdateEndSale;
        private Label label16;
        private Label label14;
        private NumericUpDown saleUpdateAmountSale;
        private DateTimePicker dateTimePicker;
        private Label label18;
        private Label label17;
        private CheckBox checkBoxSale;
        private NumericUpDown InputAmountForSale;
        private DateTimePicker dateTimePickerEndSale;
        private DateTimePicker dateTimePickerStartSale;
        private TextBox textBoxTotalPrice;
        private NumericUpDown inputTotalPrice;
        private Panel panelShowSale;
        private Label label19;
        private Button button_showSale;
        private Label label20;
        private NumericUpDown numericUpDownSaleId;
        private Label labelshowSale;
        private Panel panelDeletSale;
        private Button buttonDeletSale;
        private Label label21;
        private NumericUpDown InputDeleteSaleID;
    }
}