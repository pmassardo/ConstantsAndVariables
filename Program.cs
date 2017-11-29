/*
 * Author:  Alfred Massardo
 * Name:    ConstantsAndVariables
 * Date:    29-Nov-2017
 * 
 * Description: An application to demonstrate varriables and constants. This application uses variables and constants to do a simple interest calculation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declarations

            // Constants
            const double interestRate = 2.49;  // interest rate used to calculate the interest
            const int interestRateDenominator = 100;  // interest rate used to calculate the interest

            // Variables
            double loanPrinciple = 0.0;         // holds the amount of the loan the user enters
            double loanInterestAmount = 0.0;    // hold the total interest calculated
            double loanAndInterestAmount = 0.0;    // hold the total and interest combined
            string userInput = string.Empty;    // holds the user input 

            Console.Write("Please enter a loan amount: "); // ask the user for some input

            // What happens when you try and change a constant after it has been declared
            // Unremark the code below and try it.
            // What is the error message?
            //interestRateDenominator = 101;

            // get the user input from the keyboard
            // the user input comes into the program
            // as a string from the readline
            userInput = Console.ReadLine();

            // convert the string
            loanPrinciple = Convert.ToDouble(userInput);

            // multiply the loan principle variable 
            // by the interest rate constant
            loanInterestAmount = loanPrinciple * (interestRate / interestRateDenominator);

            // add the interest to the principle and 
            // assign it to the loanAndInterestAmount
            loanAndInterestAmount = loanInterestAmount + loanPrinciple;

            // Show the user the result
            Console.WriteLine("With a principle amount of {0:c2} \n\tat an interest rate of {1:n2}% \n\tthe interest would be {2:n2} \n\tfor a total loan of {3:c2} ...", loanPrinciple, interestRate, loanInterestAmount, loanAndInterestAmount);

            // ask the user to end the program
            Console.Write("Press any key to end the program...");

            // Pause the program until the user 
            // presses a key on the keyboard
            Console.ReadKey();

        }
    }
}
