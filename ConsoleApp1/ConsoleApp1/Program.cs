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

            int userNumber;
            userNumber = Convert.ToInt32(Console.ReadLine());
            int[] newArr = new int[userNumber];

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

        }
    }
}
