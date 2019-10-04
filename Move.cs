using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Move
    {
        //-------------------------------------
        public bool gameover, apple, syel;
        public char[,] pole = new char[10, 10];
        public int[] x = new int[30];
        public int[] y = new int[30];
        public int o, i, j, xa, ya;
        public int n = 5;
        //-------------------------------------
        public void Nach()
        {
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    pole[i, j] = '.';
                }
            }
            o = 3;
            x[0] = 0; x[1] = 1; x[2] = 2; x[3] = 3; x[4] = 4;
            y[0] = 0; y[1] = 0; y[2] = 0; y[3] = 0; y[4] = 0;
            pole[y[0], x[0]] = '0';
            pole[y[0], x[1]] = '0';
            pole[y[0], x[2]] = '0';
            pole[y[0], x[3]] = '0';
            pole[y[0], x[4]] = '0';
            gameover = false;
            apple = false;
            syel = false;
        }
        public void For_()
        {
            for (i = 1; i <= n - 1; i++)
            {
                x[i - 1] = x[i];
                y[i - 1] = y[i];
            }
        }
        public void Eat()
        {
            if (pole[y[n - 1], x[n - 1]] == '@')
            {
                syel = true;
            }
        }
        public void GO_()
        {
            if (pole[y[n - 1], x[n - 1]] == '0')
            {
                gameover = true;
            }
            else
            {
                pole[y[n - 1], x[n - 1]] = '0';
            }

        }
        public void Moving()
        {
            if (o == 0)
            {
                if (syel == true)
                {
                    n++;
                    x[n - 1] = x[n - 2];
                    y[n - 1] = y[n - 2];
                    if (y[n - 1] + 1 != 10)
                    {
                        y[n - 1] = y[n - 1] + 1;
                    }
                    else
                    {
                        y[n - 1] = 0;
                    }
                    this.GO_();
                    syel = false;

                }
                else
                {
                    pole[y[0], x[0]] = '.';
                    this.For_();
                    if (y[n - 1] + 1 != 10)
                    {
                        y[n - 1] = y[n - 1] + 1;
                    }
                    else
                    {
                        y[n - 1] = 0;
                    }
                    this.Eat();
                    this.GO_();
                }
            } // down
            if (o == 1)
            {
                if (syel == true)
                {
                    n++;
                    x[n - 1] = x[n - 2];
                    y[n - 1] = y[n - 2];
                    if (x[n - 1] - 1 != -1)
                    {
                        x[n - 1] = x[n - 1] - 1;
                    }
                    else
                    {
                        x[n - 1] = 9;
                    }
                    this.GO_();
                    syel = false;

                }
                else
                {
                    pole[y[0], x[0]] = '.';
                    this.For_();
                    if (x[n - 1] - 1 != -1)
                    {
                        x[n - 1] = x[n - 1] - 1;
                    }
                    else
                    {
                        x[n - 1] = 9;
                    }
                    this.Eat();
                    this.GO_();
                }
            } // left
            if (o == 2)
            {
                if (syel == true)
                {
                    n++;
                    x[n - 1] = x[n - 2];
                    y[n - 1] = y[n - 2];
                    if (y[n - 1] - 1 != -1)
                    {
                        y[n - 1] = y[n - 1] - 1;
                    }
                    else
                    {
                        y[n - 1] = 9;
                    }
                    this.GO_();
                    syel = false;

                }
                else
                {
                    pole[y[0], x[0]] = '.';
                    this.For_();
                    if (y[n - 1] - 1 != -1)
                    {
                        y[n - 1] = y[n - 1] - 1;
                    }
                    else
                    {
                        y[n - 1] = 9;
                    }
                    this.Eat();
                    this.GO_();
                }
            } // up
            if (o == 3)
            {
                if (syel == true)
                {
                    n++;
                    x[n - 1] = x[n - 2];
                    y[n - 1] = y[n - 2];
                    if (x[n - 1] + 1 != 10)
                    {
                        x[n - 1] = x[n - 1] + 1;
                    }
                    else
                    {
                        x[n - 1] = 0;
                    }
                    this.GO_();
                    syel = false;

                }
                else
                {
                    pole[y[0], x[0]] = '.';
                    this.For_();
                    if (x[n - 1] + 1 != 10)
                    {
                        x[n - 1] = x[n - 1] + 1;
                    }
                    else
                    {
                        x[n - 1] = 0;
                    }
                    this.Eat();
                    this.GO_();
                }
            } // right
        }
        public void Otrisovka()
        {
            Console.SetCursorPosition(0, 0);
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write(pole[i, j] + " ");
                }
                Console.WriteLine();
            }
        } 
        public void Apple()
        {
            Random random = new Random();
            while (!apple)
            {
                xa = random.Next(0, 10);
                ya = random.Next(0, 10);
                if (pole[ya,xa] == '.')
                {
                    apple = true;
                    pole[ya, xa] = '@';
                }
            }
        } // apple_generation
        /*public void Control()
        {

        }*/
    }
}
