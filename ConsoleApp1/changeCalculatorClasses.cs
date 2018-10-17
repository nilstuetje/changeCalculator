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
            Price = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Geben sie ein wiviel Geld gegeben wurde: ");
            Given = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

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
        public bool CanChange { get; set; } = true;

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
            CanChange = true;

            //calling UpdateCoinCount 7 times with the appropiate parameters for each coin
            EuroOne=UpdateCoinCount(EuroOneAvail, 1m);
            FiftyCent=UpdateCoinCount(FiftyCentAvail, 0.5m);
            TwentyCent=UpdateCoinCount(TwentyCentAvail, 0.2m);
            TenCent=UpdateCoinCount(TenCentAvail, 0.1m);
            FiveCent=UpdateCoinCount(FiveCentAvail, 0.05m);
            TwoCent=UpdateCoinCount(TwoCentAvail, 0.02m);
            SingleCent=UpdateCoinCount(SingleCentAvail, 0.01m);

            if(remainingChange > 0)
            {
                CanChange = false;
            }


        }

        /// <summary>
        /// methode that updates the public fields holding the amount of each coin (this code would repeat 7 times)
        /// </summary>
        /// <param name="availCoin">how much coins of that type are available</param>
        /// <param name="fieldToUpdate">the field thats beeing updated</param>
        /// <param name="coinValue">the Value of the coin</param>
        private int UpdateCoinCount(int availCoin, decimal coinValue)
        {
            //checking if the coind count would exceed the amount of available coins and returning the max amount if it is the case
            if (remainingChange / coinValue > availCoin)
            {
                return availCoin;
            }
            else
            {
                //calculating the amoutn of coins saving it in a variable to update remainingChange using modulo before leaving the methode
                int returnValue = (int)(remainingChange / coinValue);
                remainingChange %= coinValue;
                return returnValue;
            }
        }

    }


    /// <summary>
    /// class handling all the output
    /// </summary>
    public static class ChangeCalculatorOutput
    {
        /// <summary>
        /// methode printing change to console
        /// </summary>
        /// <param name="calc">ChangeCalculatot calc object that holds the calculated change</param>
        public static void OutputConsole(ChangeCalculatorCalc calc)
        {

            if (calc.CanChange)
            {

                Console.WriteLine("Wechselgeld: ");
                if (calc.EuroOne != 0)
                {
                    Console.WriteLine(calc.EuroOne + "x " + " 1.00 " + " Euro");
                }
                if (calc.FiftyCent != 0)
                {
                    Console.WriteLine(calc.FiftyCent + "x " + "50 " + " cent");
                }
                if (calc.TwentyCent != 0)
                {
                    Console.WriteLine(calc.TwentyCent + "x " + " 20 " + " cent");
                }
                if (calc.TenCent != 0)
                {
                    Console.WriteLine(calc.TenCent + "x " + " 10 " + " cent");
                }
                if (calc.FiveCent != 0)
                {
                    Console.WriteLine(calc.FiveCent + "x " + " 5 " + " cent");
                }
                if (calc.TwoCent != 0)
                {
                    Console.WriteLine(calc.TwoCent + "x " + " 2 " + " cent");
                }
                if (calc.SingleCent != 0)
                {
                    Console.WriteLine(calc.SingleCent + "x " + " 1 " + " cent");
                }
            }
            else
            {
                Console.WriteLine("Kein Wechsel Moeglich");
            }

            
        }
    }

}