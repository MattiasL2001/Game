using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	//Position object
	public struct Position
	{
		//X and Y coordinates
		public int X;
		public int Y;

		//constructor
		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}

		//defining a position addition/subtraction operation
		public static Position operator +(Position a, Position b) => new Position(a.X + b.X, a.Y + b.Y);
		public static Position operator -(Position a, Position b) => new Position(a.X - b.X, a.Y - b.Y);
		//defining what is equal and not equal, in terms of position
		public static bool operator ==(Position a, Position b) => (a.X == b.X && a.Y == b.Y);
		public static bool operator !=(Position a, Position b) => (a.X != b.X || a.Y != b.Y);
	}
}
