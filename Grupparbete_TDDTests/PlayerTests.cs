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
        public void OnCollisionTest()
        {
            Player player = new Player(4, 3, 0);


            player.MovePlayer();

            Assert.IsTrue(Point.gameboard[4, 4].Equals(2));

        }
    }
}