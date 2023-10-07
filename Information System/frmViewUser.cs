using Information_System.Class;
using Information_System.Interface;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Information_System
{
    public partial class frmViewUser : Form
    {
        private IUser _user;
        public frmViewUser()
        {
            InitializeComponent();
            _user = new User();
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = null;
            var listofUser = _user.ViewUser();
            if (listofUser.code == 200)
            {
                var json = JsonConvert.DeserializeObject<DataTable>(listofUser.data);
                dgvUser.DataSource = json;
            }
            else
            {
                MessageBox.Show(listofUser.message);
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvUser.DataSource;
            bs.Filter = "ID" + " like '%" + txtsearch.Text + "%'";
            dgvUser.DataSource = bs;
        }
    }
}
