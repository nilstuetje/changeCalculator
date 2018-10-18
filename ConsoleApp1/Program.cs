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
            //instancing ChangeCalculatorInput
            ChangeCalculatorInput calcIn = new ChangeCalculatorInput();
            ChangeCalculatorOutput calcOut = new ChangeCalculatorOutput();

            //loop to make the program repeat
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine();



                //reading all the values and storing them in the ChangeCalculatorInput Object
                #region ReadInput

                Console.WriteLine("Geben sie den Preis ein: ");
                calcIn.Price = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

                Console.WriteLine("Geben sie ein, wieviel Geld gegeben wurde: ");
                calcIn.Given = Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

                Console.WriteLine("Geben sie die Menge an vorhandenen 1 euro Stuecken ein:  ");
                calcIn.EuroOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 50 cent Stuecken ein:  ");
                calcIn.FiftyCent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 20 cent Stuecken ein:  ");
                calcIn.TwentyCent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 10 cent Stuecken ein:  ");
                calcIn.TenCent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 5 cent Stuecken ein:  ");
                calcIn.FiveCent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 2 cent Stuecken ein:  ");
                calcIn.TwoCent = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie die Menge an vorhandenen 1 cent Stuecken ein:  ");
                calcIn.SingleCent = Convert.ToInt32(Console.ReadLine());

                #endregion


                //using the static class ChangeCalculatorCalc to calculate the change and save it in the ChangeCalculateOutput instance
                calcOut = ChangeCalculatorCalc.Calculate(calcIn);

                //OUputing the values saved in the ChangeCalculatorOutput instance, skipping coinamounts that are 0 or evrything if canChange is false
                #region Output coinamounts

                if (calcOut.CanChange)
                {
                    Console.WriteLine("Wechselgeld: ");
                    if (calcOut.EuroOne != 0)
                    {
                        Console.WriteLine(calcOut.EuroOne + "x " + " 1.00 " + " Euro");
                    }
                    if (calcOut.FiftyCent != 0)
                    {
                        Console.WriteLine(calcOut.FiftyCent + "x " + "50 " + " cent");
                    }
                    if (calcOut.TwentyCent != 0)
                    {
                        Console.WriteLine(calcOut.TwentyCent + "x " + " 20 " + " cent");
                    }
                    if (calcOut.TenCent != 0)
                    {
                        Console.WriteLine(calcOut.TenCent + "x " + " 10 " + " cent");
                    }
                    if (calcOut.FiveCent != 0)
                    {
                        Console.WriteLine(calcOut.FiveCent + "x " + " 5 " + " cent");
                    }
                    if (calcOut.TwoCent != 0)
                    {
                        Console.WriteLine(calcOut.TwoCent + "x " + " 2 " + " cent");
                    }
                    if (calcOut.SingleCent != 0)
                    {
                        Console.WriteLine(calcOut.SingleCent + "x " + " 1 " + " cent");
                    }
                }
                else
                {
                    Console.WriteLine("Kein Wechsel Moeglich");
                }

                #endregion


                //asking user if he wants to run again and closing if not
                Console.WriteLine("Weiter?(j)");

                if (Console.ReadKey().KeyChar != 'j')
                {
                    repeat = false;
                }



            }


        }
    }
}
