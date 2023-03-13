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
    public partial class Buy_Item : Form
    {
        Customer theCust = new Customer();
        Transaction objTransaction = new Transaction();

        public Buy_Item()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Customer theCust = new Customer();//Instantiate object named objCustomer of class Customer
            Transaction objTransaction = new Transaction();//Instantiate object named objTransaction of class Transaction
            theCust.customerReg(objTransaction);//ESTABLISH CONNECTION BETWEEN CLASS CUSTOMER AND TRANSACTOIN

            objTransaction.Totallitrefuel = int.Parse(txtTotalLitre.Text); //read from text box
            objTransaction.Totalitem = int.Parse(txtTotalPriceItems.Text);
            
            int totalPriceforFuel = theCust.getCalculatetotalPriceforFuel(); //CALL METHOD IN CLASS CUSTOMER TO CALCULATE TOTAL PRICE FOR FUEL
            int totalTransaction = theCust.getcalculatetotalPrice();////CALL METHOD IN CLASS CUSTOMER TO CALCULATE TOTAL TRANSACTION

            txtTotalPrice.Text = Convert.ToString(theCust.getcalculatetotalPrice()); //DISPLAY ANSWER IN TEXT BOX
            
            Program.item = int.Parse(txtTotalPriceItems.Text);
            Program.fuel = int.Parse(txtTotalLitre.Text);
            Program.pricelitre = totalPriceforFuel;
            Program.totalTransaction = totalTransaction;

        }

        private void btnCalBalance_Click(object sender, EventArgs e)
        {
            Program.Name = txtName.Text;
            Program.IDCard = txtIDCardNo.Text;
            Program.IC = txtICNo.Text;
            Program.payment = int.Parse(txtPayment.Text);

            Customer theCust = new Customer(); //Instantiate object named objCustomer of class Customer
            Transaction objTransaction = new Transaction(); //Instantiate object named objTransaction of class Transaction

            theCust.customerReg(objTransaction);

            int payment = int.Parse(txtPayment.Text);
            int totalPrice = int.Parse(txtTotalPrice.Text);

            if (payment >= totalPrice)
            {
                int calculateBalance = payment - totalPrice;//calculate balance
                txtBalance.Text = Convert.ToString(calculateBalance); //display balance in text box
                Program.balance = int.Parse(txtBalance.Text);
            }
            else
            {
                MessageBox.Show("Payment should be more than total price");
            }            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt"; //FILE PATH FOR TEXT FILE TO SEARCH CUSTOMER INFORMATION
            string search = txtIDCardNo.Text;
            string line;
            if (System.IO.File.Exists(filepath) == true) //IF TEXT FILE FOUND 
            {
                using (StreamReader reader = new StreamReader(filepath)) //READ TEXT FILE
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        Customer objCustomer; // Instantiate object named objCustomer of class Customer
                        ParseCustomer(line, out objCustomer); 
                        if (search == objCustomer.IdcardNo)
                        {
                            txtName.Text = objCustomer.Name;
                            txtICNo.Text = objCustomer.Ic;
                            txtAddress.Text = objCustomer.Address;
                            txtPhoneNo.Text = objCustomer.Phone;
                            txtPoint.Text = Convert.ToString(objCustomer.Point1);
                            theCust = objCustomer;
                        }
                    }
                }
            }
            else
                MessageBox.Show("File" + filepath + "doesn't exist");

        }
        bool ParseCustomer(string Text, out Customer objCustomer)//utk splitkan data by bar
        {
            objCustomer = new Customer(); //CREATE OBJECT CUSTOMER
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

        private void btnCollectPoint_Click_1(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text == "-")
            {
                MessageBox.Show("Please complete the transaction first");
            }
            else
            {
                Customer theCust = new Customer(); //Instantiate object named objCustomer of class Customer
                Transaction objTransaction = new Transaction();//Instantiate object named objTransaction of class Transaction

                theCust.customerReg(objTransaction);
                Program.CollectedPoint = theCust.getCalculateconvertToPoint(); //CALL METHOD IN CLASS CUSTOMER TO CALCULATE TOTAL POINT 

                objTransaction.Totallitrefuel = int.Parse(txtTotalLitre.Text);
                objTransaction.Totalitem = int.Parse(txtTotalPriceItems.Text);

                int totalPoint = theCust.getCalculateconvertToPoint();

                txtCollectedPoint.Text = Convert.ToString(totalPoint);//DISPLAY TOTAL POINT 
            }

        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {
            if (txtIDCardNo.Text == "-")
            {
                MessageBox.Show("Please complete the transaction first");
            }
            else
            {
                string filepath2 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerTransaction.txt"; //FILE PATH FOR CUSTOMER TRANSACTION TEXT FILE

                int payment = int.Parse(txtPayment.Text);
                int totalPrice = int.Parse(txtTotalPrice.Text);
                theCust = new Customer();
                theCust.customerReg(objTransaction);

                theCust.Name = txtName.Text;
                theCust.Ic = txtICNo.Text;
                theCust.IdcardNo = txtIDCardNo.Text;
                objTransaction.Totallitrefuel = int.Parse(txtTotalLitre.Text);
                objTransaction.Totalitem = int.Parse(txtTotalPriceItems.Text);
                payment = int.Parse(txtPayment.Text);
                objTransaction.TotalPriceTransaction = int.Parse(txtTotalPrice.Text);
                int balance = int.Parse(txtBalance.Text);

                SaveToFile2(filepath2); //save customer transaction in CustomerTransaction.txt text file

                this.Hide();
                Transaction_Receipt receipt = new Transaction_Receipt(); //open transaction receipt
                receipt.ShowDialog();
                this.Close();
            }
        
            
        }
            bool SaveToFile2(string Filepath2)
            {
                string filepath2 = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerTransaction.txt";
                if (!File.Exists(filepath2))
                {
                    // Create a file to write to.
                    using (StreamWriter file = File.CreateText(filepath2))
                    {
                        string Line = CustomerToLine(theCust);
                        file.WriteLine(Line);//write to file
                    }
                }
                else
                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter file = File.AppendText(filepath2))
                    {
                        string Line = CustomerToLine(theCust);
                        file.WriteLine(Line);
                    }
                //file.Close();
                return true;
            }
            string CustomerToLine(Customer theCust)
            {
                
                StringBuilder sb = new StringBuilder();
                sb.Append(txtIDCardNo.Text);
                sb.Append("         ");
                sb.Append(txtName.Text);
                sb.Append("     ");
                sb.Append(txtICNo.Text);
                sb.Append("         ");
                sb.Append(int.Parse(txtTotalLitre.Text));
                sb.Append("                             ");
                sb.Append(int.Parse(txtTotalPriceItems.Text));
                sb.Append("                                     ");
                sb.Append(int.Parse(txtTotalPrice.Text));
                sb.Append("                                 ");
                sb.Append(int.Parse(txtPayment.Text));
                sb.Append("                       ");
                sb.Append(int.Parse(txtBalance.Text));
               

                //Debug.WriteLine(sb.ToString());
                return sb.ToString();

        
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            theCust = new Customer();
            Transaction objTransaction = new Transaction();

            theCust.customerReg(objTransaction);
            //theCust.Point1 = theCust.calculateCurrentPoint();
            int currentPoint = (int.Parse(txtPoint.Text)) + (int.Parse(txtCollectedPoint.Text));
            txtTotalPoint.Text = Convert.ToString(currentPoint);

            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";

            theCust.Name = txtName.Text;
            theCust.Ic = txtICNo.Text;
            theCust.Address = txtAddress.Text;
            theCust.Phone = txtPhoneNo.Text;
            theCust.IdcardNo = txtIDCardNo.Text;
            theCust.Point1 = int.Parse(txtTotalPoint.Text);

            SaveToFile(filepath);
        }
        bool SaveToFile(string Filepath)
        {
            string filepath = @"C:\Users\Athirah\Desktop\Assignment\1 HND LIFE\H3\OOP\CustomerInformation.txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                using (StreamWriter file = File.CreateText(filepath))
                {
                    string Line = CustomerToLine2(theCust);
                    file.WriteLine(Line);//write to file
                }
             }
             else
                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter file = File.AppendText(filepath))
                {
                    string Line = CustomerToLine2(theCust);
                    file.WriteLine(Line);
                }
                //file.Close();
                return true;
                }
                string CustomerToLine2(Customer objCustomer)
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
    }
}
