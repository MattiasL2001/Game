using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	public interface IMovable
	{
		//gets the direction of the object that is implementing IMovable
		public Direction direction
		{
			get;
		}
	}
}
