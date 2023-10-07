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

namespace Information_System
{
    public partial class frmUpdateOrDeleteStudent : Form
    {
        private readonly IStudent _student;
        private readonly ICommon _common;
        private readonly bool _isUpdate;
        public frmUpdateOrDeleteStudent(bool isUpdate)
        {
            InitializeComponent();
            _student = new Student();
            _common = new Common();
            _isUpdate = isUpdate;
        }

        private void frmUpdateOrDeleteStudent_Load(object sender, EventArgs e)
        {
            if (!_isUpdate)
            {
                btnStudentRegister.Text = "&Delete";
            }
            var listofUser = _student.ViewStudent();
            if (listofUser.code == 200)
            {
                var json = JsonConvert.DeserializeObject<DataTable>(listofUser.data);
                if (json.Rows.Count > 0)
                {
                    cboStudentId.DataSource = json;
                    cboStudentId.DisplayMember = "ID";
                    cboStudentId.ValueMember = "ID";
                }
            }
            else
            {
                MessageBox.Show(listofUser.message);
            }
        }

        private void cboStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = _common.GetUserOrStudentById(cboStudentId.Text.Trim(), "student");
            var json = JsonConvert.DeserializeObject<DataTable>(data.data);
            if (data.code == 200)
            {
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
                        txtcourse.Text = row["Course"].ToString();
                        cboyearlevel.Text = row["YearLevel"].ToString();
                        if (_isUpdate) { EnabledText(); } else { DisabledText(); }
                    }
                }
            }
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                if (cboStudentId.Text.Trim() != null)
                {
                    var studentModel = new UpdateStudentModel
                    {
                        id = cboStudentId.Text.Trim(),
                        firstname = txtfname.Text.Trim(),
                        middlename = txtmname.Text.Trim(),
                        lastname = txtlname.Text.Trim(),
                        address = txtaddress.Text.Trim(),
                        email = txtemail.Text.Trim(),
                        conNo = Int64.Parse(txtConNo.Text),
                        course = txtcourse.Text.Trim(),
                        yearlevel = cboyearlevel.Text.Trim()
                    };
                    var updateStudent = _student.UpdateStudent(studentModel);
                    MessageBox.Show(updateStudent.message);
                }
                else
                {
                    MessageBox.Show("No StudentId found");
                }
                
            }
            else
            {
                if (cboStudentId.Text.Trim() != null)
                {
                    var deleteStudent = _student.DeleteStudent(cboStudentId.Text.Trim());
                    MessageBox.Show(deleteStudent.message);
                }
                else
                {
                    MessageBox.Show("No StudentId found");
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
            txtcourse.Enabled = false;
            cboyearlevel.Enabled = false;
        }
        private void EnabledText()
        {
            txtfname.Enabled = true;
            txtmname.Enabled = true;
            txtlname.Enabled = true;
            txtaddress.Enabled = true;
            txtConNo.Enabled = true;
            txtemail.Enabled = true;
            txtcourse.Enabled = true;
            cboyearlevel.Enabled = true;
        }
    }
}
