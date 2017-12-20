using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD
{
    public class Point
    {
        bool laserActive = false;
        int treasuresOnMap;

        public int[,] gameboard = new int[,]{{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1},
                                             { 1, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 3, 5, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 5, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 5, 0, 0, 4, 1},
                                             { 1, 0, 0, 0, 0, 0, 5, 0, 0, 1, 6, 6, 6, 6, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1},
                                             { 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                             { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };

        public bool LaserActive { get => laserActive; set => laserActive = value; }
        public int TreasuresOnMap { get => treasuresOnMap; set => treasuresOnMap = value; }

        public void PrintGameboard(Player currentPlayer)
        {
 
            for (int i = 0; i < 25; i++)
			{
                for (int j = 0; j < 25; j++)
                {
                    if ((j == currentPlayer.PositionX) && i == (currentPlayer.PositionY))
                        Console.Write(":)");
                    else if ((gameboard[i, j] == 0) || ((gameboard[i, j] == 6 && (!laserActive)) || ((gameboard[i, j] == 5)) && (!laserActive)))
                        Console.Write("  ");
                    else if (gameboard[i, j] == 1)
                        Console.Write("* ");
                    else if (gameboard[i, j] == 3)
                        Console.Write("? ");
                    else if (gameboard[i, j] == 4)
                        Console.Write("XX");
                    else if (gameboard[i, j] == 5 && (laserActive))
                        Console.Write(" |");
                    else if (gameboard[i, j] == 6 && (laserActive))
                        Console.Write("--");
                    else
                        Console.Write(gameboard[i, j] + " ");
                }
                Console.WriteLine("");
			}

        }

        public void CheckIfTimeToActivateLaser(int time)
        {

            if (!LaserActive)
                if (time >= 20 || time <= 7)
                {
                    LaserActive = true;
                }
            else if(LaserActive)
                    if (time < 20 && time > 7)
                    {
                        LaserActive = false;
                    }
        }

        public void CountTreasuresOnMap()
        {
            foreach (int item in gameboard)
            {
                if (item == 3)
                {
                    TreasuresOnMap++;
                }
            }
        }
    }
}
