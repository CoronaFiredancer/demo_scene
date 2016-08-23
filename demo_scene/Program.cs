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
		private static HashSet<ConsolePoint> o;
		private static HashSet<ConsolePoint> n;
		private static HashSet<ConsolePoint> e;

		static void Main(string[] args)
		{
			int x;
			int y;
			ConsolePoint a;
			var rand = new Random();



			var comparer = new ConsolePointComparer<ConsolePoint>();
			var usedCoords = new HashSet<ConsolePoint>(comparer);
			d = new HashSet<ConsolePoint>(comparer);
			o = new HashSet<ConsolePoint>(comparer);
			n = new HashSet<ConsolePoint>(comparer);
			e = new HashSet<ConsolePoint>(comparer);

			CreateD();
			CreateO();
			CreateN();
			CreateE();
			//var testPoint = new ConsolePoint(16, 1);

			//var contains = d.Contains(testPoint);
			//if (contains)
			//{
			//	usedCoords.Add(testPoint);
			//}

			//Console.SetCursorPosition(testPoint.X, testPoint.Y);
			//Console.ForegroundColor = ConsoleColor.Blue;
			//Console.Write('W');

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

					if (d.Contains(a))
					{
						d.Remove(a);
						usedCoords.Add(a);

						Console.SetCursorPosition(a.X, a.Y);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write('D');
						continue;
					}

					if (o.Contains(a))
					{
						o.Remove(a);
						usedCoords.Add(a);

						Console.SetCursorPosition(a.X, a.Y);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write('O');
						continue;
					}

					if (n.Contains(a))
					{
						n.Remove(a);
						usedCoords.Add(a);

						Console.SetCursorPosition(a.X, a.Y);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write('N');
						continue;
					}

					if (e.Contains(a))
					{
						e.Remove(a);
						usedCoords.Add(a);

						Console.SetCursorPosition(a.X, a.Y);
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write('E');
						continue;
					}

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
			d.Add(new ConsolePoint(17, 1));
			d.Add(new ConsolePoint(18, 1));
			d.Add(new ConsolePoint(19, 1));

			d.Add(new ConsolePoint(16, 2));
			d.Add(new ConsolePoint(17, 2));
			d.Add(new ConsolePoint(18, 2));
			d.Add(new ConsolePoint(19, 2));
			d.Add(new ConsolePoint(20, 2));
			d.Add(new ConsolePoint(21, 2));

			d.Add(new ConsolePoint(17, 3));
			d.Add(new ConsolePoint(20, 3));
			d.Add(new ConsolePoint(21, 3));

			d.Add(new ConsolePoint(17, 4));
			d.Add(new ConsolePoint(20, 4));
			d.Add(new ConsolePoint(21, 4));

			d.Add(new ConsolePoint(17, 5));
			d.Add(new ConsolePoint(20, 5));
			d.Add(new ConsolePoint(21, 5));

			d.Add(new ConsolePoint(17, 6));
			d.Add(new ConsolePoint(20, 6));
			d.Add(new ConsolePoint(21, 6));

			d.Add(new ConsolePoint(16, 7));
			d.Add(new ConsolePoint(17, 7));
			d.Add(new ConsolePoint(18, 7));
			d.Add(new ConsolePoint(19, 7));
			d.Add(new ConsolePoint(20, 7));
			d.Add(new ConsolePoint(21, 7));

			d.Add(new ConsolePoint(16, 8));
			d.Add(new ConsolePoint(17, 8));
			d.Add(new ConsolePoint(18, 8));
			d.Add(new ConsolePoint(19, 8));
		}

		private static void CreateO()
		{
			o.Add(new ConsolePoint(25, 1));
			o.Add(new ConsolePoint(26, 1));

			o.Add(new ConsolePoint(24, 2));
			o.Add(new ConsolePoint(25, 2));
			o.Add(new ConsolePoint(26, 2));
			o.Add(new ConsolePoint(27, 2));

			o.Add(new ConsolePoint(23, 3));
			o.Add(new ConsolePoint(24, 3));
			o.Add(new ConsolePoint(27, 3));
			o.Add(new ConsolePoint(28, 3));

			o.Add(new ConsolePoint(23, 4));
			o.Add(new ConsolePoint(24, 4));
			o.Add(new ConsolePoint(27, 4));
			o.Add(new ConsolePoint(28, 4));

			o.Add(new ConsolePoint(23, 5));
			o.Add(new ConsolePoint(24, 5));
			o.Add(new ConsolePoint(27, 5));
			o.Add(new ConsolePoint(28, 5));

			o.Add(new ConsolePoint(23, 6));
			o.Add(new ConsolePoint(24, 6));
			o.Add(new ConsolePoint(27, 6));
			o.Add(new ConsolePoint(28, 6));

			o.Add(new ConsolePoint(24, 7));
			o.Add(new ConsolePoint(25, 7));
			o.Add(new ConsolePoint(26, 7));
			o.Add(new ConsolePoint(27, 7));

			o.Add(new ConsolePoint(25, 8));
			o.Add(new ConsolePoint(26, 8));
		}

		private static void CreateN()
		{
			n.Add(new ConsolePoint(30, 1));
			n.Add(new ConsolePoint(34, 1));
			n.Add(new ConsolePoint(35, 1));

			n.Add(new ConsolePoint(30, 2));
			n.Add(new ConsolePoint(31, 2));
			n.Add(new ConsolePoint(34, 2));
			n.Add(new ConsolePoint(35, 2));

			n.Add(new ConsolePoint(30, 3));
			n.Add(new ConsolePoint(31, 3));
			n.Add(new ConsolePoint(32, 3));
			n.Add(new ConsolePoint(34, 3));
			n.Add(new ConsolePoint(35, 3));

			n.Add(new ConsolePoint(30, 4));
			n.Add(new ConsolePoint(31, 4));
			n.Add(new ConsolePoint(32, 4));
			n.Add(new ConsolePoint(33, 4));
			n.Add(new ConsolePoint(34, 4));
			n.Add(new ConsolePoint(35, 4));

			n.Add(new ConsolePoint(30, 5));
			n.Add(new ConsolePoint(31, 5));
			n.Add(new ConsolePoint(32, 5));
			n.Add(new ConsolePoint(33, 5));
			n.Add(new ConsolePoint(34, 5));
			n.Add(new ConsolePoint(35, 5));


			n.Add(new ConsolePoint(30, 6));
			n.Add(new ConsolePoint(31, 6));
			n.Add(new ConsolePoint(33, 6));
			n.Add(new ConsolePoint(34, 6)); 
			n.Add(new ConsolePoint(35, 6));

			n.Add(new ConsolePoint(30, 7));
			n.Add(new ConsolePoint(31, 7));
			n.Add(new ConsolePoint(34, 7));
			n.Add(new ConsolePoint(35, 7));

			n.Add(new ConsolePoint(30, 8));
			n.Add(new ConsolePoint(35, 8));


		}

		private static void CreateE()
		{
			e.Add(new ConsolePoint(37, 1));
			e.Add(new ConsolePoint(38, 1));
			e.Add(new ConsolePoint(39, 1));
			e.Add(new ConsolePoint(40, 1));
			e.Add(new ConsolePoint(41, 1));
			e.Add(new ConsolePoint(42, 1));

			e.Add(new ConsolePoint(37, 2));
			e.Add(new ConsolePoint(38, 2));
			e.Add(new ConsolePoint(39, 2));
			e.Add(new ConsolePoint(40, 2));
			e.Add(new ConsolePoint(41, 2));
			e.Add(new ConsolePoint(42, 2));

			e.Add(new ConsolePoint(37, 3));
			e.Add(new ConsolePoint(38, 3));

			e.Add(new ConsolePoint(37, 4));
			e.Add(new ConsolePoint(38, 4));
			e.Add(new ConsolePoint(39, 4));
			e.Add(new ConsolePoint(40, 4));

			e.Add(new ConsolePoint(37, 5));
			e.Add(new ConsolePoint(38, 5));
			e.Add(new ConsolePoint(39, 5));
			e.Add(new ConsolePoint(40, 5));

			e.Add(new ConsolePoint(37, 6));
			e.Add(new ConsolePoint(38, 6));

			e.Add(new ConsolePoint(37, 7));
			e.Add(new ConsolePoint(38, 7));
			e.Add(new ConsolePoint(39, 7));
			e.Add(new ConsolePoint(40, 7));
			e.Add(new ConsolePoint(41, 7));
			e.Add(new ConsolePoint(42, 7));

			e.Add(new ConsolePoint(37, 8));
			e.Add(new ConsolePoint(38, 8));
			e.Add(new ConsolePoint(39, 8));
			e.Add(new ConsolePoint(40, 8));
			e.Add(new ConsolePoint(41, 8));
			e.Add(new ConsolePoint(42, 8));

		}
	}
}
