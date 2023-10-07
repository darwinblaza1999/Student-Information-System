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
    public partial class frmUserRegister : Form
    {
        private IUser _user;
        public frmUserRegister()
        {
            InitializeComponent();
            _user = new User();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var userModel = new UserModel
                {
                    firstname = txtfname.Text.Trim(),
                    middlename = txtmname.Text.Trim(),
                    lastname = txtlname.Text.Trim(),
                    address = txtaddress.Text.Trim(),
                    email = txtemail.Text.Trim(),
                    conNo = Int64.Parse(txtConNo.Text)
                };

                var insert = await _user.InsertNewUser(userModel);
                if (insert.code == 200)
                {
                    MessageBox.Show(insert.message);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(insert.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
