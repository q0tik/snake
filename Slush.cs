using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Slush
    {
        public ConsoleKeyInfo input;
        public void Listen()
        {
            while (true)
            {
                this.input = Console.ReadKey();
            }
        }
    }
}
