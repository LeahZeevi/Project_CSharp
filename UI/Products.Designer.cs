namespace UI
{
    partial class Products
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
            AddProduct = new Button();
            UpdateProduct = new Button();
            DeleteProduct = new Button();
            ShowAllProduct = new Button();
            PanelProduct = new Panel();
            SelectCategory = new ComboBox();
            ButtonSavaeProduct = new Button();
            InputProductId = new NumericUpDown();
            InputAmountInStock = new NumericUpDown();
            InputPrice = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            InputProductName = new TextBox();
            panelAllProduct = new Panel();
            label12 = new Label();
            ButtonFilter = new Button();
            comboBoxFilter = new ComboBox();
            dataGridViewAllProduct = new DataGridView();
            panelShowProduct = new Panel();
            labelShowProduct = new Label();
            button_SaveShowProduct = new Button();
            label13 = new Label();
            ShowProductId = new NumericUpDown();
            panelDeleteProduct = new Panel();
            Button_SaveDelet = new Button();
            label11 = new Label();
            InputDeletProduct = new NumericUpDown();
            panelUpdate = new Panel();
            ButtonProductUpdate = new Button();
            UpdateSelectProduct = new ComboBox();
            updateProductId = new NumericUpDown();
            UpdateProductAmount = new NumericUpDown();
            UpdateProductPrice = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            UpdateProductName = new TextBox();
            ProductShow = new Button();
            PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPrice).BeginInit();
            panelAllProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            panelShowProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowProductId).BeginInit();
            panelDeleteProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeletProduct).BeginInit();
            panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductPrice).BeginInit();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(680, 164);
            AddProduct.Margin = new Padding(3, 4, 3, 4);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(159, 49);
            AddProduct.TabIndex = 0;
            AddProduct.Text = "הוספת מוצר";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // UpdateProduct
            // 
            UpdateProduct.Location = new Point(680, 289);
            UpdateProduct.Margin = new Padding(3, 4, 3, 4);
            UpdateProduct.Name = "UpdateProduct";
            UpdateProduct.Size = new Size(159, 47);
            UpdateProduct.TabIndex = 1;
            UpdateProduct.Text = "עידכון מוצר";
            UpdateProduct.UseVisualStyleBackColor = true;
            UpdateProduct.Click += UpdateProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(680, 401);
            DeleteProduct.Margin = new Padding(3, 4, 3, 4);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(159, 53);
            DeleteProduct.TabIndex = 2;
            DeleteProduct.Text = "מחיקת מוצר";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // ShowAllProduct
            // 
            ShowAllProduct.Location = new Point(680, 507);
            ShowAllProduct.Margin = new Padding(3, 4, 3, 4);
            ShowAllProduct.Name = "ShowAllProduct";
            ShowAllProduct.Size = new Size(159, 47);
            ShowAllProduct.TabIndex = 3;
            ShowAllProduct.Text = "הצגת כל המוצרים";
            ShowAllProduct.UseVisualStyleBackColor = true;
            ShowAllProduct.Click += ShowAllProduct_Click;
            // 
            // PanelProduct
            // 
            PanelProduct.Controls.Add(SelectCategory);
            PanelProduct.Controls.Add(ButtonSavaeProduct);
            PanelProduct.Controls.Add(InputProductId);
            PanelProduct.Controls.Add(InputAmountInStock);
            PanelProduct.Controls.Add(InputPrice);
            PanelProduct.Controls.Add(label5);
            PanelProduct.Controls.Add(label4);
            PanelProduct.Controls.Add(label3);
            PanelProduct.Controls.Add(label2);
            PanelProduct.Controls.Add(label1);
            PanelProduct.Controls.Add(InputProductName);
            PanelProduct.Location = new Point(26, 24);
            PanelProduct.Margin = new Padding(3, 4, 3, 4);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(582, 547);
            PanelProduct.TabIndex = 4;
            // 
            // SelectCategory
            // 
            SelectCategory.FormattingEnabled = true;
            SelectCategory.Items.AddRange(new object[] { " MainCourse", " Salads", " Extras", " Desserts", " Driks" });
            SelectCategory.Location = new Point(147, 196);
            SelectCategory.Margin = new Padding(3, 4, 3, 4);
            SelectCategory.Name = "SelectCategory";
            SelectCategory.Size = new Size(138, 28);
            SelectCategory.TabIndex = 7;
            // 
            // ButtonSavaeProduct
            // 
            ButtonSavaeProduct.Location = new Point(141, 391);
            ButtonSavaeProduct.Margin = new Padding(3, 4, 3, 4);
            ButtonSavaeProduct.Name = "ButtonSavaeProduct";
            ButtonSavaeProduct.Size = new Size(144, 40);
            ButtonSavaeProduct.TabIndex = 14;
            ButtonSavaeProduct.Text = "הוספה";
            ButtonSavaeProduct.UseVisualStyleBackColor = true;
            ButtonSavaeProduct.Click += ButtonSaveProduct_Click;
            // 
            // InputProductId
            // 
            InputProductId.Location = new Point(147, 68);
            InputProductId.Margin = new Padding(3, 4, 3, 4);
            InputProductId.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            InputProductId.Name = "InputProductId";
            InputProductId.Size = new Size(137, 27);
            InputProductId.TabIndex = 13;
            // 
            // InputAmountInStock
            // 
            InputAmountInStock.Location = new Point(147, 316);
            InputAmountInStock.Margin = new Padding(3, 4, 3, 4);
            InputAmountInStock.Name = "InputAmountInStock";
            InputAmountInStock.Size = new Size(137, 27);
            InputAmountInStock.TabIndex = 12;
            // 
            // InputPrice
            // 
            InputPrice.Location = new Point(147, 261);
            InputPrice.Margin = new Padding(3, 4, 3, 4);
            InputPrice.Name = "InputPrice";
            InputPrice.Size = new Size(137, 27);
            InputPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 320);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 10;
            label5.Text = "AmountInStock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 264);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 200);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 8;
            label3.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 141);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 7;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 77);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 6;
            label1.Text = "Product Id";
            // 
            // InputProductName
            // 
            InputProductName.Location = new Point(147, 131);
            InputProductName.Margin = new Padding(3, 4, 3, 4);
            InputProductName.Name = "InputProductName";
            InputProductName.Size = new Size(137, 27);
            InputProductName.TabIndex = 1;
            // 
            // panelAllProduct
            // 
            panelAllProduct.Controls.Add(label12);
            panelAllProduct.Controls.Add(ButtonFilter);
            panelAllProduct.Controls.Add(comboBoxFilter);
            panelAllProduct.Controls.Add(dataGridViewAllProduct);
            panelAllProduct.Location = new Point(19, 28);
            panelAllProduct.Margin = new Padding(3, 4, 3, 4);
            panelAllProduct.Name = "panelAllProduct";
            panelAllProduct.Size = new Size(585, 551);
            panelAllProduct.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 489);
            label12.Name = "label12";
            label12.Size = new Size(102, 20);
            label12.TabIndex = 5;
            label12.Text = "קטגוריה לסינון";
            // 
            // ButtonFilter
            // 
            ButtonFilter.Location = new Point(262, 479);
            ButtonFilter.Margin = new Padding(3, 4, 3, 4);
            ButtonFilter.Name = "ButtonFilter";
            ButtonFilter.Size = new Size(67, 40);
            ButtonFilter.TabIndex = 4;
            ButtonFilter.Text = "סינון";
            ButtonFilter.UseVisualStyleBackColor = true;
            ButtonFilter.Click += ButtonFilter_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "  MainCourse", "  Salads ", "  Extras", "  Desserts", "  Driks" });
            comboBoxFilter.Location = new Point(106, 485);
            comboBoxFilter.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(138, 28);
            comboBoxFilter.TabIndex = 1;
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Location = new Point(7, 44);
            dataGridViewAllProduct.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.Size = new Size(472, 349);
            dataGridViewAllProduct.TabIndex = 0;
            // 
            // panelShowProduct
            // 
            panelShowProduct.Controls.Add(labelShowProduct);
            panelShowProduct.Controls.Add(button_SaveShowProduct);
            panelShowProduct.Controls.Add(label13);
            panelShowProduct.Controls.Add(ShowProductId);
            panelShowProduct.Location = new Point(12, 92);
            panelShowProduct.Margin = new Padding(3, 4, 3, 4);
            panelShowProduct.Name = "panelShowProduct";
            panelShowProduct.Size = new Size(345, 355);
            panelShowProduct.TabIndex = 6;
            // 
            // labelShowProduct
            // 
            labelShowProduct.AutoSize = true;
            labelShowProduct.Location = new Point(79, 227);
            labelShowProduct.Name = "labelShowProduct";
            labelShowProduct.Size = new Size(0, 20);
            labelShowProduct.TabIndex = 8;
            // 
            // button_SaveShowProduct
            // 
            button_SaveShowProduct.Location = new Point(49, 111);
            button_SaveShowProduct.Margin = new Padding(3, 4, 3, 4);
            button_SaveShowProduct.Name = "button_SaveShowProduct";
            button_SaveShowProduct.Size = new Size(72, 61);
            button_SaveShowProduct.TabIndex = 7;
            button_SaveShowProduct.Text = "הצג";
            button_SaveShowProduct.UseVisualStyleBackColor = true;
            button_SaveShowProduct.Click += button_SaveShowProduct_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(69, 79);
            label13.Name = "label13";
            label13.Size = new Size(101, 20);
            label13.TabIndex = 6;
            label13.Text = "הקש קוד מוצר";
            // 
            // ShowProductId
            // 
            ShowProductId.Location = new Point(160, 129);
            ShowProductId.Margin = new Padding(3, 4, 3, 4);
            ShowProductId.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            ShowProductId.Name = "ShowProductId";
            ShowProductId.Size = new Size(137, 27);
            ShowProductId.TabIndex = 0;
            // 
            // panelDeleteProduct
            // 
            panelDeleteProduct.Controls.Add(Button_SaveDelet);
            panelDeleteProduct.Controls.Add(label11);
            panelDeleteProduct.Controls.Add(InputDeletProduct);
            panelDeleteProduct.Location = new Point(14, 32);
            panelDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            panelDeleteProduct.Name = "panelDeleteProduct";
            panelDeleteProduct.Size = new Size(611, 583);
            panelDeleteProduct.TabIndex = 6;
            // 
            // Button_SaveDelet
            // 
            Button_SaveDelet.Location = new Point(16, 121);
            Button_SaveDelet.Margin = new Padding(3, 4, 3, 4);
            Button_SaveDelet.Name = "Button_SaveDelet";
            Button_SaveDelet.Size = new Size(169, 60);
            Button_SaveDelet.TabIndex = 27;
            Button_SaveDelet.Text = "מחיקה";
            Button_SaveDelet.UseVisualStyleBackColor = true;
            Button_SaveDelet.Click += Button_SaveDelet_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(49, 40);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 26;
            label11.Text = "הקש קוד מוצר";
            // 
            // InputDeletProduct
            // 
            InputDeletProduct.Location = new Point(32, 76);
            InputDeletProduct.Margin = new Padding(3, 4, 3, 4);
            InputDeletProduct.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
            InputDeletProduct.Name = "InputDeletProduct";
            InputDeletProduct.Size = new Size(137, 27);
            InputDeletProduct.TabIndex = 25;
            // 
            // panelUpdate
            // 
            panelUpdate.Controls.Add(ButtonProductUpdate);
            panelUpdate.Controls.Add(UpdateSelectProduct);
            panelUpdate.Controls.Add(updateProductId);
            panelUpdate.Controls.Add(UpdateProductAmount);
            panelUpdate.Controls.Add(UpdateProductPrice);
            panelUpdate.Controls.Add(label6);
            panelUpdate.Controls.Add(label7);
            panelUpdate.Controls.Add(label8);
            panelUpdate.Controls.Add(label9);
            panelUpdate.Controls.Add(label10);
            panelUpdate.Controls.Add(UpdateProductName);
            panelUpdate.Location = new Point(37, 16);
            panelUpdate.Margin = new Padding(3, 4, 3, 4);
            panelUpdate.Name = "panelUpdate";
            panelUpdate.Size = new Size(589, 555);
            panelUpdate.TabIndex = 5;
            // 
            // ButtonProductUpdate
            // 
            ButtonProductUpdate.Location = new Point(138, 361);
            ButtonProductUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonProductUpdate.Name = "ButtonProductUpdate";
            ButtonProductUpdate.Size = new Size(201, 61);
            ButtonProductUpdate.TabIndex = 26;
            ButtonProductUpdate.Text = "עדכן מוצר";
            ButtonProductUpdate.UseVisualStyleBackColor = true;
            ButtonProductUpdate.Click += ButtenUpdate_Click;
            // 
            // UpdateSelectProduct
            // 
            UpdateSelectProduct.FormattingEnabled = true;
            UpdateSelectProduct.Items.AddRange(new object[] { "MainCourse", "Salads ", "Extras", "Desserts", "Driks" });
            UpdateSelectProduct.Location = new Point(226, 209);
            UpdateSelectProduct.Margin = new Padding(3, 4, 3, 4);
            UpdateSelectProduct.Name = "UpdateSelectProduct";
            UpdateSelectProduct.Size = new Size(138, 28);
            UpdateSelectProduct.TabIndex = 25;
            // 
            // updateProductId
            // 
            updateProductId.Location = new Point(216, 77);
            updateProductId.Margin = new Padding(3, 4, 3, 4);
            updateProductId.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            updateProductId.Name = "updateProductId";
            updateProductId.Size = new Size(137, 27);
            updateProductId.TabIndex = 24;
            // 
            // UpdateProductAmount
            // 
            UpdateProductAmount.Location = new Point(216, 325);
            UpdateProductAmount.Margin = new Padding(3, 4, 3, 4);
            UpdateProductAmount.Name = "UpdateProductAmount";
            UpdateProductAmount.Size = new Size(137, 27);
            UpdateProductAmount.TabIndex = 23;
            // 
            // UpdateProductPrice
            // 
            UpdateProductPrice.Location = new Point(216, 271);
            UpdateProductPrice.Margin = new Padding(3, 4, 3, 4);
            UpdateProductPrice.Name = "UpdateProductPrice";
            UpdateProductPrice.Size = new Size(137, 27);
            UpdateProductPrice.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 329);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 21;
            label6.Text = "AmountInStock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 273);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 20;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 209);
            label8.Name = "label8";
            label8.Size = new Size(113, 20);
            label8.TabIndex = 19;
            label8.Text = "Category Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 151);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 18;
            label9.Text = "Product Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(91, 77);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 17;
            label10.Text = "Product Id";
            // 
            // UpdateProductName
            // 
            UpdateProductName.Location = new Point(216, 140);
            UpdateProductName.Margin = new Padding(3, 4, 3, 4);
            UpdateProductName.Name = "UpdateProductName";
            UpdateProductName.Size = new Size(137, 27);
            UpdateProductName.TabIndex = 16;
            // 
            // ProductShow
            // 
            ProductShow.Location = new Point(680, 45);
            ProductShow.Margin = new Padding(3, 4, 3, 4);
            ProductShow.Name = "ProductShow";
            ProductShow.Size = new Size(159, 47);
            ProductShow.TabIndex = 7;
            ProductShow.Text = "הצגת מוצר";
            ProductShow.UseVisualStyleBackColor = true;
            ProductShow.Click += ProductShow_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelShowProduct);
            Controls.Add(ProductShow);
            Controls.Add(panelAllProduct);
            Controls.Add(panelDeleteProduct);
            Controls.Add(PanelProduct);
            Controls.Add(panelUpdate);
            Controls.Add(ShowAllProduct);
            Controls.Add(DeleteProduct);
            Controls.Add(UpdateProduct);
            Controls.Add(AddProduct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Products";
            Text = "Products";
            PanelProduct.ResumeLayout(false);
            PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPrice).EndInit();
            panelAllProduct.ResumeLayout(false);
            panelAllProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            panelShowProduct.ResumeLayout(false);
            panelShowProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowProductId).EndInit();
            panelDeleteProduct.ResumeLayout(false);
            panelDeleteProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputDeletProduct).EndInit();
            panelUpdate.ResumeLayout(false);
            panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddProduct;
        private Button UpdateProduct;
        private Button DeleteProduct;
        private Button ShowAllProduct;
        private Panel PanelProduct;
        private TextBox InputProductName;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown InputAmountInStock;
        private NumericUpDown InputPrice;
        private NumericUpDown InputProductId;
        private Button ButtonSavaeProduct;
        private TextBox UpdateProductName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private NumericUpDown UpdateProductPrice;
        private NumericUpDown UpdateProductAmount;
        private NumericUpDown updateProductId;
        private ComboBox UpdateSelectProduct;
        private Button ButtonProductUpdate;
        private Panel panelDeleteProduct;
        private Button Button_SaveDelet;
        private Label label11;
        private NumericUpDown InputDeletProduct;
        private Panel panelUpdate;
        private Panel panelAllProduct;
        private DataGridView dataGridViewAllProduct;
        private ComboBox comboBoxFilter;
        private Button ButtonFilter;
        private Label label12;
        private ComboBox SelectCategory;
        private Button ProductShow;
        private Panel panelShowProduct;
        private Button button_SaveShowProduct;
        private Label label13;
        private NumericUpDown ShowProductId;
        private Label labelShowProduct;
    }
}