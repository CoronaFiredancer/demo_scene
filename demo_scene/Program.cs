using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_scene
{
	class Program
	{
		static void Main(string[] args)
		{
			int x;
			int y;
			var rand = new Random();

			do
			{
				while (!Console.KeyAvailable)
				{
					x = rand.Next(79) + 1;
					y = rand.Next(23) + 1;
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
					Console.SetCursorPosition(x, y);

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
			} while (Console.ReadKey(true).Key != ConsoleKey.Enter);
		}
	}
}
