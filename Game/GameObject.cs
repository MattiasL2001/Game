using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public abstract class GameObject
    {
        // TODO

        public Position position;

        public GameObject(Position p)
		{
            position = p;
		}

        //empty constructor so that you can initialize objects without input paramteters
        public GameObject()
		{

		}

        public abstract void Update();
    }
}
