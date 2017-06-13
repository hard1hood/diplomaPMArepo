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
        public static double Costs { get; set; }
        public static int chystkaParamInt { get; set; }
        public static int zberParamInt{ get; set; }
        public static double sumPredictDouble { get; set; }
        public static int countInt { get; set; }
        public static double punkt3 { get; set; }
        public static double ur { get; set; }
        public static int lastYear { get; set; }
        public static double costsPrediction { get; set; }
        public static int zberPredInt { get; set; }
        public static int chystkaPredInt { get; set; }
    }
}
