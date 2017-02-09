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
		int[] Array = new int[100];
		for (int i = 1, i <= 100, i++)
			Array[i] = i;

		return Array;
		}

        //I didn't originally add enough lines of code to fullfill the requirements for the assignment, so here is more
        //This does not properly identify even or odd numbers
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 3 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }

    }
}
