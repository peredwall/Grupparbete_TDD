using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD
{
    public class Player
    {
        int postionX;
        int positionY;
        int treasureAmount;

        public Player(int postionX, int positionY, int treasureAmount)
        {
            this.PostionX = postionX;
            this.PositionY = positionY;
            this.TreasureAmount = treasureAmount;
        }

        public int PostionX { get => postionX; set => postionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        public int TreasureAmount { get => treasureAmount; set => treasureAmount = value; }

        public void MovePlayer()
        {



        }
    }
}
