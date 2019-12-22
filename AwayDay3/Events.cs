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
        List<KeyValuePair<string, bool>> activitys = new List<KeyValuePair<string, bool>>();
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
            Main openForm = new Main(logic);
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (box_chocolate.Checked)
            {
                KeyValuePair<string, bool> act = new KeyValuePair<string, bool>("chocolate", true);
                activitys.Add(act);
            }
            if (box_climbing.Checked)
            {
                KeyValuePair<string, bool> act = new KeyValuePair<string, bool>("climbing", true);
                activitys.Add(act);
            }
            if (box_gocart.Checked)
            {
                KeyValuePair<string, bool> act = new KeyValuePair<string, bool>("gocart", true);
                activitys.Add(act);
            }
            if (box_meditation.Checked)
            {
                KeyValuePair<string, bool> act = new KeyValuePair<string, bool>("meditation", true);
                activitys.Add(act);
            }
            label_status.Text = logic.SubmitRequest((int)numguests.Value,dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value, activitys);
            logic.AddCommunication(1,false, 0, DateTime.Now, "Request submitted for a new event");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, bool> activity = new KeyValuePair<string, bool>(txt_activity.Text, box_pricerequest.Checked);
            activitys.Add(activity);
        }
    }
}
