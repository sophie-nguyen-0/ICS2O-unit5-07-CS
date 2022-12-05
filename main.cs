// Created by: sophie
// Created on: dec 2020
//
// This program does loops and math

using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int sum = 0;

        Console.WriteLine("this program calculates the sum of n natural numbers");

        Console.Write("Enter a number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        for (int count = 1; count < num1 || count == num1; count++)
        {
            sum += count;
        }
        Console.WriteLine("your answer is: " + sum + ".");
        Console.WriteLine("\nDone.");
    }
}