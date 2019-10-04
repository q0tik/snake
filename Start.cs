using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Start
    {
        public void Start_()
        {
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WindowHeight = 11;
                Console.WindowWidth = 20;
            }
            Slush list = new Slush();
            Move move = new Move();
            Thread thread = new Thread(new ThreadStart(list.Listen));
            thread.Start();
            move.Nach();
            while (!move.gameover)
            {
                move.Moving();
                move.Apple();
                if (move.pole[move.ya,move.xa] != '@')
                {
                    move.apple = false;
                }
                if (list.input.Key == ConsoleKey.Escape)
                {
                    move.gameover = true;
                }
                if (list.input.Key == ConsoleKey.S && move.o != 2)
                {
                    move.o = 0;
                }
                if (list.input.Key == ConsoleKey.A && move.o != 3)
                {
                    move.o = 1;
                }
                if (list.input.Key == ConsoleKey.W && move.o != 0)
                {
                    move.o = 2;
                }
                if (list.input.Key == ConsoleKey.D && move.o != 1)
                {
                    move.o = 3;
                }
                move.Otrisovka();
                Thread.Sleep(100);
            } // while
            Console.Clear();
            Console.Write("Game over");
            Thread.Sleep(1000);
        }
    }
}
