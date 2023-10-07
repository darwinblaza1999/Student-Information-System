using Information_System.Class;
using Information_System.Interface;
using Information_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_System
{
    public partial class frmUpdatePassword : Form
    {
        private IUser _user;
        private bool _isLogin;
        private string _username;
        private string _id;
        public frmUpdatePassword(bool isLogin, string username, string id)
        {
            InitializeComponent();
            _user = new User();
            _isLogin = isLogin;
            _username = username;
            _id = id;
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            if (txtUname.Text.Length == 0 )
            {
                MessageBox.Show("Please input username");
            }
            else if (txtNewpass.Text.Length == 0 && txtConfirmPass.Text.Length == 0)
            {
                MessageBox.Show("Please input password.");
            }
            else if (txtNewpass.Text.Trim() != txtConfirmPass.Text.Trim())
            {
                MessageBox.Show("Password not match.");
            }
            else
            {
                var accModel = new UpdateAccount
                {
                    username = txtUname.Text.Trim(),
                    password = txtNewpass.Text.Trim(),
                    id = _id
                    
                };
                var updateAccount = _user.UpdateAccount(accModel);

                if (_isLogin)
                {
                    if (updateAccount.code == 100)
                    {
                        MessageBox.Show(updateAccount.message);
                        var frmlogin = new frmLogin();
                        frmlogin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(updateAccount.message);
                    }
                }
                else
                {
                    if (updateAccount.code == 100)
                    {
                        MessageBox.Show(updateAccount.message);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(updateAccount.message);
                    }
                }
            }
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            if (_id == string.Empty)
                _id = frmLogin.userid;
            if (_username == string.Empty)
                _username = frmLogin.username;
            txtUname.Text = _username;
        }
    }
}
