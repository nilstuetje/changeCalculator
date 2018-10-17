using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Programm to calculate the specific coins to give back 
    /// </summary>
    public class Program
    {
        //available coin types saved i nconstant array to make changing easyer
        private static readonly double[] const_arr_coins = new double[] { 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

        static void Main(string[] args)
        {            
            //loop to make the program repeat
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine();
                //variables for price, money given, available coins and 
                double doub_price = 0;
                double doub_given = 0;
                int[] available_coins = new int[const_arr_coins.Length];
                int[] arr_change = new int[const_arr_coins.Length];

                //reading in Values
                Console.WriteLine("Geben sie den Preis ein:");
                doub_price = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine();
                Console.WriteLine("Geben sie das gegebene Geld ein:");
                doub_given = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine();

                for (int i = 0; i < const_arr_coins.Length; i++)
                {
                    Console.WriteLine("Wie viele " + const_arr_coins[i] + " euro Stuecke sind vorhanden?");
                    available_coins[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();

                //calling  Calc_coins to calculate the used coins storing the result in
                arr_change = Calc_Coins(doub_price, doub_given, available_coins);

                //if arr_change is null the calculation failed to find a suitable change otherwise outputs the amount of coins given back
                if (arr_change == null)
                {
                    Console.WriteLine("Kein Wechsel moeglich");
                }
                else
                {
                    Console.WriteLine("Wechselgeld:");
                    for(int i = 0; i < const_arr_coins.Length; i++)
                    {
                        //if arr_change[i] is zero ther are no coins of that type to return
                        if (arr_change[i] != 0)
                        {
                            Console.WriteLine(arr_change[i] + "x " + const_arr_coins[i].ToString("0.00") + " Euro");
                        }
                    }
                }
                
                Console.WriteLine("Weiter?(j)");

                if (Console.ReadKey().KeyChar != 'j')
                {
                    repeat = false;
                }
                
            }
        }

        /// <summary>
        /// helper function to calculate which coins are given back
        /// </summary>
        /// <param name="price">total price paid</param>
        /// <param name="given">amount of money given</param>
        /// <param name="avail_coins">coins available in the register</param>
        /// <returns>array of coin amounts indicated by constant global coin type array, returns null if no full change is possible</returns>
        public static int[] Calc_Coins(double price, double given, int[] avail_coins)
        {
            //array to return  number of coins
            int[] arr_return = new int[const_arr_coins.Length];

            //checking agains zero values
            if (price <= 0 || given <= 0)
            {
                Console.WriteLine("Geben sie alle werte ein");
                return null;
            }
            else if (price > given)
            {
                Console.WriteLine("Es wurde nicht genug bezahlt");
                return null;
            }
            else
            {
                //double to hold the remaining change
                double remaining_change = given - price;

                //calculation loop for coin numer and updating remaining change
                for (int i = 0; i < const_arr_coins.Length; i++)
                {
                    //rounding remaining change since float division can return unexpected results
                    remaining_change = Math.Round(remaining_change, 2);

                    arr_return[i] = Convert.ToInt32(Math.Floor(remaining_change / const_arr_coins[i]));

                    //checking if coins are available
                    if (arr_return[i] > avail_coins[i])
                    {
                        arr_return[i] = avail_coins[i];
                    }

                    remaining_change -= Convert.ToDouble(arr_return[i] * const_arr_coins[i]);

                }

                //debug code remove later
                foreach (int i in arr_return)
                {
                    Console.WriteLine(Convert.ToString(i));
                }

                //checking if change remains and returnign nullif any is left, otherwise an array containing the amounts of coins
                if (remaining_change == 0)
                {
                    return arr_return;
                }
                else
                {
                    return null;
                }
            }


        }




    }
}
