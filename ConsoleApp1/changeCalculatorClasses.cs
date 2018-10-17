using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /// <summary>
    /// class handling all the input
    /// </summary>
    public class ChangeCalculatorInput
    {
        public int EuroOne { get; set; }
        public int FiftyCent { get; set; }
        public int TwntyCent { get; set; }
        public int TenCent { get; set; }
        public int FiveCent { get; set; }
        public int TwoCent { get; set; }
        public int SingleCent { get; set; }

        public double Price { get; set; }
        public double Given { get; set; }

        public ChangeCalculatorInput()
        {
            //reading in values
            Console.WriteLine("Geben sie den Preis ein: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie ein wiviel Geld gegeben wurde: ");
            Given = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wieviel 1 euro stuecke sind vorhanden?");
            EuroOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 50 cent stuecke sind vorhanden?");
            FiftyCent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 20 cent stuecke sind vorhanden?");
            TwntyCent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 10 cent stuecke sind vorhanden?");
            TenCent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 5 cent stuecke sind vorhanden?");
            FiveCent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 2 cent stuecke sind vorhanden?");
            TwoCent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wieviel 1 cent stuecke sind vorhanden?");
            SingleCent = Convert.ToInt32(Console.ReadLine());

        }
    }

    /// <summary>
    /// class handling all the calculations
    /// </summary>
    public class ChangeCalculatorCalc
    {
        //fields to hold the amount of coins
        public int EuroOne { get; set; } = 0;
        public int FiftyCent { get; set; } = 0;
        public int TwntyCent { get; set; } = 0;
        public int TenCent { get; set; } = 0;
        public int FiveCent { get; set; } = 0;
        public int TwoCent { get; set; } = 0;
        public int SingleCent { get; set; } = 0;

        //bool to pass back if the calculation failed
        public bool CanChange { get; } = true;

        public ChangeCalculatorCalc(ChangeCalculatorInput input)
        {
            EuroOne = input.EuroOne;
            FiftyCent = input.FiftyCent;
            TwntyCent = input.TwntyCent;
            TenCent = input.TenCent;
            FiveCent = input.FiveCent;
            TwoCent = input.TwoCent;
            SingleCent = input.SingleCent;
        }

        public void Calculate(double price, double given)
        {
            
        }

    }


}