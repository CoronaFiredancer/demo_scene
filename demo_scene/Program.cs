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

					if ((rand.Next(2) + 1)%2 == 0)
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						//Console.Clear();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Green;
						//Console.Clear();
					}
					Console.SetCursorPosition(x, y);

					if ((rand.Next(2) + 1)%2 == 0)
					{
						Console.Write("1");
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
