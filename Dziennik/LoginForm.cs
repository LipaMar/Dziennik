using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
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
            string password = passTextB.Text;
            string login = loginTextB.Text;
            HashAlgorithm algorithm = SHA256.Create();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in algorithm.ComputeHash(Encoding.UTF8.GetBytes(password)))
                sb.Append(b.ToString("X2"));
            password = sb.ToString().ToLower();
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
