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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration openForm = new Registration();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Communication openForm = new Communication();
            openForm.Show();
            Visible = false;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Message openForm = new Message();
            openForm.Show();
            Visible = false;
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Message openForm = new Message();
            openForm.Show();
            Visible = false;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            Message openForm = new Message();
            openForm.Show();
            Visible = false;
        }

        private void btnCancellations_Click(object sender, EventArgs e)
        {
            Message openForm = new Message();
            openForm.Show();
            Visible = false;
        }
    }
}
