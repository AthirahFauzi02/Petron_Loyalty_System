using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPetrol
{
    public class Transaction
    {
        private int totalitem;

        public int Totalitem
        {
            get { return totalitem; }
            set { totalitem = value; }
        }
        private int totallitrefuel;

        public int Totallitrefuel
        {
            get { return totallitrefuel; }
            set { totallitrefuel = value; }
        }

        private int totalPriceTransaction;

        public int TotalPriceTransaction
        {
            get { return totalPriceTransaction; }
            set { totalPriceTransaction = value; }
        }

        public Transaction()
        {}

        public Transaction(int i, int f)
        {
            totalitem = i;
            totallitrefuel = f;
        }

        public int CalculatetotalPriceforFuel() //METHOD TO CALCULATE TOTAL PRICE FOR FUEL
        {
            int totalPriceFuel;

            totalPriceFuel = totallitrefuel * 3;

            return totalPriceFuel;
        }

        public int calculatetotalPrice()//METHOD TO CALCULATE TOTAL PRICE FOR ITEM AND FUEL
        {
            return totalPriceTransaction = totalitem + (totallitrefuel * 3);
 
        }

        public int CalculateconvertToPoint() //METHOD TO CALCULATE TOTAL POINT
        {
            int convertToPoint;

            convertToPoint = (totallitrefuel * 2)+(totalitem * 2);

            return convertToPoint;
        }
    }
}
