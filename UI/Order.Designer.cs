namespace UI
{
    partial class Order
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
            AddProductToOrder = new Button();
            panelAllProducts = new Panel();
            label2 = new Label();
            inputCountToOrder = new NumericUpDown();
            AddProductFromDataGridView = new Button();
            dataGridViewAllProduct = new DataGridView();
            panelAddProductById = new Panel();
            InputProductId = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            InputAmountToOrder = new NumericUpDown();
            buttonAddProduct = new Button();
            panelOrderDetails = new Panel();
            labelTotalPrice = new Label();
            label3 = new Label();
            dataGridViewOrderdetails = new DataGridView();
            label1 = new Label();
            panelChooseAddProduct = new Panel();
            buttonEnterProductId = new Button();
            buttonShowAllProducts = new Button();
            buttonFinishOrder = new Button();
            panelAllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputCountToOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).BeginInit();
            panelAddProductById.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountToOrder).BeginInit();
            panelOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderdetails).BeginInit();
            panelChooseAddProduct.SuspendLayout();
            SuspendLayout();
            // 
            // AddProductToOrder
            // 
            AddProductToOrder.Location = new Point(706, 21);
            AddProductToOrder.Name = "AddProductToOrder";
            AddProductToOrder.Size = new Size(180, 79);
            AddProductToOrder.TabIndex = 0;
            AddProductToOrder.Text = "להוספת מוצר";
            AddProductToOrder.UseVisualStyleBackColor = true;
            AddProductToOrder.Click += AddProductToOrder_Click;
            // 
            // panelAllProducts
            // 
            panelAllProducts.Controls.Add(label2);
            panelAllProducts.Controls.Add(inputCountToOrder);
            panelAllProducts.Controls.Add(AddProductFromDataGridView);
            panelAllProducts.Controls.Add(dataGridViewAllProduct);
            panelAllProducts.Location = new Point(495, 148);
            panelAllProducts.Name = "panelAllProducts";
            panelAllProducts.Size = new Size(614, 561);
            panelAllProducts.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 524);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "כמות להזמנה:";
            // 
            // inputCountToOrder
            // 
            inputCountToOrder.Location = new Point(247, 522);
            inputCountToOrder.Margin = new Padding(3, 4, 3, 4);
            inputCountToOrder.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            inputCountToOrder.Name = "inputCountToOrder";
            inputCountToOrder.Size = new Size(137, 27);
            inputCountToOrder.TabIndex = 3;
            // 
            // AddProductFromDataGridView
            // 
            AddProductFromDataGridView.Location = new Point(76, 515);
            AddProductFromDataGridView.Name = "AddProductFromDataGridView";
            AddProductFromDataGridView.Size = new Size(130, 38);
            AddProductFromDataGridView.TabIndex = 2;
            AddProductFromDataGridView.Text = "הוספה";
            AddProductFromDataGridView.UseVisualStyleBackColor = true;
            AddProductFromDataGridView.Click += AddProductFromDataGridView_Click;
            // 
            // dataGridViewAllProduct
            // 
            dataGridViewAllProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllProduct.Location = new Point(99, 29);
            dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            dataGridViewAllProduct.RowHeadersWidth = 51;
            dataGridViewAllProduct.Size = new Size(519, 480);
            dataGridViewAllProduct.TabIndex = 0;
            // 
            // panelAddProductById
            // 
            panelAddProductById.Controls.Add(InputProductId);
            panelAddProductById.Controls.Add(label5);
            panelAddProductById.Controls.Add(label4);
            panelAddProductById.Controls.Add(InputAmountToOrder);
            panelAddProductById.Controls.Add(buttonAddProduct);
            panelAddProductById.Location = new Point(478, 231);
            panelAddProductById.Name = "panelAddProductById";
            panelAddProductById.Size = new Size(314, 275);
            panelAddProductById.TabIndex = 5;
            // 
            // InputProductId
            // 
            InputProductId.Location = new Point(21, 72);
            InputProductId.Margin = new Padding(3, 4, 3, 4);
            InputProductId.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            InputProductId.Name = "InputProductId";
            InputProductId.Size = new Size(137, 27);
            InputProductId.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 72);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 6;
            label5.Text = "קוד מוצר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 131);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 5;
            label4.Text = "כמות להזמנה:";
            // 
            // InputAmountToOrder
            // 
            InputAmountToOrder.Location = new Point(21, 129);
            InputAmountToOrder.Margin = new Padding(3, 4, 3, 4);
            InputAmountToOrder.Maximum = new decimal(new int[] { -1304428544, 434162106, 542, 0 });
            InputAmountToOrder.Name = "InputAmountToOrder";
            InputAmountToOrder.Size = new Size(137, 27);
            InputAmountToOrder.TabIndex = 4;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(73, 191);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(130, 38);
            buttonAddProduct.TabIndex = 3;
            buttonAddProduct.Text = "הוספה";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // panelOrderDetails
            // 
            panelOrderDetails.Controls.Add(buttonFinishOrder);
            panelOrderDetails.Controls.Add(labelTotalPrice);
            panelOrderDetails.Controls.Add(label3);
            panelOrderDetails.Controls.Add(dataGridViewOrderdetails);
            panelOrderDetails.Controls.Add(label1);
            panelOrderDetails.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelOrderDetails.Location = new Point(12, 12);
            panelOrderDetails.Name = "panelOrderDetails";
            panelOrderDetails.Size = new Size(460, 697);
            panelOrderDetails.TabIndex = 2;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(116, 560);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(0, 20);
            labelTotalPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 560);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "מחיר סופי";
            // 
            // dataGridViewOrderdetails
            // 
            dataGridViewOrderdetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderdetails.Location = new Point(15, 136);
            dataGridViewOrderdetails.Name = "dataGridViewOrderdetails";
            dataGridViewOrderdetails.RowHeadersWidth = 51;
            dataGridViewOrderdetails.Size = new Size(416, 378);
            dataGridViewOrderdetails.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 22);
            label1.Name = "label1";
            label1.Size = new Size(240, 54);
            label1.TabIndex = 0;
            label1.Text = "פרטי הזמנה";
            // 
            // panelChooseAddProduct
            // 
            panelChooseAddProduct.Controls.Add(buttonEnterProductId);
            panelChooseAddProduct.Controls.Add(buttonShowAllProducts);
            panelChooseAddProduct.Location = new Point(706, 138);
            panelChooseAddProduct.Name = "panelChooseAddProduct";
            panelChooseAddProduct.Size = new Size(403, 455);
            panelChooseAddProduct.TabIndex = 3;
            // 
            // buttonEnterProductId
            // 
            buttonEnterProductId.Location = new Point(72, 187);
            buttonEnterProductId.Name = "buttonEnterProductId";
            buttonEnterProductId.Size = new Size(226, 125);
            buttonEnterProductId.TabIndex = 1;
            buttonEnterProductId.Text = "להקשת קוד מוצר";
            buttonEnterProductId.UseVisualStyleBackColor = true;
            buttonEnterProductId.Click += buttonEnterProductId_Click;
            // 
            // buttonShowAllProducts
            // 
            buttonShowAllProducts.Location = new Point(59, 39);
            buttonShowAllProducts.Name = "buttonShowAllProducts";
            buttonShowAllProducts.Size = new Size(239, 117);
            buttonShowAllProducts.TabIndex = 0;
            buttonShowAllProducts.Text = "להצגת כל המוצרים";
            buttonShowAllProducts.UseVisualStyleBackColor = true;
            buttonShowAllProducts.Click += buttonShowAllProducts_Click;
            // 
            // buttonFinishOrder
            // 
            buttonFinishOrder.Location = new Point(148, 631);
            buttonFinishOrder.Name = "buttonFinishOrder";
            buttonFinishOrder.Size = new Size(137, 49);
            buttonFinishOrder.TabIndex = 4;
            buttonFinishOrder.Text = "לסיום הזמנה";
            buttonFinishOrder.UseVisualStyleBackColor = true;
            buttonFinishOrder.Click += buttonFinishOrder_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 721);
            Controls.Add(panelAddProductById);
            Controls.Add(panelChooseAddProduct);
            Controls.Add(panelAllProducts);
            Controls.Add(panelOrderDetails);
            Controls.Add(AddProductToOrder);
            Name = "Order";
            Text = "Order";
            panelAllProducts.ResumeLayout(false);
            panelAllProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inputCountToOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllProduct).EndInit();
            panelAddProductById.ResumeLayout(false);
            panelAddProductById.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputAmountToOrder).EndInit();
            panelOrderDetails.ResumeLayout(false);
            panelOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderdetails).EndInit();
            panelChooseAddProduct.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddProductToOrder;
        private Panel panelAllProducts;
        private Button AddProductFromDataGridView;
        private DataGridView dataGridViewAllProduct;
        private Panel panelOrderDetails;
        private Label label1;
        private Panel panelChooseAddProduct;
        private Button buttonEnterProductId;
        private Button buttonShowAllProducts;
        private Label label2;
        private NumericUpDown inputCountToOrder;
        private DataGridView dataGridViewOrderdetails;
        private Label labelTotalPrice;
        private Label label3;
        private Panel panelAddProductById;
        private Label label4;
        private NumericUpDown InputAmountToOrder;
        private Button buttonAddProduct;
        private NumericUpDown InputProductId;
        private Label label5;
        private Button buttonFinishOrder;
    }
}