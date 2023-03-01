﻿using System;

namespace Operators_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integers");
            // Starts an integer that multipies two integers
            int intMult = 6 * 45;
            // Initialized an integer that adds to integers
            int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
                Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");
            
            // Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult if greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");

            Console.WriteLine("Shorts");
            // Starts an short that multipies two shorts
            short shortMult = 6 * 45;
            // Initialized an short that adds to shorts
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}. " +
            $"The min of the two is {Math.Min(shortMult, shortAdd)}.");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            // Prints if shortMult if greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");


            Console.WriteLine("Longs");
            // Starts an long that multipies two long
            long longMult = 6 * 45;
            // Initialized an long that adds to long
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}. " +
            $"The min of the two is {Math.Min(longMult, longAdd)}.");

            // Initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult if greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");


            Console.WriteLine("Floats");
            // Starts an float that multipies two float
            float floatMult = 6.6f * 45.75f;
            // Initialized an float that adds to float
            float floatAdd = 55.61f + 66.95f;
            // Prints the maximum and minimum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}. " +
            $"The min of the two is {Math.Min(floatMult, floatAdd)}.");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult if greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");


            Console.WriteLine("Doubles");
            // Starts an double that multipies two double
            double doubleMult = 6.51 * 45.72;
            // Initialized an double that adds to double
            double doubleAdd = 55.61 + 66.26;
            // Prints the maximum and minimum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}. " +
            $"The min of the two is {Math.Min(doubleMult, doubleAdd)}.");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            // Prints if doubleMult if greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");


            Console.WriteLine("Decimals");
            // Starts an decimal that multipies two decimal
            decimal decimalMult = (decimal)(6.51 * 45.74);
            // Initialized an decimaleger that adds to decimal
            decimal decimalAdd = (decimal)(55.23 + 66.45);
            // Prints the maximum and minimum of the two decimal variables
                Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}. " +
                $"The min of the two is {Math.Min(decimalMult, decimalAdd)}.");
            
            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            // Prints if decimalMult if greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.\n");
        }
    }
}
