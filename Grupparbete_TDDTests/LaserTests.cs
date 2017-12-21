using System;
using Grupparbete_TDD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grupparbete_TDDTests
{
    [TestClass]
    public class LaserTests
    {
        [TestMethod]
        public void LaserTurnsOnAfterEightPm()
        {
            Point point = new Point();
            Player player = new Player(5, 12, 0);
            int currentTime = 20;

            point.CheckIfTimeToActivateLaser(currentTime);

            Assert.IsTrue(point.LaserActive);
        }

        [TestMethod]
        public void AliveAfterPassingTurnedOffLaser_True()
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



    }
}
