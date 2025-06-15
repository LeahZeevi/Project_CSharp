namespace UI
{
    partial class ShopCroupier
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
            buttonStartOrder = new Button();
            SuspendLayout();
            // 
            // buttonStartOrder
            // 
            buttonStartOrder.Location = new Point(223, 131);
            buttonStartOrder.Name = "buttonStartOrder";
            buttonStartOrder.Size = new Size(262, 96);
            buttonStartOrder.TabIndex = 0;
            buttonStartOrder.Text = "להתחלת הזמנה";
            buttonStartOrder.UseVisualStyleBackColor = true;
            buttonStartOrder.Click += buttonStartOrder_Click;
            // 
            // ShopCroupier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStartOrder);
            Name = "ShopCroupier";
            Text = "ShopCroupier";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartOrder;
    }
}