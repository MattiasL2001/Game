using System;
using System.Threading;

namespace Game
{
    public class Program
    {
        /// <summary>
        /// Checks Console to see if a keyboard key has been pressed, if so returns it, otherwise NoName.
        /// </summary>
        static ConsoleKey ReadKeyIfExists() => Console.KeyAvailable ? Console.ReadKey(intercept: true).Key : ConsoleKey.NoName;

        public static void Loop()
        {
            // initializing the game
            const int frameRate = 5;
            GameWorld world = new GameWorld(50, 20);
            ConsoleRenderer renderer = new ConsoleRenderer(world);

            // TODO Skapa spelare och andra objekt etc. genom korrekta anrop till vår GameWorld-instans
            // ...

            //sets the cursor to be invisible
            Console.CursorVisible = false;
            Position pos = new Position(25, 10);
            //creates an instance of a player
            Player pl = new Player(pos, Direction.Right);
            //adds the player to the world
            world.AddObject(pl);

            Food fo = new Food();
            world.AddObject(fo);

            //sets the foods position to be random
            fo.Random(50, 20);
            //updates the food list
            world.UpdateFoodList();

            // Huvudloopen
            bool running = true;
            while (running)
            {
                // Kom ihåg vad klockan var i början
                DateTime before = DateTime.Now;

                // Hantera knapptryckningar från användaren
                ConsoleKey key = ReadKeyIfExists();
                switch (key)
                {
                    case ConsoleKey.Q:
                        running = false;
                        break;
                    case ConsoleKey.W:
                        pl.direction = Direction.Up;
                        break;
                    case ConsoleKey.S:
                        pl.direction = Direction.Down;
                        break;
                    case ConsoleKey.A:
                        pl.direction = Direction.Left;
                        break;
                    case ConsoleKey.D:
                        pl.direction = Direction.Right;
                        break;

                        // TODO Lägg till logik för andra knapptryckningar
                        // ...
                }

                // Uppdatera världen och rendera om

                if (running && world.Update())
				{
                    renderer.Render();
                }
                else
				{
                    running = false;
				}

                // Mät hur lång tid det tog
                double frameTime = Math.Ceiling((1000.0 / frameRate) - (DateTime.Now - before).TotalMilliseconds);
                if (frameTime > 0)
                {
                    // Vänta rätt antal millisekunder innan loopens nästa varv
                    Thread.Sleep((int)frameTime);
                }
            }
        }

        static void Main(string[] args)
        {
            // Vi kan ev. ha någon meny här, men annars börjar vi bara spelet direkt

            do
            {
                Loop();
                Console.Clear();
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("'Y' for yes, 'N' for no");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
