namespace RPPOON_LV7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BubbleSort bubbleSort = new BubbleSort();
			SequentialSearch sequentialSearch= new SequentialSearch();
			NumberSequence numberSequence = new NumberSequence(bubbleSort,sequentialSearch, 5);
			numberSequence.InsertAt(0, 1);
			numberSequence.InsertAt(1, 5);
			numberSequence.InsertAt(2, 3);
			numberSequence.InsertAt(3, 4);
			numberSequence.InsertAt(4, 3);

			numberSequence.Sort();
			Console.WriteLine(numberSequence.FindLocation(5));
			Console.WriteLine(numberSequence.ToString());


		}
	}
}
