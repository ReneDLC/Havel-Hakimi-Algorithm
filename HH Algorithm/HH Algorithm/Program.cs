using System;
using System.Collections.Generic;
using System.Linq;

namespace HH_Algorithm
{
    class Program
    {
        public static Boolean Hakimi(int[] arr)
        {
            int n = 0;
            Array.Sort(arr);
            Array.Reverse(arr);
            while (arr[n] != 0)
            {
                //base case
                if (n > 0)
                {
                    Array.Sort(arr);
                    Array.Reverse(arr);
                }
                //find max
                int max = 0;
                for (int i = n; i < arr.Length - 1; i++)
                {
                    if (arr[i] > 0)
                        max++;
                }
                //fixes out of bounds
                int k = arr.Length - max;
                //subtract1
                if (k <= 1)
                {
                    int incr = n;
                    while (incr < max)
                    {
                        incr++;
                        arr[incr] = arr[incr] - 1;
                    }
                }
                if (k >= 2)
                {
                    int incr = n;
                    while (incr <= max)
                    {
                        incr++;
                        arr[incr] = arr[incr] - 1;
                    }
                }
                n++;
            }
            if (arr[n] == 0 && arr[n + 1] == 0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
