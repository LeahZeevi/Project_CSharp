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
            Customer = new Button();
            Manager = new Button();
            SuspendLayout();
            // 
            // Customer
            // 
            Customer.Location = new Point(285, 119);
            Customer.Name = "Customer";
            Customer.Size = new Size(75, 23);
            Customer.TabIndex = 0;
            Customer.Text = "לקוח";
            Customer.UseVisualStyleBackColor = true;
            Customer.Click += Customer_Click;
            // 
            // Manager
            // 
            Manager.Location = new Point(566, 119);
            Manager.Name = "Manager";
            Manager.Size = new Size(75, 23);
            Manager.TabIndex = 1;
            Manager.Text = "מנהל";
            Manager.UseVisualStyleBackColor = true;
            Manager.Click += Manager_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Manager);
            Controls.Add(Customer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Customer;
        private Button Manager;
    }
}
