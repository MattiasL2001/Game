using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	public class Player : GameObject, IRenderable, IMovable
	{
		public char appearance
		{
			get
			{
				//property that sets the appearance of the player on screen
				return '#';
			}
		}

		//property for which direction the player is going
		public Direction direction { get; set; }

		public Player(Position P, Direction D):base(P)
		{
			direction = D;
		}

		//the Player objects implementation of ToString()
		//Returns the Players appearance when you call
		//Player.ToString()
		public override string ToString()
		{
			return appearance.ToString();
		}

		//the Player objects implementation of Update()
		public override void Update()
		{
			switch(direction)
			{
				//determines which direction the player is heading

				case Direction.Up:
					position.Y--;
					break;
				case Direction.Down:
					position.Y++;
					break;
				case Direction.Left:
					position.X--;
					break;
				case Direction.Right:
					position.X++;
					break;
				case Direction.None:
					break;
			}
		}
	}
}
