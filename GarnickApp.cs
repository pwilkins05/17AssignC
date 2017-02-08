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
	}
}
