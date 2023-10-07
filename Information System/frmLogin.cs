using Information_System.Class;
using Information_System.Enum;
using Information_System.Interface;
using Information_System.Model;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace Information_System
{
    public partial class frmLogin : Form
    {
        private IUser _user;
        public static string username;
        public static string userid;
        public frmLogin()
        {
            InitializeComponent();
            _user = new User();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input username!");
            }
            else if (txtpassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please input password!");
            }
            else
            {

                var accModel = new AccountModel
                {
                    username = txtUsername.Text.Trim(),
                    password = txtpassword.Text.Trim()
                };
                var login = _user.Login(accModel);
                if (login.code == 200)
                {
                    var json = login.data;
                    userid = json.id;
                    if (json.password == "password")
                    {
                        var dialog = MessageBox.Show("Your password does not allowed to login, Do you want to change your password?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialog == DialogResult.OK)
                        {
                            var frmUpdateAcc = new frmUpdatePassword(true, username, userid);
                            frmUpdateAcc.Show();
                        }
                    }

                    if (json.roles == (int)RoleEnum.User)
                    {
                        MessageBox.Show($"User {login.message}");
                        var frmHome = new frmStudentHomePage();
                        frmHome.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Admin {login.message}");
                        var frmHome = new frmAdminHomePage();
                        frmHome.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No user found!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text.Trim();
        }
    }
}
