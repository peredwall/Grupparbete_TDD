using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD
{


    public class Player
    {
        int positionX;
        int positionY;
        int treasureAmount;

        public Player(int postionX, int positionY, int treasureAmount)
        {
            this.PositionX = postionX;
            this.PositionY = positionY;
            this.TreasureAmount = treasureAmount;
        }
        
        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }
        public int TreasureAmount { get => treasureAmount; set => treasureAmount = value; }

        #region Methods

        public void MovePlayer(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
                PositionX++;
            else if (key == ConsoleKey.LeftArrow)
                PositionX--;
            else if (key == ConsoleKey.DownArrow)
                PositionY++;
            else if (key == ConsoleKey.UpArrow)
                PositionY--;
        }

        #endregion
    }
}
