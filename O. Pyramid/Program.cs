﻿internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);
        
        for(int i = 1; i <= number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}