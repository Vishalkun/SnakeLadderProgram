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
            int check_win;

            Console.WriteLine("player one position is {0}", player_one);

            while (player_one <= 100)
            {
                check_win = CheckWin(player_one);
                if (check_win == 1)
                {
                    Console.WriteLine("player won the game!!!");
                    break;

                }
                if (check_win == 2)
                {
                    position = 0;

                }
                else
                {
                    position = roll_die();
                }

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
                if (player_one > 100)
                {

                    player_one -= position;
                }
                Console.WriteLine("player one rolls the die and get the position {0}", player_one);
            }
        }

        public int CheckWin(int player_one)
        {
            if (player_one == 100)
            {
                return 1;
            }
            if (player_one > 100)
            {
                return 2;
            }
            else
            {
                return 0;
            }

        }

        readonly Random random = new Random();
        int dice_thrown = 0;

        public int roll_die()
        {
            int dice, check;
            dice = random.Next(1, 7);
            dice_thrown++;
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
            Console.WriteLine("number of time dice thrown is {0}", dice_thrown);

        }
    }
}
    

