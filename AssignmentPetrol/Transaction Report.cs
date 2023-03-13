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
    public partial class Transaction_Report : Form
    {
        public Transaction_Report()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //MAIN MENU FORM DISLAYED
            this.Hide();
            view_all_Report back = new view_all_Report();
            back.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //APPLICATION CLOSED
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //FORM WILL BE CLEARED
            Controls.Clear();
            InitializeComponent();
        }

        private void txtView_Click(object sender, EventArgs e)
        {
            string filepath2 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerTransaction.txt";

            listBoxReport.Items.Add("ID CARD NO" + "     " + "NAME" + "             " + "IC NO" + "             " + "TOTAL LITRE" + "     " + "TOTAL PRICE ITEMS" + "     " + "TOTAL TRANSACTION" + "     " + "PAYMENT" + "     " + "BALANCE");
            listBoxReport.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    
            //display all the details in text file in list box.
            string[] readTextFile = File.ReadAllLines(filepath2);

            for (int i = 0; i < readTextFile.Length; i++)
            {
                listBoxReport.Items.Add(readTextFile[i]);
            }
        }
    }
}