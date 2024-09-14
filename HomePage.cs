namespace MovieLibrarySystemTrial1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moviePanel3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bookingmovie = new BookingMovie();
            bookingmovie.Show();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var backtoLogin = new Login();
            backtoLogin.Show();
        }
    }
}