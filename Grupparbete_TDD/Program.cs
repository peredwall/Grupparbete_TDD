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
            DateTime productDate = DateTime.Now;
            // write only date
            //txtProductDate.Text = productDate.ToShortDateString();
            // set the value in 12 hour format
            string twelveHourFormatHour = int.Parse(productDate.ToString("hh")).ToString();
            // set the value in 24 hour format
            string twentyFourHourFormatHour = int.Parse(productDate.ToString("HH")).ToString();
            // set the minute
            string minutes = productDate.ToString("mm");
            // get the AM and PM
            string ampm = productDate.ToString("tt");

            Console.WriteLine(twentyFourHourFormatHour + "." + minutes);

            Point point = new Point();
            Player p1 = new Player(1, 13, 0);

            while (true)
            { 
            point.PrintGameboard(p1);
            p1.MovePlayer(Console.ReadKey().Key);
            }


        }
    }
}
