using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupparbete_TDD
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }


        static void Main(string[] args)
        {
            Console.WindowHeight = 30;

            DateTime productDate = DateTime.Now;
            // write only date
            //txtProductDate.Text = productDate.ToShortDateString();
            // set the value in 12 hour format
            int twelveHourFormatHour = int.Parse(productDate.ToString("hh"));
            // set the value in 24 hour format
            int twentyFourHourFormatHour = int.Parse(productDate.ToString("HH"));
            // set the minute
            int minutes = int.Parse(productDate.ToString("mm"));
            // get the AM and PM
            string ampm = productDate.ToString("tt");

            while (true)
            {

                Point point = new Point();
                Player p1 = new Player(1, 13, 0);

                while (!p1.CheckIfGoal(point) && p1.IsAlive)
                {
                    point.CheckIfTimeToActivateLaser(22);
                    Console.Clear();
                    Console.WriteLine(twentyFourHourFormatHour + "." + minutes);
                    Console.WriteLine("Collected Tresaures: " + p1.TreasureAmount);
                    point.PrintGameboard(p1);

                    ConsoleKey selectedKey = Console.ReadKey().Key;

                    if (p1.CollisionCheck(point, selectedKey))
                    {
                        p1.MovePlayer(selectedKey);
                        p1.CheckIfTresaure(point);
                    }

                    p1.CheckIfLaser(point);
                }

                Console.Clear();

                if (!p1.IsAlive)
                    Console.Write("L2P MF");
                else
                    Console.WriteLine("Congratulations!!! You are better then the Pink Panther!");

                Console.ReadKey();
            }

        }
    }
}
