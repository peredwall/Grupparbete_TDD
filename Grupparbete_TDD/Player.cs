using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD
{


    public class Player
    {
        bool isAlive = true;
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
        public bool IsAlive { get => isAlive; set => isAlive = value; }

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

        public bool CollisionCheck(Point point, ConsoleKey key)
        {
            if (key == ConsoleKey.DownArrow)
            {
                if (point.gameboard[(PositionY + 1), PositionX] == 1)
                    return false;
                else
                    return true;
            }
            if (key == ConsoleKey.UpArrow)
            {
                if (point.gameboard[(PositionY - 1), PositionX] == 1)
                    return false;
                else
                    return true;
            }
            if (key == ConsoleKey.LeftArrow)
            {
                if (point.gameboard[(PositionY), (PositionX - 1)] == 1)
                    return false;
                else
                    return true;
            }
            if (key == ConsoleKey.RightArrow)
            {
                if (point.gameboard[(PositionY), (PositionX + 1)] == 1)
                    return false;
                else
                    return true;
            }
            else
                return false;

        }

        public void CheckIfTresaure(Point point)
        {
            if(point.gameboard[positionY, positionX] == 3)
            {
                treasureAmount++;
                point.gameboard[positionY, positionX] = 0;
            }
        }

        public bool CheckIfGoal(Point point)
        {
            if ((point.gameboard[positionY, positionX]) == 4 && (treasureAmount == 10))
                return true;
            else
                return false;
        }

        public void CheckIfLaser(Point point)
        {
            if ((point.gameboard[positionY, positionX]) == 5 && (point.LaserActive))
                isAlive = false;
        }




        #endregion
    }
}
