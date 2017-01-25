﻿using System;

namespace _01.Blank_Receipt
{
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
