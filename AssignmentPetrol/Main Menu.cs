using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssignmentPetrol
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void btnRegisterCust_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register RegisterCustomer = new Register();

            RegisterCustomer.ShowDialog();
            this.Close();
        }

        private void btnBuyItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy_Item Sales = new Buy_Item();

            Sales.ShowDialog();
            this.Close();
        }

        private void btnRedeemPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Redeem_Point redeemPoint = new Redeem_Point();

            redeemPoint.ShowDialog();
            this.Close();
        }

        private void btnRedemPoint_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_all_Report report = new view_all_Report();

            report.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}