/*
 * Danny Walasek
 * Radoslaw Warowny    
 */
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
        // Home button
        private void btnImportMessage_Click(object sender, EventArgs e)
        {
            Main openForm = new Main(logic);
            openForm.Show();
            Visible = false;
        }

        // On load of the form, request all communications with the currently logged in department.
        private void Communication_Load(object sender, EventArgs e)
        {
            txtCommunication.Text = logic.getCustomerCommunications();
            company_label.Text = logic.loggedInCompany.CompanyName;
        }        
    }
}
