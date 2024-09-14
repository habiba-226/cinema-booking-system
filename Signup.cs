using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;


namespace MovieLibrarySystemTrial1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) && string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Fill the blank spaces");
                return;
            }

            if (Password.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            try
            {
                var connection = new SqlConnection("Data Source=DESKTOP-L2HD4CA;Initial Catalog=loginapp;Integrated Security=True;Trust Server Certificate=True");
                connection.Open();
                var sql = new SqlCommand($"INSERT INTO loginapp (Username,Password) VALUES('{Username.Text}','{Password.Text}')", connection);
                if (sql.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("SignUp Failed!");
                    connection.Close();
                    return;
                }
                MessageBox.Show("SignUp Successful");
                connection.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: {ex.Message}");
                return;
            }
        }

        private void Backtologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }
    }
}
