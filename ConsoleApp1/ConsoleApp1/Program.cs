using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers game!");
            Console.WriteLine("Hello World!");
            StartSequence();
        }

        public static void StartSequence()
        {
            Console.Write("Enter a number greater than 0!");
            string userNumber = Console.ReadLine();
            int usIn = Convert.ToInt32(userNumber);

            int[] newArr = new int[usIn];

            //Start calling the Methods and capture their values
            Populate(newArr);
            int sum = GetSum(newArr);
            int product = GetProduct(newArr, sum);
            int quotient = GetQuotient(product);
            Console.WriteLine($"Your array size is {userNumber}");
            Console.WriteLine($"The numbers in the Array are: ", string.Join(", ", newArr));
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(quotient);

        }

        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            return arr;
        }
    }
}
