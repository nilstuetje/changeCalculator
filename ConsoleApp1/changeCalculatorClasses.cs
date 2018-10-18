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
        public int TwentyCent { get; set; }
        public int TenCent { get; set; }
        public int FiveCent { get; set; }
        public int TwoCent { get; set; }
        public int SingleCent { get; set; }

        public decimal Price { get; set; }
        public decimal Given { get; set; }


        /// <summary>
        /// constructor to create and empty ChangeCalculatorInput object for later assignment of values
        /// </summary>
        public ChangeCalculatorInput()
        {

        }

        /// <summary>
        /// constructor to generate a object off ChangeCalculatorInput in one line
        /// </summary>
        /// <param name="euroOne">the amount of 1 euro pieces</param>
        /// <param name="fiftyCent">the amount of 50 cent pieces</param>
        /// <param name="twentyCent">the amount of twenty cent pieces</param>
        /// <param name="tencent">the amount of ten cent pieces</param>
        /// <param name="fiveCent">the amount of five cent pieces</param>
        /// <param name="twoCent">the amount of 2 cent pieces</param>
        /// <param name="singleCent">the amount of one cent pieces</param>
        /// <param name="price">the total price to be paid</param>
        /// <param name="given">the amount of money given by the customer</param>
        public ChangeCalculatorInput(int euroOne, int fiftyCent, int twentyCent,int tenCent, int fiveCent, int twoCent, int singleCent, 
            decimal price, decimal given)
        {
            EuroOne = euroOne;
            FiftyCent = fiftyCent;
            TwentyCent = twentyCent;
            TenCent = tenCent;
            FiveCent = fiveCent;
            TwoCent = twoCent;
            SingleCent = singleCent;

            Price = price;
            Given = given;
        }
    }


    

    /// <summary>
    /// class handling all the calculations
    /// </summary>
    public class ChangeCalculatorCalc
    {    
        private static decimal RemainingChange { get; set; }

        /// <summary>
        /// methode that does all the calculation storing the results in a ChangeCalculatorOuput object
        /// </summary>
        /// <param name="calcInput">the ChangeCalculatorInput Class storing all the the Inputs</param>
        /// <returns>returns a ChangeCalculatorOutput instance holding all the Outputs</returns>
        public static ChangeCalculatorOutput Calculate(ChangeCalculatorInput calcInput)
        {
            //intitial Calculation of remainingChange, creating a ChangeCalculatorOuput object to return
            RemainingChange = calcInput.Given - calcInput.Price;
            ChangeCalculatorOutput calcOut = new ChangeCalculatorOutput();

            //checking if price is less or equal to given before doing any calculations
            if(calcInput.Price <= calcInput.Given)
            {
                calcOut.CanChange = true;
            }

            //calling UpdateCoinCount 7 times with the appropiate parameters for each coin
            if (calcOut.CanChange)
            {
                calcOut.EuroOne = UpdateCoinCount(calcInput.EuroOne, 1m);
                calcOut.FiftyCent = UpdateCoinCount(calcInput.FiftyCent, 0.5m);
                calcOut.TwentyCent = UpdateCoinCount(calcInput.TwentyCent, 0.2m);
                calcOut.TenCent = UpdateCoinCount(calcInput.TenCent, 0.1m);
                calcOut.FiveCent = UpdateCoinCount(calcInput.FiveCent, 0.05m);
                calcOut.TwoCent = UpdateCoinCount(calcInput.TwoCent, 0.02m);
                calcOut.SingleCent = UpdateCoinCount(calcInput.SingleCent, 0.01m);
            }

            //chckign if any change remains
            if(RemainingChange > 0)
            {
                calcOut.CanChange = false;
            }

            return calcOut;

        }

        /// <summary>
        ///helper methode that returns the amount of coins for each coin type and updates remainingChange (this code would repeat 7 times)
        /// </summary>
        /// <param name="availCoin">how much coins of that type are available</param>
        /// <param name="fieldToUpdate">the field thats beeing updated</param>
        /// <param name="coinValue">the Value of the coin</param>
        private static int UpdateCoinCount(int availCoin, decimal coinValue)
        {
            //checking if the coind count would exceed the amount of available coins and returning the max amount if it is the case
            if (RemainingChange / coinValue > availCoin)
            {
                RemainingChange -= (coinValue * availCoin);
                return availCoin;
            }
            else
            {
                //calculating the amoutn of coins saving it in a variable to update remainingChange using modulo before leaving the methode
                int returnValue = (int)(RemainingChange / coinValue);
                RemainingChange %= coinValue;
                return returnValue;
            }
        }

    }




    /// <summary>
    /// class saving all the output
    /// </summary>
    public class ChangeCalculatorOutput
    {
        //fields holding th e count of coins to give the customer
        public int EuroOne { get; set; }
        public int FiftyCent { get; set; }
        public int TwentyCent { get; set; }
        public int TenCent { get; set; }
        public int FiveCent { get; set; }
        public int TwoCent { get; set; }
        public int SingleCent { get; set; }

        //field that saves if a change is possible
        public bool CanChange { get; set; }      
               
        
        }
    }

