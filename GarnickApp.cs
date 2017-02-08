using System;
namespace Application
{
	public class GarnickApp
	{
		public int[] returnArray()
		{
		//Array should contain 1 - 100
		//#Bug: This does not contain 1 - 100
		int[] Array = new int[100];
		for (int i = 0, i < 100, i++)
			Array[i] = i;

		return Array;
		}
	}
}
