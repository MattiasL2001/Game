using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void UpdateTest()
		{
			Position p = new Position(2, 13);
			Player pl = new Player(p, Direction.Right);
			pl.Update();
			Assert.AreEqual((3, 13), (pl.position.X, pl.position.Y));
		}

		[TestMethod()]
		public void LoopTest()
		{
			GameWorld world = new GameWorld(50, 20);

			world.UpdatePoints();

			if (world.points == 1)
			{
				Console.WriteLine("works!");
			}
			else
			{
				Assert.Fail();
			}
		}
	}
}