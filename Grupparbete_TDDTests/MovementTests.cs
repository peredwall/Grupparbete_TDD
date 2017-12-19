using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grupparbete_TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD.Tests
{
    [TestClass()]
    public class MovementTests
    {
        [TestMethod()]
        [DataRow(5, ConsoleKey.DownArrow)]
        [DataRow(3, ConsoleKey.UpArrow)]

        public void MovePlayerMoveUpAndDOwnTest_True(int expecting, ConsoleKey key)
        {
            Player player = new Player(4, 4, 0);

            Point point = new Point();

            player.MovePlayer(key);

            Assert.AreEqual(expecting, player.PositionY);
        }

        [TestMethod]
        [DataRow(3, ConsoleKey.LeftArrow)]
        [DataRow(5, ConsoleKey.RightArrow)]
        public void PlayerMoveLeftAndRight_Test(int expecting, ConsoleKey key)
        {
            Player player = new Player(4, 4, 0);

            Point point = new Point();

            player.MovePlayer(key);

            Assert.AreEqual(expecting, player.PositionX);
        }

        [TestMethod]
        public void CollisionCheck_Test()
        {
            Point point = new Point();
            Player player = new Player(3, 8, 0);
            ConsoleKey selectedKey = ConsoleKey.DownArrow;

            if (player.CollisionCheck(point, selectedKey))
                player.MovePlayer(selectedKey);

            Assert.IsTrue((player.PositionY == 8) && (player.PositionX == 3));
        }

        [TestMethod]
        public void AbleToSuccessfullyEndGame_True()
        {
            Point point = new Point();
            Player player = new Player(23, 11, 10);
            ConsoleKey selectedKey = ConsoleKey.DownArrow;

            player.MovePlayer(selectedKey);

            Assert.IsTrue(player.CheckIfGoal(point));

        }

        [TestMethod]
        public void RunIntoLaser()
        {
            Point point = new Point();
            Player player = new Player(5, 12, 0);
            ConsoleKey selectedKey = ConsoleKey.RightArrow;


            point.CheckIfTimeToActivateLaser(22);
            player.MovePlayer(selectedKey);
            player.CheckIfLaser(point);
 

            Assert.IsFalse(player.IsAlive);


        }


    }
}