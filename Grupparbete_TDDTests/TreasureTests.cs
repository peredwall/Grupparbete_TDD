using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grupparbete_TDD;

namespace Grupparbete_TDDTests
{

    [TestClass]
    public class TreasureTests
    {
        [TestMethod]
        public void SuccessfullyPickedUpTreasure_True()
        {
            Player player = new Player(4, 5, 0);
            Point point = new Point();

            player.MovePlayer(ConsoleKey.RightArrow);
            player.CheckIfTreasure(point);

            Assert.AreEqual(1, player.TreasureAmount);
        }

        [TestMethod]
        public void TreasureRemovedFromGameboardWhenPickuped_True()
        {
            Player player = new Player(4, 5, 0);
            Point point = new Point();

            player.MovePlayer(ConsoleKey.RightArrow);
            player.CheckIfTreasure(point);

            Assert.AreEqual(0, point.gameboard[5, 5]);
        }

        [TestMethod]
        public void TreasuresOnMapDecreasCorrectly_True()
        {
            Player player = new Player(4, 5, 0);
            Point point = new Point();

            point.CountTreasuresOnMap();
            int initialTreasureAmount = point.TreasuresOnMap;

            player.MovePlayer(ConsoleKey.RightArrow);
            player.CheckIfTreasure(point);
            point.CountTreasuresOnMap();

            Assert.AreEqual((initialTreasureAmount -1), point.TreasuresOnMap);
        }

        [TestMethod]
        public void CanAlwaysExitWhenAllTreasurePickedUp_True()
        {
            Player p1 = new Player(24, 11, 0);
            Point point = new Point { TreasuresOnMap = 0 };

            ConsoleKey inputKey = ConsoleKey.DownArrow;
            p1.MovePlayer(inputKey);

            Assert.IsTrue(p1.CheckIfGoal(point));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void TreasuresOnMapNegativeValue_Exception()
        {
            Player p1 = new Player(24, 11, 0);
            Point point = new Point { TreasuresOnMap = -1 };

            ConsoleKey inputKey = ConsoleKey.DownArrow;
            p1.MovePlayer(inputKey);

            p1.CheckIfGoal(point);
        }
    }
}
