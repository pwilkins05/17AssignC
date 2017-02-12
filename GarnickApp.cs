using System;

namespace Application
{
    public class GarnickApp
    {
        public int[] returnArray()
        {
            //Array should contain 1 - 100
            //#Bug: This does not contain 1 - 100
            // Bug Fixed by Oliver
	    //Fixed a bug with commas rather than semi colons --Devin DuBose
            int[] Array = new int[100];
            for (int i = 1; i <= 100; i++)
                Array[i] = i;

            return Array;
        }

        //I didn't originally add enough lines of code to fullfill the requirements for the assignment, so here is more
        //This does not properly identify even or odd numbers

	//Fixed the bug with determining even/odd, as well as some read/write line bugs. --Devin DuBose
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");

            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
            }

            Console.ReadLine();
        }

    }
}
