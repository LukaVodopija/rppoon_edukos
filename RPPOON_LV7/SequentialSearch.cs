using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
	public class SequentialSearch : SearchStrategy
	{
		public int Search(double[] array, int target)
		{
			for(int i = 0; i < array.Length; i++)
			{
				if (array[i] == target)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
