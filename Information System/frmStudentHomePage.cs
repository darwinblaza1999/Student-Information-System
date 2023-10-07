using Information_System.Class;
using Information_System.Interface;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;

namespace Information_System
{
    public partial class frmStudentHomePage : Form
    {
        private readonly IStudent student;
        public frmStudentHomePage()
        {
            InitializeComponent();
            student = new Student();
        }

        private void frmStudentHomePage_Load(object sender, EventArgs e)
        {
            dgvStudent.DataSource = null;
            var listofUser = student.ViewStudent();
            if (listofUser.code == 200)
            {
                var json = JsonConvert.DeserializeObject<DataTable>(listofUser.data);
                dgvStudent.DataSource = json;
            }
            else
            {
                MessageBox.Show(listofUser.message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvStudent.DataSource;
            bs.Filter = "ID" + " like '%" + txtSearch.Text + "%'";
            dgvStudent.DataSource = bs;
        }
    }
}
