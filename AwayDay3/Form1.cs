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
    public partial class Form1 : Form
    {
        private MainLogic logic = new MainLogic();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Registration openForm = new Registration(logic);
            openForm.Show();
            Visible = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Main openForm = new Main(logic);
            openForm.Show();
            Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            status_label.Text = logic.logIn(txtFirstName.Text, txtLastName.Text);
        }
    }
}
