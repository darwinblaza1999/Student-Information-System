using Information_System.Class;
using Information_System.Interface;
using Information_System.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Information_System
{
    public partial class frmUserUpdateOrDelete : Form
    {
        private readonly IUser _user;
        private readonly bool _isUpdate;
        private readonly ICommon _common;
        public frmUserUpdateOrDelete(bool isUpdate)
        {
            InitializeComponent();
            _user = new User();
            _isUpdate = isUpdate;
            _common = new Common();
        }

        private void frmUserUpdateOrDelete_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                btnUpdateOrDelete.Text = "&Delete";
            }
            var listofUser = _user.ViewUser();
            if (listofUser.code == 200)
            {
                var json = JsonConvert.DeserializeObject<DataTable>(listofUser.data);
                if (json.Rows.Count > 0)
                {
                    cboUserId.DataSource = json;
                    cboUserId.DisplayMember = "ID";
                    cboUserId.ValueMember = "ID";
                }
            }
            else
            {
                MessageBox.Show(listofUser.message);
            }
        }

        private void cboUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUserId.Text.Trim() != "System.Data.DataRowView")
            {
                var data = _common.GetUserOrStudentById(cboUserId.Text.Trim(), "user");
                
                if (data.code == 200)
                {
                    var json = JsonConvert.DeserializeObject<DataTable>(data.data);
                    if (json.Rows.Count > 0)
                    {
                        foreach (DataRow row in json.Rows)
                        {
                            txtfname.Text = row["Firstname"].ToString();
                            txtmname.Text = row["Middlename"].ToString();
                            txtlname.Text = row["Lastname"].ToString();
                            txtaddress.Text = row["Address"].ToString();
                            txtConNo.Text = row["ConNo"].ToString();
                            txtemail.Text = row["Email"].ToString();
                            if (_isUpdate) { EnabledText(); } else { DisabledText(); }
                        }
                    }
                }
            }
        }
        private void DisabledText()
        {
            txtfname.Enabled = false;
            txtmname.Enabled = false;
            txtlname.Enabled = false;
            txtaddress.Enabled = false;
            txtConNo.Enabled = false;
            txtemail.Enabled = false;
        }
        private void EnabledText()
        {
            txtfname.Enabled = true;
            txtmname.Enabled = true;
            txtlname.Enabled = true;
            txtaddress.Enabled = true;
            txtConNo.Enabled = true;
            txtemail.Enabled = true;
        }

        private void btnUpdateOrDelete_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                if (cboUserId.Text.Trim() != null)
                {
                    var userModel = new UpdateUserModel
                    {
                        id = cboUserId.Text.Trim(),
                        firstname = txtfname.Text.Trim(),
                        middlename = txtmname.Text.Trim(),
                        lastname = txtlname.Text.Trim(),
                        address = txtaddress.Text.Trim(),
                        email = txtemail.Text.Trim(),
                        conNo = Int64.Parse(txtConNo.Text)
                    };
                    var updateUser = _user.UpdateUserAccount(userModel);
                    MessageBox.Show(updateUser.message);
                }
                else
                {
                    MessageBox.Show("No User Id found!");
                }
                
            }
            else
            {
                if (cboUserId.Text.Trim() != null)
                {
                    var deleteUser = _user.DeleteUser(cboUserId.Text.Trim());
                    MessageBox.Show(deleteUser.message);
                }
                else
                {
                    MessageBox.Show("No User Id found!");
                }
            }
        }
    }
}
