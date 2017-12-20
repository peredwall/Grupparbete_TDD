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
        public void AliveAfterTriggerLaser_False()
        {
            Point point = new Point();
            Player player = new Player(5, 12, 0);
            ConsoleKey selectedKey = ConsoleKey.RightArrow;
            int currentTime = 22;
            

            point.CheckIfTimeToActivateLaser(currentTime);
            player.MovePlayer(selectedKey);
            player.CheckIfLaser(point);

            Assert.IsFalse(player.IsAlive);
        }

        [TestMethod]
        public void AliveAfterTriggerTurnedOffLaser_True()
        {
            Point point = new Point();
            Player player = new Player(5, 12, 0);
            ConsoleKey selectedKey = ConsoleKey.RightArrow;
            int currentTime = 12;

            point.CheckIfTimeToActivateLaser(currentTime);
            player.MovePlayer(selectedKey);
            player.CheckIfLaser(point);

            Assert.IsTrue(player.IsAlive);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        [DataRow(ConsoleKey.LeftArrow)]
        [DataRow(ConsoleKey.UpArrow)]
        public void OutsideGameBoardException(ConsoleKey inputKey)
        {
            Player p1 = new Player(0, 0, 0);

            p1.MovePlayer(inputKey);
        }
    }
}