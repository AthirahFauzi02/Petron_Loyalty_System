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
    public partial class Redeem_Point : Form
    {
        Customer objCustomer = new Customer(); //Instantiate object named objCustomer of class Customer
        Transaction objTransaction = new Transaction(); //Instantiate transaction named objTransaction of class Transaction

        public Redeem_Point()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt"; //filepath for customer information text file
            string search = txtIDCardNo.Text;
            string line;
            if (System.IO.File.Exists(filepath) == true) //IF TEXT FILE FOUND 
            {
                using (StreamReader reader = new StreamReader(filepath)) //READ TEXT FILE
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Customer objCustomer; //Instantiate object named objCustomer of class Customer
                        ParseCustomer(line, out objCustomer);
                        if (search == objCustomer.IdcardNo)
                        {
                            txtName.Text = objCustomer.Name;
                            txtICNo.Text = objCustomer.Ic;
                            txtAddress.Text = objCustomer.Address;
                            txtPhoneNo.Text = objCustomer.Phone;
                            txtCurrentPoint.Text = Convert.ToString(objCustomer.Point1);
                        }
                    }
                }
            }
            else
                MessageBox.Show("File" + filepath + "doesn't exist");

        }
        bool ParseCustomer(string Text, out Customer objCustomer)//utk splitkan data by bar
        {
            objCustomer = new Customer(); //Instantiate object named objCustomer of class Customer
           
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

        private void btnRedemPoint_Click(object sender, EventArgs e)
        {
            if (txtIDCardNo.Text == "-")
            {
                MessageBox.Show("Please enter ID Card No");
                gbredeemitems.Enabled = false;
            }
            else
            {
                int point = int.Parse(txtCurrentPoint.Text); //read current point

                if (point < 100)
                {
                    MessageBox.Show("You do not have enough point for the redemption. Please try again later!");
                    gbredeemitems.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You are allowed for the redemption");
                    gbredeemitems.Enabled = true;
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int pointToRedeem = int.Parse(txtPointtoRedeem.Text);// read point to redeem

            if (pointToRedeem < 100)
            {
                MessageBox.Show("The point for the redemption should be more than 100");
            }
            else
            {
                if (pointToRedeem >= 100 && pointToRedeem <= 200)// if point for redemption more than 100 and less than 200
                {
                        cmbItem1.Enabled = true; // combo box for items 1 is enabled
                        cmbItem2.Enabled = false;
                        cmbItem3.Enabled = false;
                        cmbItem4.Enabled = false;                
                }
                else if (pointToRedeem >= 201 && pointToRedeem <= 300)//if point for redemption more than 201 and less than 300
                {
                    cmbItem1.Enabled = false;
                    cmbItem2.Enabled = true; //combo box for items 2 is enabled
                    cmbItem3.Enabled = false;
                    cmbItem4.Enabled = false;
                }
                else if (pointToRedeem >= 301 && pointToRedeem <= 400)//if point for redemption more than 301 and less than 400
                {
                    cmbItem1.Enabled = false;
                    cmbItem2.Enabled = false;
                    cmbItem3.Enabled = true; //combo box for items 3 is enabled
                    cmbItem4.Enabled = false;
                }
                else if (pointToRedeem >= 401)//if point for redemption more than 401
                {
                    cmbItem1.Enabled = false;
                    cmbItem2.Enabled = false;
                    cmbItem3.Enabled = false;
                    cmbItem4.Enabled = true; //combo box for items 4 is enabled
                }
            }
        }

        private void btnRedeemnow_Click(object sender, EventArgs e)
        {
            objCustomer = new Customer(); //Instantiate object named objCustomer of class Customer
            Transaction objTransaction = new Transaction(); //Instantiate transaction named objTransaction of class Transaction

            objCustomer.customerReg(objTransaction);
            int currentPoint = int.Parse(txtCurrentPoint.Text); //read current point
            int pointToRedeem = int.Parse(txtPointtoRedeem.Text); //read point for redemption

            int balancePoint = currentPoint - pointToRedeem; //calculate balance point

            txtRemainingPoint.Text = Convert.ToString(balancePoint); //display remaining point

            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";

            objCustomer.Name = txtName.Text;
            objCustomer.Ic = txtICNo.Text;
            objCustomer.Address = txtAddress.Text;
            objCustomer.Phone = txtPhoneNo.Text;
            objCustomer.IdcardNo = txtIDCardNo.Text;
            objCustomer.Point1 = int.Parse(txtRemainingPoint.Text);

            SaveToFile(filepath); //save customer details in CustomerInformation.txt text file
        }
        bool SaveToFile(string Filepath)
        {
            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = CustomerToLine2(objCustomer);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = CustomerToLine2(objCustomer);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }
        string CustomerToLine2(Customer objCustomer) //display 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(objCustomer.IdcardNo);
            sb.Append('|');
            sb.Append(objCustomer.Name);
            sb.Append('|');
            sb.Append(objCustomer.Ic);
            sb.Append('|');
            sb.Append(objCustomer.Address);
            sb.Append('|');
            sb.Append(objCustomer.Phone);
            sb.Append('|');
            sb.Append(objCustomer.Point1);

            return sb.ToString(); 
        }

        private void btnViewRedeemption_Click(object sender, EventArgs e)
        {
            objCustomer = new Customer();//Instantiate object named objCustomer of class Customer

            //display customer details and transaction details in list box
            listRedeemItem.Items.Add("ID Card No: " + txtIDCardNo.Text);//
            listRedeemItem.Items.Add("Name: " + txtName.Text);
            listRedeemItem.Items.Add("IC No: " + txtICNo.Text);
            listRedeemItem.Items.Add("Address: " + txtAddress.Text);
            listRedeemItem.Items.Add("Phone No: " + txtPhoneNo.Text);
            listRedeemItem.Items.Add("Redeem Point: " + txtPointtoRedeem.Text);
            listRedeemItem.Items.Add("Selected Item: " + cmbItem1.Text + cmbItem2.Text + cmbItem3.Text + cmbItem4.Text);
            listRedeemItem.Items.Add("Remaining Point: " + txtRemainingPoint.Text);

            string filepath3 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\RedemptionReport.txt";

            //read customer detail in text box
            objCustomer.Name = txtName.Text;
            objCustomer.Ic = txtICNo.Text;
            //objCustomer.Address = txtAddress.Text;
            //objCustomer.Phone = txtPhoneNo.Text;
            objCustomer.IdcardNo = txtIDCardNo.Text;
            objCustomer.Point1 =int.Parse(txtRemainingPoint.Text);

            SaveToFile3(filepath3);
        }
        bool SaveToFile3(string Filepath3)
        {
            string filepath3 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\RedemptionReport.txt";
            if (!File.Exists(filepath3))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath3))
                {
                    string Line = CustomerToLine3(objCustomer);
                    file.WriteLine(Line);//write to file
                }
            }
            else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath3))
                {
                    string Line = CustomerToLine3(objCustomer);
                    file.WriteLine(Line);
                }
            //file.Close();
            return true;
        }
        string CustomerToLine3(Customer objCustomer)
        {
            //save customer detail and redemption detail in text box
            StringBuilder sb = new StringBuilder();
            sb.Append("ID CARD NO: ");
            sb.Append(objCustomer.IdcardNo);
            sb.Append(" NAME: ");
            sb.Append(objCustomer.Name);
            sb.Append(" IC NO: ");
            sb.Append(objCustomer.Ic);
            sb.Append(" ACCUMULATED POINT:");
            //sb.Append(objCustomer.Address);
            //sb.Append('|');
            //sb.Append(objCustomer.Phone);
            //sb.Append('|');
            sb.Append(txtCurrentPoint.Text);
            sb.Append(" POINT TO REDEEM: ");
            sb.Append(txtPointtoRedeem.Text);
            sb.Append(" SELECTED ITEM: ");
            sb.Append(cmbItem1.Text + cmbItem2.Text + cmbItem3.Text + cmbItem4.Text);
            sb.Append(" BALANCE POINT: ");
            sb.Append(objCustomer.Point1);

            Debug.WriteLine(sb.ToString());
            return sb.ToString();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mainMenu = new Main_Menu();
            mainMenu.ShowDialog();
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


