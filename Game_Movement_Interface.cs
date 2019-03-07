/* SOURCE:   https://www.dreamincode.net/forums/topic/215620-a-basic-c%23-console-game-movement-engine/
 * AUTHOR:   
 * PURPOSE:  After locating this engine for basic movement in a console game application, I went
             through the program and made minor, aesthetic changes. This is an ongoing interest
             that I intend to develop further as time and life permit.
 * FILENAME: Hero_Interface.cs
 * STUDENT:  Steven Christopher
 * DATE:     FEB 09 2019
*/

// STYLE MODIFICATIONS:
// 1) Changed the background color.
// 2) Changed the hero color.

// FUNCTIONAL MODIFICATIONS: None.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Interface
{
    class Program
    {
        const ConsoleColor HERO_COLOR = ConsoleColor.Red;
        const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Yellow;

        public static Coordinate Hero { get; set; } //Will represent our here that's moving around :P/>
 
        static void Main(string[] args)
        {
            InitGame();

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveHero(0, -1);
                        break; 

                    case ConsoleKey.RightArrow:
                        MoveHero(1, 0);
                        break;
 
                    case ConsoleKey.DownArrow:
                        MoveHero(0, 1);
                        break;
 
                    case ConsoleKey.LeftArrow:
                        MoveHero(-1, 0);
                        break;
                }
            }
        }
        /// <summary>
        /// Paint the new hero
        /// </summary>
        static void MoveHero(int x, int y)
        {
            Coordinate newHero = new Coordinate()
            {
                X = Hero.X + x,
                Y = Hero.Y + y
            };
 
            if (CanMove(newHero))
            {
                RemoveHero();
                Console.BackgroundColor = HERO_COLOR;
                Console.SetCursorPosition(newHero.X, newHero.Y);
                Console.Write(" ");
 
                Hero = newHero;
            }
        }

        /// <summary>
        /// Overpaint the old hero
        /// </summary>
        static void RemoveHero()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(" ");
        }

        /// <summary>
        /// Make sure that the new coordinate is not placed outside the
        /// console window (since that will cause a runtime crash
        /// </summary>
        static bool CanMove(Coordinate c)
        {
            if (c.X< 0 || c.X >= Console.WindowWidth)
                return false;
 
            if (c.Y< 0 || c.Y >= Console.WindowHeight)
              return false;
 
            return true;
        }
 
        /// <summary>
        /// Paint a background color
        /// </summary>
        /// <remarks>
        /// It is very important that you run the Clear() method after
        /// changing the background color since this causes a repaint of the background
        /// </remarks>
        static void SetBackgroundColor()
        {
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear(); //Important!
        }
 
        /// <summary>
        /// Initiates the game by painting the background
        /// and initiating the hero
        /// </summary>
        static void InitGame()
        {
            SetBackgroundColor();
            Hero = new Coordinate()
            {
                X = 0,
                Y = 0
            };
 
            MoveHero(0, 0);
 
        }
    }
    /// <summary>
    /// Represents a map coordinate
    /// </summary>
    class Coordinate
    {
        public int X { get; set; } //Left
        public int Y { get; set; } //Top

    }
}
