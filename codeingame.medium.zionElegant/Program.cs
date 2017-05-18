using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
	static void Main(string[] args)
	{
		int axisX = int.Parse(Console.ReadLine());
		int axisY = int.Parse(Console.ReadLine());

		List<Tuple<int, int>> grid = new List<Tuple<int, int>>();

		for (int i = 0; i < axisY; i++)
		{
			string line = Console.ReadLine();

			for (int w = 0; w < axisX; w++)
				if (line[w].Equals('0'))
					grid.Add(Tuple.Create(w,i));
		}

		foreach (Tuple<int, int> node in grid)
		{
			var right = grid.FirstOrDefault(r => r.Item1 > node.Item1 && r.Item2 == node.Item2) ?? Tuple.Create(-1, -1);
			var bottom = grid.FirstOrDefault(b => b.Item1 == node.Item1 && b.Item2 > node.Item2) ?? Tuple.Create(-1, -1);
			Console.WriteLine("{0} {1} {2} {3} {4} {5}", node.Item1, node.Item2, right.Item1, right.Item2, bottom.Item1, bottom.Item2);
		}

	}
}