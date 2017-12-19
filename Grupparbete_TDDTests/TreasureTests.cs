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
            player.CheckIfTresaure(point);

            Assert.AreEqual(1, player.TreasureAmount);
        }

        [TestMethod]
        public void TreasureRemovedFromGameboardWhenPickuped_True()
        {
            Player player = new Player(4, 5, 0);
            Point point = new Point();

            player.MovePlayer(ConsoleKey.RightArrow);
            player.CheckIfTresaure(point);

            Assert.AreEqual(0, point.gameboard[5, 5]);
        }

        [TestMethod]
        public void TotalTreasureDecreasedWhenPickuped_True()
        {
            Player player = new Player(4, 5, 0);
            Point point = new Point();

            player.MovePlayer(ConsoleKey.RightArrow);
            player.CheckIfTresaure(point);
            int amountOfTreasuresLeft = 0;

            foreach (var p in point.gameboard)
            {
                if (p == 3)
                    amountOfTreasuresLeft++;
            }

            Assert.AreEqual(9, amountOfTreasuresLeft);

        }
    }
}
