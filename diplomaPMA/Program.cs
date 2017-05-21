using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomaPMA
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
            Application.Run(new Form1());
        }
    }
    static class Data
    {
        public static string combobox1CalculateValue { get; set; }
        public static int wetnessParamInt { get; set; }
        public static float Costs { get; set; }
        public static int chystkaParamInt { get; set; }
        public static int zberParamInt{ get; set; }
        public static string combobox6CalculateValue { get; set; }
        public static string combobox7CalculateValue { get; set; }
        public static string combobox8CalculateValue { get; set; }
        public static string combobox9CalculateValue { get; set; }
        public static string combobox10CalculateValue { get; set; }
        public static string combobox11CalculateValue { get; set; }
    }
}
