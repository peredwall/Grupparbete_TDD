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
    public class PlayerTests
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
    }
}