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
    public partial class frmAdminHomePage : Form
    {
        public frmAdminHomePage()
        {
            InitializeComponent();
        }

        private void updateCredentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUpdateCred = new frmUpdatePassword(false, frmLogin.username, frmLogin.userid);
            frmUpdateCred.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUpdateUser = new frmUserUpdateOrDelete(true);
            frmUpdateUser.Text = "Update";
            frmUpdateUser.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmUpdate = new frmUpdateOrDeleteStudent(true);
            frmUpdate.Text = "Update";
            frmUpdate.Show();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDeleteStudent = new frmUpdateOrDeleteStudent(true);
            frmDeleteStudent.Text = "Delete";
            frmDeleteStudent.Show();
        }

        private void deleteUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmDeleteUser = new frmUserUpdateOrDelete(false);
            frmDeleteUser.Text = "Update";
            frmDeleteUser.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmViewUser = new frmViewUser();
            frmViewUser.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddUser = new frmUserRegister();
            frmAddUser.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddStudent = new frmStudentRegistration();
            frmAddStudent.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmViewStudent = new frmStudentHomePage();
            frmViewStudent.Show();
        }
    }
}
