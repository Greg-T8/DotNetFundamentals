﻿namespace AboutMyEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);
            Console.WriteLine("Value is {0}", 19.8);
        }
    }
}
