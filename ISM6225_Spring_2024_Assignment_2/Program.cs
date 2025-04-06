﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Question 1: Find Missing Numbers in Array
            // Console.WriteLine("Question 1:");
            // int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            // IList<int> missingNumbers = FindMissingNumbers(nums1);
            // Console.WriteLine(string.Join(",", missingNumbers));

            // // Question 2: Sort Array by Parity
            // Console.WriteLine("Question 2:");
            // int[] nums2 = { 3, 1, 2, 4 };
            // int[] sortedArray = SortArrayByParity(nums2);
            // Console.WriteLine(string.Join(",", sortedArray));

            // // Question 3: Two Sum
            // Console.WriteLine("Question 3:");
            // int[] nums3 = { 2, 7, 11, 15 };
            // int target = 9;
            // int[] indices = TwoSum(nums3, target);
            // Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // // Question 5: Decimal to Binary Conversion
            // Console.WriteLine("Question 5:");
            // int decimalNumber = 42;
            // string binary = DecimalToBinary(decimalNumber);
            // Console.WriteLine(binary);

            // // Question 6: Find Minimum in Rotated Sorted Array
            // Console.WriteLine("Question 6:");
            // int[] nums5 = { 3, 4, 5, 1, 2 };
            // int minElement = FindMin(nums5);
            // Console.WriteLine(minElement);

            // // Question 7: Palindrome Number
            // Console.WriteLine("Question 7:");
            // int palindromeNumber = 121;
            // bool isPalindrome = IsPalindrome(palindromeNumber);
            // Console.WriteLine(isPalindrome);

            // // Question 8: Fibonacci Number
            // Console.WriteLine("Question 8:");
            // int n = 4;
            // int fibonacciNumber = Fibonacci(n);
            // Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                int[] tempArray = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0 && nums[i] <= tempArray.Length)
                    {
                        tempArray[nums[i] - 1] = 1;
                    }
                }
                List<int> missingNumbers = new List<int>();
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (tempArray[i] == 0)
                    {
                        missingNumbers.Add(i + 1);
                    }
                }
                return missingNumbers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                List<int> evenIndex = new List<int>();
                List<int> oddIndex = new List<int>();

                // Separate numbers into even and odd lists
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        evenIndex.Add(nums[i]);
                    }
                    else
                    {
                        oddIndex.Add(nums[i]);
                    }
                }
                // Combine even and odd lists
                return evenIndex.Concat(oddIndex).ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                int x;
                int y;
                List<int> result= new List <int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            x = i;
                            y = j;
                            result.Add(x);
                            result.Add(y);
                        }
                    }
                }
                return result.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                int x,y,z;
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        for (int k = 0; k < nums.Length; k++)
                        {
                            if (i != j && i != k && j != k)
                            {
                                if()
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                return "101010"; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Write your code here
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                return false; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Write your code here
                return 0; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
