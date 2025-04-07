using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            //int[] nums1 = { 1, 2, 3, 4, 5 }; //edgecase1
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            //int[] nums2 = { 2, 4, 6, 8 }; //edgecase1 Only Even Numbers
            //int[] nums2 = { 1, 3, 5, 7 }; //edgecase2 Only ODD Numbers
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            //edge case1
            //int[] nums3 = { 4 };
            //int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            //int[] nums4 = { -10, -10, -1, -3, -76 };//edge case1 all negative
            //int[] nums4 = { -10, -10, 5, 2 };//edge case2 mix
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            //int decimalNumber = 1;//edgecase1
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
                // Write your code here
                
                for (int i = 0; i < nums.Length; i++)
                {
                    int index = Math.Abs(nums[i]) - 1;
                    if (nums[index] > 0)
                    {
                        nums[index] = -nums[index]; // Mark this number as seen by negating it
                    }
                }

                
                List<int> result = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        result.Add(i + 1); // because index+1 is the missing number
                    }
                }

                return result;



                //return new List<int>(); // Placeholder
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
                // Write your code here
                int evenIndex = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        // Swap nums[i] with nums[evenIndex]
                        int temp = nums[i];
                        nums[i] = nums[evenIndex];
                        nums[evenIndex] = temp;
                        evenIndex++;
                    }
                }
                return nums;


                //return new int[0]; // Placeholder
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
                // Write your code here
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j }; // Return the indices of the pair
                        }
                    }
                }

                // Return an empty array if no solution is found
                return new int[] { };
                //return new int[0]; // Placeholder
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
                // Write your code here
                Array.Sort(nums);
                int n = nums.Length;
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]);

                //return 0; // Placeholder
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
                // Handle edge case for negative numbers
                if (decimalNumber < 0)
                {
                    return "Its Negative, please enter a positive number";
                }
                // Handle edge case for zero
                if (decimalNumber == 0)
                {
                    return "0";
                }

                string binary = "";
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binary = remainder + binary; 
                    decimalNumber /= 2;
                }

                return binary;

                //return "101010"; // Placeholder
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
