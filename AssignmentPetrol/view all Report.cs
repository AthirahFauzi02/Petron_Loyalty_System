using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssignmentPetrol
{
    public partial class view_all_Report : Form
    {
        public view_all_Report()
        {
            InitializeComponent();
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            //customer report form displayed
            this.Hide();
            Customer_Report reportCustomer = new Customer_Report();
            reportCustomer.ShowDialog();
            this.Close();
        }

        private void btnTransactionReport_Click(object sender, EventArgs e)
        {
            //transaction report form displayed
            this.Hide();
            Transaction_Report reportTransaction = new Transaction_Report();
            reportTransaction.ShowDialog();
            this.Close();
        }

        private void btnRedeemptionReport_Click(object sender, EventArgs e)
        {
            //redemption report form displayed
            this.Hide();
            Redeemption_Report reportRedeemption = new Redeemption_Report();
            reportRedeemption.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //main menu form displayed
            this.Hide();
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();// application close
        }
    }
}