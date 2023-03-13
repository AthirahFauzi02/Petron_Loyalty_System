using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AssignmentPetrol
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";
        Customer aCustomer; //instantiate object named objCustomer of class Customer

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();

            aCustomer.Name = txtName.Text;
            aCustomer.Ic = txtICNo.Text;
            aCustomer.Address = txtAddress.Text;
            aCustomer.Phone = txtPhoneNo.Text;
            aCustomer.IdcardNo = txtIDCardNo.Text;
            aCustomer.Point1 = int.Parse(txtPoint.Text);

            if (aCustomer.Name == "-" || aCustomer.Ic == "-" || aCustomer.Address == "-" || aCustomer.Phone == "-" || aCustomer.IdcardNo == "-")
            {
                MessageBox.Show("Please complete the form");
            }
            else
            {
                SaveToFile(filepath); //save customer details in CustomerInformation.txt text file
                MessageBox.Show("You has been Registered Successfully");
            }
        }
        bool SaveToFile(string Filepath)
        {
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = CustomerToLine(aCustomer);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = CustomerToLine(aCustomer);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }
        string CustomerToLine(Customer aCustomer)
        {
            //displayed customer's detail in text file
            StringBuilder sb = new StringBuilder();
            sb.Append(aCustomer.IdcardNo);
            sb.Append('|');
            sb.Append(aCustomer.Name);
            sb.Append('|');
            sb.Append(aCustomer.Ic);
            sb.Append('|');
            sb.Append(aCustomer.Address);
            sb.Append('|');
            sb.Append(aCustomer.Phone);
            sb.Append('|');
            sb.Append(aCustomer.Point1);

            Debug.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //main menu form displayed
            this.Hide();
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //form cleared
            Controls.Clear();
            InitializeComponent();
        }
    }
}