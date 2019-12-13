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
        public Registration()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Events openForm = new Events();
            openForm.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account openForm = new Account();
            openForm.Show();
            Visible = false;
        }
    }
}
