using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInteger;
            int secondInteger;
            int numberToBeChecked1 = 0;
            int numberToBeChecked2 = 0;


            // Asking the user what integers they would like to use 
            // As long as the user inputs invalid fields, this code will repeat 
            while (numberToBeChecked1 <= 0 || numberToBeChecked2 <= 0)
            {
                System.Console.WriteLine("Enter the first integer: ");
                firstInteger = Convert.ToInt32(Console.ReadLine());
                numberToBeChecked1 = firstInteger;

                System.Console.WriteLine("Enter the second integer: ");
                secondInteger = Convert.ToInt32(Console.ReadLine());
                numberToBeChecked2 = secondInteger;
            }


            // Segment that checks what the user wants to do with the number he/she provided
            // As long as the user inputs invalid fields, this code will repeat 
            int userChoice = 0;
            if (userChoice != 1 || userChoice != 2 || userChoice != 3 || userChoice != 4)
            {
                System.Console.WriteLine("What operation would you like to perform with these integers?");
                System.Console.WriteLine("Press '1' for multiplication");
                System.Console.WriteLine("Press '2' for subtraction");
                System.Console.WriteLine("Press '3' for division ");
                System.Console.WriteLine("Press '4' for addition");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }

            // Segment of code that performs multiplication 
            int multResult;
            if (userChoice == 1)
            {
                multResult = numberToBeChecked1 * numberToBeChecked2;
                System.Console.WriteLine("{0} * {1} = {2}", numberToBeChecked1, numberToBeChecked2, multResult);
            }

            // Segment of code that performs subtraction
            int subtractResult;
            if (userChoice == 2)
            {
                subtractResult = numberToBeChecked1 - numberToBeChecked2;
                System.Console.WriteLine("{0} - {1} = {2}", numberToBeChecked1, numberToBeChecked2, subtractResult);
            }


            // Segment of code that performs division
            double divResult;
            if (userChoice == 3)
            {
                divResult = (double)numberToBeChecked1 / (double)numberToBeChecked2;
                System.Console.WriteLine("{0} / {1} = {2}", numberToBeChecked1, numberToBeChecked2, divResult);
            }

            // Segment of code that performs addition 
            int addResult;
            if (userChoice == 4)
            {
                addResult = numberToBeChecked1 + numberToBeChecked2;
                System.Console.WriteLine("{0} + {1} = {2}", numberToBeChecked1, numberToBeChecked2, addResult);
            }


        }


    }

}