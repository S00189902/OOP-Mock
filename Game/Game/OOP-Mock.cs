using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player:IComparable<Player>
    {
        private readonly int _playerID = 0;

        public int PlayerID
        {
            get
            {
                return _playerID;
            }
        }

 
        

        public string PlayerName { get; set; }

        public int Score { get; set; }

        public static int HighScore { get; private set; }

        public Player(int id,string name , int score)
        {
            _playerID = id;
            PlayerName = name;
            Score = score;
        }

        public void IncreaseScore(int score)
        {
            this.Score += score;

            if (Score > HighScore)
                HighScore = Score;
        }
        public override string ToString()
        {
            return string.Format($"{_playerID,-15}{PlayerName,-15}{Score,-15}");
        }

        public int CompareTo(Player other)
        {
            return 5;
        }
    }
}
