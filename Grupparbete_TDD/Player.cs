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
        int minX = 1;
        int maxX = 23;
        int minY = 1;
        int maxY = 23;

        public Player(int postionX, int positionY, int treasureAmount)
        {
            this.PositionX = postionX;
            this.PositionY = positionY;
            this.TreasureAmount = treasureAmount;
        }

        public int PositionX { get => positionX; set { if (value < minX) positionX = minX; else if (value > maxX) positionX = maxX; else positionX = value; } }
        public int PositionY { get => positionY; set { if (value < minY) positionY = minY; else if (value > maxY) positionY = maxY; else positionY = value; } }
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

        public void CheckIfTreasure(Point point)
        {
            if (point.gameboard[positionY, positionX] == 3)
            {
                treasureAmount++;
                point.gameboard[positionY, positionX] = 0;
                point.TreasuresOnMap--;
            }
        }

        public bool CheckIfGoal(Point point)
        {
            if ((point.gameboard[positionY, positionX]) == 4 && (point.TreasuresOnMap == 0))
                return true;
            else if ((point.gameboard[positionY, positionX]) == 4 && (point.TreasuresOnMap < 0))
                throw new ArgumentOutOfRangeException();
            else
                return false;
        }

        public void CheckIfLaser(Point point)
        {
            if (((point.gameboard[positionY, positionX]) == 5 || (point.gameboard[positionY, positionX]) == 6) && (point.LaserActive))
                isAlive = false;
        }

        


        #endregion
    }
}
