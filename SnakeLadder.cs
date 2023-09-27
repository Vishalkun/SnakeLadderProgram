using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderPrograms
{
    public class SnakeLadder
    {

        public int play_game(int player_position, int turn)
        {
            int check_win;
            int position;
            while (player_position != win_position)
            {
                check_win = CheckWin(player_position);
                if (check_win == 1 && turn == 1)
                {
                    Console.WriteLine("player one wins!!");
                    break;

                }
                if (check_win == 1 && turn == 0)
                {
                    Console.WriteLine("player two wins!!");
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
                    player_position += position;
                }
                if (player_position == 0 && position < 0)
                {
                    Console.WriteLine("this is snake bite @ 0");
                    player_position = 0;

                }
                if (player_position > 0 && position < 0)
                {
                    Console.WriteLine("this is a sanke bite");
                    player_position += position;
                    if (player_position < 0)
                    {
                        player_position = 0;
                    }
                }
                if (position > 0)
                {
                    Console.WriteLine("its a ladder");
                    player_position += position;
                }
                if (player_position > win_position)
                {
                    player_position -= position;
                }
                if (turn == 1)
                {
                    Console.WriteLine("player one rolls dies and get position {0}", player_position);
                    break;
                }
                if (turn == 0)
                {
                    Console.WriteLine("player two rolls dies and get position {0}", player_position);
                    break;
                }
            }
            return player_position;

        }
        const int win_position = 100;
        const int start_position = 0;
        public void start()
        {
            int player;
            int player_one = start_position, player_two = start_position;
            Console.WriteLine("player one position is {0}", player_one);
            Console.WriteLine("player two position is {0}", player_two);
            int turn = 1;

            while (true)
            {
                if (turn == 1)
                {
                    Console.WriteLine("player one turn");
                    player = play_game(player_one, turn);
                    turn = 0;
                    if (player > player_one)
                    {
                        turn = 1;
                    }
                    player_one = player;
                }
                if (player_one == win_position)
                {
                    Console.WriteLine("player one wins");
                    break;
                }
                if (turn == 0)
                {
                    Console.WriteLine("player two turn");
                    player = play_game(player_two, turn);
                    turn = 1;
                    if (player > player_two)
                    {
                        turn = 0;
                    }
                    player_two = player;
                }
                if (player_two == win_position)
                {
                    Console.WriteLine("player two wins");
                    break;
                }
            }

        }

        public int CheckWin(int player_one)
        {
            if (player_one == win_position)
            {
                return 1;
            }
            if (player_one > win_position)
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
    

