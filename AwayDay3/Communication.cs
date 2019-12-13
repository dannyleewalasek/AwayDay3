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
        public Communication()
        {
            InitializeComponent();
        }

        private void btnImportMessage_Click(object sender, EventArgs e)
        {
            Main openForm = new Main();
            openForm.Show();
            Visible = false;
        }
    }
}
