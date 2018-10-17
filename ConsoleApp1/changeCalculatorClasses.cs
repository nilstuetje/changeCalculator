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
        public int EuroOne { get;  }
        public int FiftyCent { get;  }
        public int TwntyCent { get;  }
        public int TenCent { get;  }
        public int FiveCent { get;  }
        public int TwoCent { get;  }
        public int SingleCent { get;  }

        public decimal Price { get; set; }
        public decimal Given { get; set; }

        public ChangeCalculatorInput()
        {
            //reading in values
            Console.WriteLine("Geben sie den Preis ein: ");
            Price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Geben sie ein wiviel Geld gegeben wurde: ");
            Given = Convert.ToDecimal(Console.ReadLine());

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
        private int EuroOneAvail  = 0;
        private int FiftyCentAvail  = 0;
        private int TwentyCentAvail  = 0;
        private int TenCentAvail  = 0;
        private int FiveCentAvail  = 0;
        private int TwoCentAvail  = 0;
        private int SingleCentAvail  = 0;

        //field that hold the leftover change
        private decimal remainingChange = 0;

        //fields to hold the calculated change
        public int EuroOne { get; set; } = 0;
        public int FiftyCent { get; set; } = 0;
        public int TwentyCent { get; set; } = 0;
        public int TenCent { get; set; } = 0;
        public int FiveCent { get; set; } = 0;
        public int TwoCent { get; set; } = 0;
        public int SingleCent { get; set; } = 0;

        
        //bool to pass back if the calculation failed
        public bool CanChange { get; } = true;

        public ChangeCalculatorCalc(ChangeCalculatorInput input)
        {
            EuroOneAvail = input.EuroOne;
            FiftyCentAvail = input.FiftyCent;
            TwentyCentAvail = input.TwntyCent;
            TenCentAvail = input.TenCent;
            FiveCentAvail = input.FiveCent;
            TwoCentAvail = input.TwoCent;
            SingleCentAvail = input.SingleCent;

            Calculate(input.Price, input.Given);
        }

        /// <summary>
        /// helper methode that does all the calculation storing the results in public fields
        /// </summary>
        /// <param name="price">the price to be paid</param>
        /// <param name="given">the amount of money given by the customer</param>
        private void Calculate(decimal price, decimal given)
        {
            //intitial Calculation of remainingChange
            remainingChange = given - price;

            //calling UpdateCoinCount 7 times with the appropiate parameters for each coin
            UpdateCoinCount(EuroOneAvail, EuroOne, 1m);
            UpdateCoinCount(FiftyCentAvail, FiftyCent, 0.5m);
            UpdateCoinCount(TwentyCentAvail, TwentyCent, 0.2m);
            UpdateCoinCount(TenCentAvail, TenCent, 0.1m);
            UpdateCoinCount(FiveCentAvail, FiveCent, 0.05m);
            UpdateCoinCount(TwoCentAvail, TwoCent, 0.02m);
            UpdateCoinCount(SingleCentAvail, SingleCent, 0.01m);


        }

        /// <summary>
        /// methode that updates the public fields holding the amount of each coin (this code would repeat 7 times)
        /// </summary>
        /// <param name="availCoin">how much coins of that type are available</param>
        /// <param name="fieldToUpdate">the field thats beeing updated</param>
        /// <param name="coinValue">the Value of the coin</param>
        private void UpdateCoinCount(int availCoin, object fieldToUpdate, decimal coinValue)
        {

            if (remainingChange / coinValue > availCoin)
            {
                fieldToUpdate = availCoin;
            }
            else
            {
                fieldToUpdate = (int)remainingChange / coinValue;
                remainingChange %= coinValue;
            }
        }

    }


}