﻿namespace Sum_Even_Numbers;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] lenght = new int[numbers.Length];
        int sum = 0;

        for(int i = 0; i<lenght.Length;i++)
        {
            if (numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
        }
        Console.WriteLine(sum);
    }
}

