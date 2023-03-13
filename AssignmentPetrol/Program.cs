using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AssignmentPetrol
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Menu());
        }

        public static string IDCard;
        public static string Name;
        public static string IC;
        public static int fuel;
        public static int pricelitre;
        public static int item;
        public static int totalTransaction;
        public static int payment;
        public static int balance;
        public static int CollectedPoint;
    }
}