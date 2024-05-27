using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
	class BubbleSort : SortStrategy
	{
		public override void Sort(double[] array)
		{
			int arrayLength = array.Length;
			for(int i = 0; i < arrayLength - 1; i++)
			{
				for(int j = 0; j < arrayLength - i - 1; j++)
				{
					if (array[j] < array[j + 1])
					{
						Swap(ref array[j], ref array[j + 1]);	
					}
				}
			}
		}
	}

}
