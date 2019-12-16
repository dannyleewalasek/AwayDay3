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
        MainLogic logic;
        public Main()
        {
            InitializeComponent();
        }
        public Main(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration openForm = new Registration(logic);
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Communication openForm = new Communication(logic);
            openForm.Show();
            Visible = false;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
        }

        private void btnCancellations_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1(logic);
            openForm.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Account openForm = new Account(logic);
            openForm.Show();
            Visible = false;
        }
    }
}
