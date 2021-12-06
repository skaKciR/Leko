using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR0Moroz
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainTable());
        }
    }
    static class Order
    {
       
        public static string customersurname;
        public static string Customersurname { get { return customersurname; } set { customersurname = value; } }
        public static int onumber;
        public static int ONumber { get { return onumber; } set { onumber = value; } }
        public static string productname;
        public static string ProductName { get { return productname; } set { productname = value; } }
        public static DateTime date1;
        public static DateTime Date1 { get { return date1; } set { date1 = value; } }
        public static DateTime date2;
        public static DateTime Date2 { get { return date2; } set { date2 = value; } }
        public static string mastersurname;
        public static string Mastersurname { get { return mastersurname; } set { mastersurname = value; } }
        public static int cost;
        public static int Cost { get { return cost; } set { cost = value; } }
        static Order()
        {   
            Customersurname = customersurname;
            ONumber = onumber;
            ProductName = productname;
            Date1 = date1;
            Date2 = date2;
            Mastersurname = mastersurname;
            Cost = cost;
        }
    }
}
