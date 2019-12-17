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
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Main openForm = new Main();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_status.Text = logic.submitRequest((int)numguests.Value,dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value);
        }

        private void Events_Load(object sender, EventArgs e)
        {

        }
    }
}
