using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers game!");
            StartSequence();
        }

        public static void StartSequence()
        {
            Console.Write("Enter a number greater than 0!");
            string userNumber = Console.ReadLine();
            int usIn = Convert.ToInt32(userNumber);

            int[] newArr = new int[usIn];
            //Start calling the Methods and capture their values
            int[] popArray = Populate(newArr);
            int arrSum = GetSum(popArray);
            //int product = GetProduct(newArr, arrSum);
            //int quotient = GetQuotient(product);
            Console.WriteLine($"Your array size is {userNumber}");
            Console.WriteLine($"The numbers in the Array are: ", string.Join(", ", popArray));
            Console.WriteLine($"The sum of the array elements is {arrSum}");    
            //Console.WriteLine(product);
            //Console.WriteLine(quotient);


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
            try
            {
                Console.WriteLine("Good number!");
            }
            catch
            {
                if(sum < 20)
                {
                    throw new Exception($"Value of { sum } is too low");
                }
            }
                return sum;
        }
    }
}
