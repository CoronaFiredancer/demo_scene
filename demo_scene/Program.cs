using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo_scene.helpers;

namespace demo_scene
{
	class Program
	{
		private static HashSet<ConsolePoint> d;

		static void Main(string[] args)
		{
			int x;
			int y;
			ConsolePoint a;
			var rand = new Random();



			var comparer = new ConsolePointComparer<ConsolePoint>();
			var usedCoords = new HashSet<ConsolePoint>(comparer);
			d = new HashSet<ConsolePoint>(comparer);
			CreateD();
			var testPoint = new ConsolePoint(16, 1);

			var contains = d.Contains(testPoint);
			if (contains)
			{
				usedCoords.Add(testPoint);
			}

			Console.SetCursorPosition(testPoint.X, testPoint.Y);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write('W');
			do

			{
				while (!Console.KeyAvailable)
				{
					do
					{
						x = rand.Next(79) + 1;
						y = rand.Next(23) + 1;
						a = new ConsolePoint(x, y);
					} while (usedCoords.Contains(a));

					
					

					var random = rand.Next(3) + 1;
					if (random % 3 == 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
					}
					else if (random % 3 == 1)
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					else if (random % 3 == 2)
					{
						Console.ForegroundColor = ConsoleColor.DarkYellow;
					}
					Console.SetCursorPosition(a.X, a.Y);

					var key = rand.Next(32, 90);

					if ((rand.Next(2) + 1) % 2 == 0)
					{
						Console.Write((char)key);
					}
					else
					{
						Console.Write("0");
					}
				}
			}
			while (Console.ReadKey(true).Key != ConsoleKey.Enter);
		}

		private static void CreateD()
		{
			d.Add(new ConsolePoint(16, 1));
		}
	}

	public class ConsolePointComparer<T> : IEqualityComparer<ConsolePoint>
	{
		public bool Equals(ConsolePoint x, ConsolePoint y)
		{
			return x.X == y.X && x.Y == y.Y;
		}

		public int GetHashCode(ConsolePoint obj)
		{
			return obj.X*17 + obj.Y*31;
		}
	}
}
