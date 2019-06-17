using System;
using System.Drawing;
using System.Windows.Forms;
namespace Dziennik
{
    /// <summary>
    /// Represents login form. Allows user to log in to the system.
    /// </summary>
    public partial class LoginForm : Form
    {
        Database db;
        public LoginForm()
        {
            InitializeComponent();
            db = new Database();
        }
        /// <summary>
        /// Encodes the given password and checks if the login and the password are correct
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string password = User.HashString(passTextB.Text);
            string login = loginTextB.Text;
            if (db.Login(login, password))
            {
                db.Close();
                this.DialogResult = DialogResult.OK;
                this.Tag = login;
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło! Spróbuj ponownie!");
            }
        }

        private void loginTextB_Enter(object sender, EventArgs e)
        {
            if (loginTextB.Text == "Nazwa użytkownika")
            {
                loginTextB.Text = "";
            }
        }

        private void loginTextB_Leave(object sender, EventArgs e)
        {
            if (loginTextB.Text == "")
            {
                loginTextB.Text = "Nazwa użytkownika";
                loginTextB.ForeColor = Color.Black;
            }
        }

        private void passTextB_Enter(object sender, EventArgs e)
        {
            if (passTextB.Text == "Hasło")
            {
                passTextB.Text = "";
            }
        }

        private void passTextB_Leave(object sender, EventArgs e)
        {
            if (passTextB.Text == "")
            {
                passTextB.Text = "Hasło";
                passTextB.ForeColor = Color.Black;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            loginTextB.Text = "Nazwa użytkownika";
            passTextB.Text = "Hasło";
        }
    }
}
