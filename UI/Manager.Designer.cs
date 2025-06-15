namespace UI
{
    partial class Manager
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
            product = new Button();
            sale = new Button();
            customer = new Button();
            SuspendLayout();
            // 
            // product
            // 
            product.Location = new Point(351, 51);
            product.Name = "product";
            product.Size = new Size(123, 62);
            product.TabIndex = 0;
            product.Text = "מוצרים";
            product.UseVisualStyleBackColor = true;
            product.Click += product_Click;
            // 
            // sale
            // 
            sale.Location = new Point(351, 236);
            sale.Name = "sale";
            sale.Size = new Size(123, 65);
            sale.TabIndex = 1;
            sale.Text = "מבצעים";
            sale.UseVisualStyleBackColor = true;
            sale.Click += sale_Click;
            // 
            // customer
            // 
            customer.Location = new Point(351, 143);
            customer.Name = "customer";
            customer.Size = new Size(123, 65);
            customer.TabIndex = 2;
            customer.Text = "לקוחות";
            customer.UseVisualStyleBackColor = true;
            customer.Click += customer_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customer);
            Controls.Add(sale);
            Controls.Add(product);
            Name = "Manager";
            Text = "Manager";
            ResumeLayout(false);
        }

        #endregion

        private Button product;
        private Button sale;
        private Button customer;
    }
}