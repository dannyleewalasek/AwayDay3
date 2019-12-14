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
    public partial class Login : Form
    {
        MainLogic logic;
        public Login()
        {
            InitializeComponent();
        }
        public Login(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main openForm = new Main();
            openForm.Show();
            Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Main openForm = new Main();
            openForm.Show();
            Visible = false;

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
