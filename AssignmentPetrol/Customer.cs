using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AssignmentPetrol
{
    public class Customer
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string ic;

        public string Ic
        {
            get { return ic; }
            set { ic = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string idcardNo;

        public string IdcardNo
        {
            get { return idcardNo; }
            set { idcardNo = value; }
        }

        public Customer() // CONSTRUCTOR
        { }

        private int Point;

        public int Point1
        {
          get { return Point; }
          set { Point = value; }
        }
        private Transaction TransactionforSale;//ATTRIBUTE

        public Transaction TransactionforSale1
        {
            get { return TransactionforSale; }
            set { TransactionforSale = value; }
        }

        public void customerReg(Transaction aTransaction)
        {
            TransactionforSale1 = aTransaction;
        }
        public int getCalculatetotalPriceforFuel()// METHOD TO CALL METHOD CalculateTotalPriceforFuel FROM CLASS TRANSACTION
        {
            return TransactionforSale1.CalculatetotalPriceforFuel();
        }
        public int getcalculatetotalPrice()//METHOD TO CALL METHOD calculatetotalprice FROM CLASS TRANSACTION
        {
            return TransactionforSale1.calculatetotalPrice();
        }
        public int getCalculateconvertToPoint()////METHOD TO CALL METHOD CalculateconvertToPoint FROM CLASS TRANSACTION
        {
            return TransactionforSale1.CalculateconvertToPoint();
        }

        public int calculateCurrentPoint()// METHOD TO CALCULATE CURRENT TOTAL POINT
        {
            return Point1 = Point1 + TransactionforSale1.CalculateconvertToPoint();//
        }
    }
}
