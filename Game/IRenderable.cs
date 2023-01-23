using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
	public interface IRenderable
	{
		//creates a "contract", which means that you are able to get an appearance
		//from all objects that implements IRenderable
		public char appearance
		{
			get;
		}
	}
}
