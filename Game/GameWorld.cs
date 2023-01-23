using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class GameWorld
    {
        //list where all the food is stored
        public List<GameObject> foodList = new List<GameObject>();

        //relevant variables for the game world
        public int width;
        public int height;
        public int points = 0;
        //initializes a list with all the game objects in the game world
        public List<GameObject> gameObjects = new List<GameObject>();

        //constructor in which you must put two parameters which will define the level size
        public GameWorld(int Width, int Height)
		{
            //sets the windows size
            width = Width;
            height = Height;
            Console.SetWindowSize(Width, Height);
            Console.SetBufferSize(Width, Height);
        }

        //method to add objects to the gameObjects list
        public void AddObject(GameObject obj)
		{
            gameObjects.Add(obj);
		}

        public void UpdateFoodList()
		{
            //Sets the foodlist to be every item in the "gameObjects" lists that is food.
            foodList = gameObjects.FindAll(obj => obj is Food).ToList();
        }

        public void UpdatePoints()
		{
            points++;
		}

        //method that frequently runs
        public bool Update()
        {
            // TODO

            //loops through each item in the "gameObjects" list
            foreach(var item in gameObjects)
			{
                //for each food item
                foreach(var food in foodList)
				{
                    //if the player have collected food
                    if (item is Player && item.position == food.position)
					{
                        //adding some points
                        UpdatePoints();

                        //f is told to be food as Food so that it is seen as food, rather than just an object
                        //as the list contatining the food sees the food as general objects
                        var f = food as Food;

                        //sets a new random location to the food
                        f.Random(width, height);
					}
				}
                //updates all the things neccessary for all the game objects
                item.Update();

                //if you go outside of the level
                if (item.position.X >= width || item.position.X < 0 || item.position.Y >= height || item.position.Y < 0)
				{
                    Console.Clear();
                    Console.SetCursorPosition(width / 3, height / 3);
					Console.WriteLine("Game over!");
                    Console.WriteLine($"You got {points} points!");
                    System.Threading.Thread.Sleep(5000);
                    return false;
				}
			}
            return true;
        }
    }
}
