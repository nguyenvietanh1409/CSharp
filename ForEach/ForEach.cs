﻿using System;
class ForEach
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Random random = new Random((int)now.Millisecond);
        int[] Arr = new int[10];
        for(int x = 0; x < Arr.Length; ++x)
        {
            Arr[x] = random.Next(); % 100;
        }
        int Total = 0;
        Console.WriteLine("Array values are ");
        foreach(int val in Arr)
        {
            Total += val;
            Console.Write(val + ", ");
        }
        Console.WriteLine("\nAnd the average is {0,0:F1",(double)Total / (double)Arr.Length;
        Console.ReadLine();
    }
}