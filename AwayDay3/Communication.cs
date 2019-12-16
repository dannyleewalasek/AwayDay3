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
    public partial class Communication : Form
    {
        MainLogic logic;
        public Communication()
        {
            InitializeComponent();
        }
        public Communication(MainLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void btnImportMessage_Click(object sender, EventArgs e)
        {
            Main openForm = new Main(logic);
            openForm.Show();
            Visible = false;
        }

        private void Communication_Load(object sender, EventArgs e)
        {
            txtCommunication.Text = logic.getCustomerCommunications();
        }

        private void gbxCommunication_Enter(object sender, EventArgs e)
        {
        }
    }
}
