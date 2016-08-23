using System.Collections.Generic;

namespace demo_scene.helpers
{
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