using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            this.Hide();
            m.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            m.Show();
        }

        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();//הצגה מחדש של החלון הראשון
        }

        private void ShopCroupier_Click(object sender, EventArgs e)
        {
            ShopCroupier s =new ShopCroupier();
            this.Hide();
            s.FormClosed += Menu_FormClosed;
            s.Show();
        }
    }
}
