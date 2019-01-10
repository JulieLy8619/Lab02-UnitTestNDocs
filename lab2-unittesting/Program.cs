﻿using System;

namespace lab2_unittesting
{
    public class Program // added public so can call it in the test environment
    {
        public static double balance = 5000.00;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Special Unicorn ATM");
            bool running = true;
            do
            {
                MenuSelection();
            } while (running); //I am ok with that I don't reset to false at any point becasuse exit will exit the program
            Console.ReadLine(); //so it doesn't auto exit
        }

        private static void ViewBalance(double balance)
        {
            Console.WriteLine($"Your balance is {balance}");
        }

        public static double Deposit(double balance)
        {
            Console.WriteLine("How much are you depositing");
            string userAmt = Console.ReadLine();
            double depositAmt = Convert.ToDouble(userAmt);
            balance = balance + depositAmt;
            return balance;
        }

        public static double Withdrawl(double balance)
        {
            Console.WriteLine("How much are you withdrawing?");
            string userAmt = Console.ReadLine();
            double withdrawlAmt = Convert.ToDouble(userAmt);
            balance = balance - withdrawlAmt;
            return balance;
        }


        public static void MenuSelection()
        {
            Console.WriteLine("Make a selection");
            Console.WriteLine("1: Check your Balance");
            Console.WriteLine("2: Make a Deposit");
            Console.WriteLine("3: Make a Withdrawl");
            Console.WriteLine("4: Exit");
            string userChoice = Console.ReadLine();
            int userChoiceInt = Convert.ToInt32(userChoice);
            switch (userChoiceInt)
            {
                case 1: //balance
                    ViewBalance(balance);
                    break;
                case 2: // deposit
                    balance = Deposit(balance);
                    ViewBalance(balance);
                    break;
                case 3: // withdrawal
                    balance = Withdrawl(balance);
                    ViewBalance(balance);
                    break;
                default: // exit
                    Environment.Exit(0);
                    break;
            }
        }


    }
}
