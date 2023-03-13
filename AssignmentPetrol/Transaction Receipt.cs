using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AssignmentPetrol
{
    public partial class Transaction_Receipt : Form
    {
        
        Customer objCustomer = new Customer();
        Transaction objTransaction = new Transaction();

        public Transaction_Receipt()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //display Customer's detail and transaction detail in list box
            listBoxTransaction.Items.Add("ID Card No: " + Program.IDCard);
            listBoxTransaction.Items.Add("Name: " + Program.Name);
            listBoxTransaction.Items.Add("IC No: " + Program.IC);
            listBoxTransaction.Items.Add("Total Fuels: " + Program.fuel);
            listBoxTransaction.Items.Add("Price for fuel: " + Program.pricelitre);
            listBoxTransaction.Items.Add("Price for items: " + Program.item);
            listBoxTransaction.Items.Add("Total Price: " + Program.totalTransaction);
            listBoxTransaction.Items.Add("Payment: " + Program.payment);
            listBoxTransaction.Items.Add("Balance: " + Program.balance);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //form cleared
            Controls.Clear();
            InitializeComponent();
        }
        
        
    }
}