using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Basic 13!");
            // OneToTwoFifeFife();
            // OddsToTwoFifeFife();
            // PrintSum();
            int[] ahray = {1,3,41,5,7,9,13};
            // IterateAnArray(ahray);
            // FindMax(ahray);
            // GetAverage(ahray);
            // GreaterThanY(ahray);
            // ArrayWithOddsNumbers();
            object[] x = {1,5,10,-2};
            // SquareTheValues(x);
            // EliminateNegNumbers(x);
            // MaxMinAvg(x);
            // ShiftingVals(x);
            // NumberToString(x);
        }

        public static void OneToTwoFifeFife()
        {
            for(int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        public static void OddsToTwoFifeFife()
        {
            for(int i = 1; i <= 255; i++)
            {
                if(i %2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
        
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine("New Number: " + i);
                sum += i;
                System.Console.WriteLine("Here's the Sum Now: "+sum);
            }
        }
        public static void IterateAnArray(int[] arr)
        {
            for(int i = 0; i < arr.Length ; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 0; i < arr.Length ; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            System.Console.WriteLine("The MAX is: "+max);
        }

        public static void GetAverage(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int avg = sum/arr.Length;
            System.Console.WriteLine("The AVERAGE is: "+avg);
        }

        public static void GreaterThanY(int[] arr, int y = 3)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > y)
                {
                    count = count + 1;
                }
            }
            System.Console.WriteLine(count+" numbers are greater than Y");
        }

        public static void ArrayWithOddsNumbers()
        {
            List<int> Y = new List<int>();
            for(int i = 0; i < 255; i++)
            {
                if(i %2 == 1)
                {
                    Y.Add(i);
                }
            }
            foreach(int num in Y)
            {
                System.Console.WriteLine("* "+num);
            }
        }
        public static void SquareTheValues(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = arr[i]*arr[i];
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void EliminateNegNumbers(int[] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i]<0)
                {
                    arr[i] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }
        public static void MaxMinAvg(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
                sum = sum + arr[i];
            }
            int avg = sum/arr.Length;
            System.Console.WriteLine("max: "+max+" min: "+min+" avg: "+avg);
        }

        public static void ShiftingVals(int[] arr)
        {
            for(int i = 0; i<arr.Length-1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
                if(i == arr.Length-1)
                {
                    arr[arr.Length-1] = 0;
                }
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void NumberToString(object[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if((int)arr[i] < 0)
                {
                    arr[i] = "Dojo";
                }
                System.Console.WriteLine(arr[i]);
            }
        }
    }
}
