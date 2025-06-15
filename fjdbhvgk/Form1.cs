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
            Manager menu = new Manager();
            this.Hide();//הסתרת המסך הנוכחי
            //menu.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            menu.Show();
        }

        private void Customer_Click(object sender, EventArgs e)
        {

        }
    }
}
