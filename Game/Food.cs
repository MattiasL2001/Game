using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	public class Food : GameObject, IRenderable
	{
		//does so that you are able to get the appearance
		public char appearance { get; }

		//constructor
		public Food()
		{
			//sets the appearance
			appearance = '@';
		}

		//sets a random position
		public void Random(int x, int y)
		{
			int rx = new Random().Next(1, x);
			int ry = new Random().Next(1, y);

			position = new Position(rx, ry);
		}

		public override string ToString()
		{
			//returns the objects appearance, "@", when calling .ToString()
			return appearance.ToString();
		}

		public override void Update()
		{

		}
	}
}
