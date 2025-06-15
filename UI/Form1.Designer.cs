namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Manager = new Button();
            ShopCroupier = new Button();
            SuspendLayout();
            // 
            // Manager
            // 
            Manager.Location = new Point(448, 114);
            Manager.Name = "Manager";
            Manager.Size = new Size(133, 106);
            Manager.TabIndex = 0;
            Manager.Text = "מנהל";
            Manager.UseVisualStyleBackColor = true;
            Manager.Click += Manager_Click;
            // 
            // ShopCroupier
            // 
            ShopCroupier.Location = new Point(200, 114);
            ShopCroupier.Name = "ShopCroupier";
            ShopCroupier.Size = new Size(134, 106);
            ShopCroupier.TabIndex = 1;
            ShopCroupier.Text = "קופאי";
            ShopCroupier.UseVisualStyleBackColor = true;
            ShopCroupier.Click += ShopCroupier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ShopCroupier);
            Controls.Add(Manager);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Manager;
        private Button ShopCroupier;
    }
}
