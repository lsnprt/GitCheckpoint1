﻿namespace GitCheckpoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");

            CheckTest.TestMessage("Task 2 checked");

            Console.WriteLine(Calculate.Sum(3, 2));
        }
    }
}