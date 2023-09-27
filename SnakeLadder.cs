using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPrograms
{
    internal class SnakeLadder
    {
        public void start()
        {
            int position = 0;
            int player_one;
            player_one = position;
            Console.WriteLine("player one position is {0}", player_one);
            player_one = roll_die();
            Console.WriteLine("player one rolled the dice and got the position {0}", player_one);
        }

        public int roll_die()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;

        }
        public void Board()
        {
            start();

        }
    }
}
    

