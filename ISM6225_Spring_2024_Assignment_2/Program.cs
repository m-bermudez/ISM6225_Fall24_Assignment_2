using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                if (nums.Length < 2 || nums == null || nums.Length == 0)
                {
                    throw new ArgumentException("Array must contain at least two elements and array cannot be null or empty.");
                }
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
                if (nums.Length < 2 || nums == null || nums.Length == 0)
                {
                    throw new ArgumentException("Array must contain at least two elements and array cannot be null or empty.");
                }
                List<int> evenIndex = new List<int>();
                List<int> oddIndex = new List<int>();
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
                if (nums.Length < 2 || nums == null || nums.Length == 0 || target < 0)
                {
                    throw new ArgumentException("Array must contain at least two elements, target must be non-negative, array cannot be null or empty.");
                }
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
                if (nums.Length < 3)
                {
                    throw new ArgumentException("Array must contain at least three elements.");
                }
                int max1 = int.MinValue, max2 = int.MinValue, max3 = int.MinValue;
                foreach (int num in nums)
                {
                    if (num > max1)
                    {
                        max3 = max2;
                        max2 = max1;
                        max1 = num;
                    }
                    else if (num > max2)
                    {
                        max3 = max2;
                        max2 = num;
                    }
                    else if (num > max3)
                    {
                        max3 = num;
                    }
                }
                return max1 * max2 * max3;
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
                if (decimalNumber < 0) 
                {
                    throw new ArgumentException("Decimal number must be non-negative.");
                }
                string binary = Convert.ToString(decimalNumber, 2);
                return binary;
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
                if (nums.Length < 1 || nums == null || nums.Length == 0)
                {
                    throw new ArgumentException("Array must contain at least one element and array cannot be null or empty.");
                }
                int minimum = nums[0];
                foreach (int num in nums)
                {
                    if (num < minimum)
                    {
                        minimum = num;
                    }
                }
                return minimum;
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
                string str = x.ToString();
                char[] charArray = str.ToCharArray();
                char[] reversedArray = charArray.Reverse().ToArray();

                if (charArray[0] == reversedArray[0])
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
                if (n < 0)
                {
                    throw new ArgumentException("Input must be a non-negative integer.");
                }
                else if (n == 0)
                {
                    return 0;
                }
                else if(n <= 2)
                {
                    return 1;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
