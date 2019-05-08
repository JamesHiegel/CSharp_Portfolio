// SOURCE: https://www.w3resource.com/csharp-exercises/conditional-statement/csharp-conditional-statement-exercise-18.php
// AUTHOR: W3 Resource
// FILENAME: ElectricityBill.cs
// PURPOSE: C# program to calculate and print the Electricity bill of a given customer.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Renamed variables to be clearer on what they are.
// Replaced Convert with TryParse.

using System;

namespace JJH
{
    public class ElectricityBill
    {
        static void Main(string[] args)
        {
            int customerId = 0,
                unitsConsumed = 0;
            double chargePerUnit = 0, 
                surCharge = 0, 
                grossBill = 0, 
                netBill = 0;
            string customerName;

            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            // collects customer ID from user
            Console.Write("Input Customer ID: ");
            int.TryParse(Console.ReadLine(), out customerId);

            // collects customer name
            Console.Write("Input the name of the customer: ");
            customerName = Console.ReadLine();

            // collects units of electricity consumed
            Console.Write("Input the unit consumed by the customer: ");
            int.TryParse(Console.ReadLine(), out unitsConsumed);

            // sets chargePerUnit based upon about of units used
            if (unitsConsumed < 200)
                chargePerUnit = 1.20;
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
                chargePerUnit = 1.50;
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
                chargePerUnit = 1.80;
            else
                chargePerUnit = 2.00;

            // calculates gross bill
            grossBill = unitsConsumed * chargePerUnit;

            // applies surcharge if bill exceeds threshold
            if (grossBill > 300)
                surCharge = grossBill * 15 / 100.0;
            
            // calculates net bill and ensure minimal bill of 100
            netBill = grossBill + surCharge;
            if (netBill < 100)
                netBill = 100;

            // displays bill
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer Id Number                  :{0}\n", customerId);
            Console.Write("Customer Name                       :{0}\n", customerName);
            Console.Write("unit Consumed                       :{0}\n", unitsConsumed);
            Console.Write("Amount Charges @Rs. {0}  per unit   :{1}\n", chargePerUnit, grossBill);
            Console.Write("Surchage Amount                     :{0}\n", surCharge);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", netBill);
        }
    }
}