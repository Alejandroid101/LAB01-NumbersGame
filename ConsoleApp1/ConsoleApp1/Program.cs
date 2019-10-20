using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers game!");
            try
            {
                StartSequence();
            }
            catch
            {
                Console.WriteLine("Seems like you did something wrong");
            }
            finally
            {
                Console.WriteLine("The program has been completed");
            }
        }

        public static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than 0:");
            string userNumber = Console.ReadLine();
            int usIn = Convert.ToInt32(userNumber);

            int[] newArr = new int[usIn];

            //Start calling the Methods and capture their values
            int[] popArray = Populate(newArr);
            int arrSum = GetSum(popArray);
            int product = GetProduct(newArr, arrSum);
            decimal quotient = GetQuotient(product);

            Console.WriteLine($"Your array size is {userNumber}");
            Console.WriteLine("The numbers in the Array are: {0}", string.Join(", ", popArray));
            Console.WriteLine($"The sum of the array elements is {arrSum}");    
            Console.WriteLine($"{arrSum} * {product/arrSum} = {product}");
            Console.WriteLine($"{product} / {quotient * 5} = {quotient}");


        }
        //This Method populates the Empty Array by iterating through it while the user inputs the new numbers
        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            return arr;
        }

        //Doing addition of the elements of the array. Exception added for when the sum is smaller than 20
        public static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Good number!");

            if(sum < 20)
            {
                throw new Exception($"Value of { sum } is too low");
            }
            return sum;
        }
        public static int GetProduct(int[] arr, int sum)
        {
            int product = 0;
            Console.WriteLine($"Select a number between 1 and {arr.Length}");
            string userNumber2 = Console.ReadLine();
            int usIn2 = Convert.ToInt32(userNumber2);

            try
            {
                if (usIn2 <= arr.Length)
                {
                    product = sum * arr[usIn2 - 1];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                throw e; 
            }
            return product;
        }
        public static decimal GetQuotient(decimal prod)
        {
            int quotient = 0;
            Console.WriteLine($"Select a number to divide your product ({prod}) by");
            string userNumber3 = Console.ReadLine();
            decimal usIn3 = Convert.ToInt32(userNumber3);

            try
            {
                decimal quo = decimal.Divide(prod, usIn3);
                return quo;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException Handler: {e}");
            }
            return quotient;
        }
    }
}
