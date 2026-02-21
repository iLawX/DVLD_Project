using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using System.IO;
using DVLD.General;

namespace DVLD.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void ClearLoginInfoFile()
        {
            File.WriteAllText("logininfo.txt", string.Empty);
        }
        private void SaveLoginInfoToFile()
        {
            File.WriteAllText("logininfo.txt", $"{Username.Text}\n{Password.Text}");
        }
        private void Login_Click(object sender, EventArgs e)
        {
            User user = User.FindByUsernameAndPassword(Username.Text, Password.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!user.IsActive)
            {
                MessageBox.Show("Your account is inactive. Please contact the administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (RememberMe.Checked)
            {
                SaveLoginInfoToFile();
            }
            else
            {
                ClearLoginInfoFile();
            }

            Global.CurrentUser = user;

            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }
        private void LoadLoginInfoFromFile()
        {
            if (File.Exists("logininfo.txt"))
            {
                string[] lines = File.ReadAllLines("logininfo.txt");
                if (lines.Length == 2)
                {
                    Username.Text = lines[0];
                    Password.Text = lines[1];
                    RememberMe.Checked = true;
                }
            }
        }
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LoadLoginInfoFromFile();
        }
    }
}