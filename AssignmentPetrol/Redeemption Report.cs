using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AssignmentPetrol
{
    public partial class Redeemption_Report : Form
    {
        public Redeemption_Report()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_all_Report back = new view_all_Report();
            back.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }

        private void txtView_Click(object sender, EventArgs e)
        {
            string filepath3 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\RedemptionReport.txt"; //filepath for redemption details

           //display all the details in text file in list box.
            string[] readTextFile = File.ReadAllLines(filepath3);

            for (int i = 0; i < readTextFile.Length; i++)
            {
                listBoxReport.Items.Add(readTextFile[i]);
            }
        }
    }
}