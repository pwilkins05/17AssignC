using System;

namespace ConsoleApp
{
    class DevinsBugApp
    {

        //This application should tell you which numbers in the array reach a sum.
        static void Main(string[] args)
        {
            //Numbers in the array must be in order from smallest to largest
            int[] numbers = { 8, 1, 4, 6, 2 };
            int sum = 12;

            int start = 0;
            int finish = numbers.Length - 1;

            int smallInt = numbers[start];
            int largeInt = numbers[finish];

            while ((smallInt + largeInt != sum) && (smallInt < largeInt))
            {
                //if the sum of small and large ints are too big, make the large int smaller.
                //this is not working as intended, the check does not trigger it properly.
                if (smallInt + largeInt < sum)
                {
                    largeInt = numbers[finish--];
                }
                //if the sum of the small and large ints are too small, make the small int bigger.
                //this is not working as intended, the check does not trigger it properly.
                else if (smallInt + largeInt > sum)
                {
                    smallInt = numbers[start++];
                }
            }

            if (smallInt + largeInt == sum)
                Console.WriteLine(smallInt + " and " + largeInt + " have a sum of: " + (smallInt + largeInt));
            else
                Console.WriteLine("No match of numbers seem to reach the sum of " + sum);

            Console.ReadLine();
        }
    }
}
