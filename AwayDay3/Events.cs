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
    public partial class Events : Form
    {
        private MainLogic logic;
        public Events()
        {
            InitializeComponent();
        }
        public Events(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnEstimateCost_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Main openForm = new Main();
            openForm.Show();
            Visible = false;
        }
    }
}
