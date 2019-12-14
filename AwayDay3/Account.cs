using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDay3
{
    public partial class Account : Form
    {
        private MainLogic logic;
        public Account()
        {
            InitializeComponent();
        }

        public Account(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Events openForm = new Events(logic);
            openForm.Show();
            Visible = false;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            txtBusinessName.Text = logic.loggedInCompany.CompanyName;
            txtDepartment.Text = logic.loggedInDepartment.DepartmentName;
            txtBusinessEmail.Text = logic.loggedInCompany.companyEmail;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            logic.UpdateCompany(txtBusinessEmail.Text);
        }
    }
}
