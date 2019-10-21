using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            List<Player> playList = new List<Player>();

            playList.Add(player1);
            playList.Add(player2);
            playList.Add(player3);
            playList.Add(player4);
            playList.Add(player5);

            Console.WriteLine(player4.Score);

            Display(playList);
            DisplayPlayerDetails(playList);

            while (input != 0)
            {
                Console.WriteLine("PLease enter number of player you wish to add score for >>");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                       Player player= playList.ElementAt(input);
                        player.IncreaseScore(1);
                        Display(playList);
                        break;
                    case 2:
                        Player p2 = playList.ElementAt(input);
                        p2.IncreaseScore(1);
                        Display(playList);
                        break;
                    case 3:
                        Player p3 = playList.ElementAt(input);
                        p3.IncreaseScore(1);
                        Display(playList);
                        break;
                    case 4:
                        Player p4 = playList.ElementAt(input);
                        p4.IncreaseScore(1);
                        Display(playList);
                        break;
                    case 5:
                        Player p5 = playList.ElementAt(input);
                        p5.IncreaseScore(1);
                        Display(playList);
                        break;



                }
            }
        }
        private static void Display(List<Player> players)
        {
            foreach(Player player in players)
            {
                Console.Write($"{player.PlayerName,-15}");
            }
            Console.WriteLine();
            foreach(Player player in players)
            {
                
               Console.Write($"{player.Score,-15}");
            }
            Console.WriteLine();

        }
        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"PlayerID",-15}{"PLayer Name",-15}{"Score",-15}");
            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
