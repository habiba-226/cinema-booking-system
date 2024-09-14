using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;

namespace MovieLibrarySystemTrial1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            var signUp = new Signup();
            this.Hide();
            signUp.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Fill the blank spaces");
                return;
            }
            try
            {
                var connection = new SqlConnection("Data Source=DESKTOP-L2HD4CA;Initial Catalog=loginapp;Integrated Security=True;Trust Server Certificate=True");
                connection.Open();
                var sql = new SqlCommand($"SELECT COUNT(*) FROM loginapp WHERE Username = '{Username.Text}' AND Password = '{Password.Text}'", connection);
                int userCount = Convert.ToInt32(sql.ExecuteScalar());
                if (userCount == 0)
                {
                    MessageBox.Show("Login Failed!");
                }
                else
                {
                    this.Hide();
                    var homepage = new HomePage();
                    homepage.Show();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
            }
        }

    }
}
