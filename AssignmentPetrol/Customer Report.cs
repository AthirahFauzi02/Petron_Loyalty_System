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
    public partial class Customer_Report : Form
    {
        public Customer_Report()
        {
            InitializeComponent();
        }

        private void txtView_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";
            
            string line;

            if (System.IO.File.Exists(filepath) == true)
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    listBoxReport.Items.Add("ID CARD NO" + "\t" + "CUST NAME" + "\t" + "CUST IC NO" + "\t " + "ADDRESS" + "\t " + "PHONE NO" + "\t " + "CURRENT POINT");
                    listBoxReport.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                    while (!reader.EndOfStream)
                    {
                        line=reader.ReadLine();
                        Customer objCustomer;
                        ParseCustomer(line, out objCustomer);
                        listBoxReport.Items.Add(objCustomer.IdcardNo + "\t" + objCustomer.Name + "\t" + objCustomer.Ic + "\t " + objCustomer.Address + "\t " + objCustomer.Phone+ "\t " + objCustomer.Point1);
                    }
                 }
            }
            else
                MessageBox.Show("File" + filepath + "doesn't exist");

            }
            bool ParseCustomer(string Text, out Customer objCustomer)//utk splitkan data by bar
            {
                objCustomer = new Customer();
                string[] arr = Text.Split('|');
                if (arr.Length != 6)

                return false;

                objCustomer.IdcardNo = arr[0];
                objCustomer.Name = arr[1];
                objCustomer.Ic = arr[2];
                objCustomer.Address = arr[3];
                objCustomer.Phone = arr[4];
                objCustomer.Point1 = int.Parse(arr[5]);
                return true;
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
        
    }
}