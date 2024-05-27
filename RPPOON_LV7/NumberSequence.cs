using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV7
{
	class NumberSequence
	{
		private double[] sequence;
		private int sequenceSize;
		private SortStrategy sortStrategy;
		private SearchStrategy searchStrategy;


		public NumberSequence(SortStrategy sortStrategy,SearchStrategy searchStrategy,int sequenceSize)
		{
			this.sortStrategy = sortStrategy;
			this.searchStrategy = searchStrategy;
			this.sequenceSize = sequenceSize;
			this.sequence = new double[sequenceSize];
		}
		public NumberSequence(SortStrategy sortStrategy, SearchStrategy searchStrategy, double[] array) : this(sortStrategy,searchStrategy,array.Length)
		{
			this.sortStrategy=sortStrategy;
			this.searchStrategy=searchStrategy;
			array.CopyTo(this.sequence, 0);
		}
		public void InsertAt(int index, double value)
		{
			this.sequence[index] = value;
		}
		public void SetSortStrategy(SortStrategy strategy)
		{
			this.sortStrategy = strategy;
		}
		public void Sort() { this.sortStrategy.Sort(this.sequence); }

		public int FindLocation(int target)
		{
			return this.searchStrategy.Search(sequence, target);	
		}
		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			foreach (double element in this.sequence)
			{
				builder.Append(element).Append(Environment.NewLine);
			}
			return builder.ToString();
		}
	}
}
