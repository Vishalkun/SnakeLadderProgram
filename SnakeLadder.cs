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
            int position;
            int player_one = 3;

            Console.WriteLine("player one position is {0}", player_one);

            while (player_one <= 100)
            {
                position = roll_die();
                if (position == 0)
                {
                    Console.WriteLine("no play");
                    player_one += position;

                }
                if (player_one == 0 && position < 0)
                {
                    Console.WriteLine("this is snake bite @ 0");
                    player_one = 0;
                }
                if (player_one > 0 && position < 0)
                {
                    Console.WriteLine("this is a sanke bite");
                    player_one += position;
                    if (player_one < 0)
                    {
                        player_one = 0;
                    }
                }
                if (position > 0)
                {
                    Console.WriteLine("its a ladder");
                    player_one += position;
                }
                Console.WriteLine("player one rolls the die and get the position {0}", player_one);
            }
        }

        readonly Random random = new Random();

        public int roll_die()
        {
            int dice, check;
            dice = random.Next(1, 7);
            Console.WriteLine("dice={0} ", dice);
            check = check_play();

            if (check == 1)
            {
                return -dice;
            }
            if (check == 2)
            {
                return dice;
            }
            else
            {
                return 0;
            }

        }

        public int check_play()
        {
            int check = random.Next(1, 4);
            return check;
        }
        public void Board()
        {
            start();

        }
    }
}
    

