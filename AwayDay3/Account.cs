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
            txtFirstName.Text = logic.loggedInCompany.firstName;
            txtLastName.Text = logic.loggedInCompany.lastName;
            txtBusinessName.Text = logic.loggedInCompany.CompanyName;
            txtDepartment.Text = logic.loggedInDepartment.DepartmentName;
            txtBusinessEmail.Text = logic.loggedInCompany.companyEmail;
            txtCity.Text = logic.loggedInCompany.city;
            txtBusinessAddress.Text = logic.loggedInCompany.address;
            txtPostCode.Text = logic.loggedInCompany.postCode;
            txtBusinessPhone.Text = logic.loggedInCompany.phone;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            logic.loggedInCompany.firstName = txtFirstName.Text;
            logic.loggedInCompany.lastName = txtLastName.Text;
            logic.loggedInCompany.CompanyName = txtBusinessName.Text;
            logic.loggedInDepartment.DepartmentName = txtDepartment.Text;
            logic.loggedInCompany.companyEmail = txtBusinessEmail.Text;
            logic.loggedInCompany.city = txtCity.Text;
            logic.loggedInCompany.address = txtBusinessAddress.Text;
            logic.loggedInCompany.postCode = txtPostCode.Text;
            logic.loggedInCompany.phone = txtBusinessPhone.Text;
        }
    }
}
