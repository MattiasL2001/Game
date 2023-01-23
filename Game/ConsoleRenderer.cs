using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class ConsoleRenderer
    {
        private GameWorld world;
        //constructor
        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera Console-fönstret enligt världens storlek

            //sets the world
            world = gameWorld;
        }

        //renders out the game world correctly on screen
        public void Render()
        {
            // TODO Rendera spelvärlden (och poängräkningen)

            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)

            //clears the console in order to remove objects with outdated positions
            Console.Clear();

            foreach(var item in world.gameObjects)
			{
                //goes to the position of the objects and "draws" them
                Console.SetCursorPosition(item.position.X, item.position.Y);
                Console.Write(item);
			}
        }
    }
}
