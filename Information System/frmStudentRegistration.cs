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
    public partial class frmStudentRegistration : Form
    {
        private IStudent _student;
        public frmStudentRegistration()
        {
            InitializeComponent();
            _student = new Student();
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            var studentModel = new StudentModel
            {
                firstname = txtfname.Text.Trim(),
                middlename = txtmname.Text.Trim(),
                lastname = txtlname.Text.Trim(),
                address = txtaddress.Text.Trim(),
                email = txtemail.Text.Trim(),
                conNo = Int64.Parse(txtConNo.Text),
                course = txtcourse.Text.Trim(),
                yearlevel = cboyearlevel.Text.Trim()
            };
            var insertStudent = _student.AddNewStudent(studentModel);
            if (insertStudent.code == 200)
            {
                MessageBox.Show(insertStudent.message);
                this.Close();
            }
            else
            {
                MessageBox.Show(insertStudent.message);
            }
        }
    }
}
