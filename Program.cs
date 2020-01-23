using System;

namespace sprint3sortnumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an Array
            int[] numbers = new int[10] {10,4,5,7,3,5,8,2,1,9};

            //user the Array api and sort your numbers
            Array.Sort(numbers);

            //loop through the numbers and print them to the screen in order
            foreach(int val in numbers)
            {
                Console.WriteLine(val + " ");
            }

            Console.ReadKey();
        }
    }
}
