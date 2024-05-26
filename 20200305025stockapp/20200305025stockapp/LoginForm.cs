using System;
using System.Windows.Forms;
using _20200305025stockapp;
using MySqlConnector;

namespace _20200305025stockapp
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305025";
        private string defaultUsername = "sinem";
        private string defaultPassword = "123";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;

            
            if (CheckDatabaseLogin(username, password))
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
            
            else if (username == defaultUsername && password == defaultPassword)
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private bool CheckDatabaseLogin(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                   
                    return true;
                }
                else
                {
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
