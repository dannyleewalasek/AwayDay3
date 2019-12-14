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
    public partial class Registration : Form
    {
        private MainLogic logic;
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtstatus.Text = logic.Register(txtBusinessName.Text, txtDepartment.Text, txtBusinessEmail.Text);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Events openForm = new Events();
            openForm.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account openForm = new Account(logic);
            openForm.Show();
            Visible = false;
        }
        
    }
}
