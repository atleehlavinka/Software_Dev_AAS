using System;
using static System.Console;
namespace testSoccerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            SoccerPlayer mySoccerPlayer = new SoccerPlayer();
            mySoccerPlayer.PlayerName = "Lionel";
            mySoccerPlayer.JerseyNum = 9;
            mySoccerPlayer.Goals = 8;
            mySoccerPlayer.Assists = 35;

            WriteLine("The Soccer Player is {0}. Jersey is #{1}.", mySoccerPlayer.PlayerName, mySoccerPlayer.JerseyNum);
            WriteLine("Goals: {0}. Assists: {1}.", mySoccerPlayer.Goals, mySoccerPlayer.Assists);
        }
    }

    class SoccerPlayer
    {
        private string playerName;
        //private int jerseyNum;
        //private int goals;
        //private int assists;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
        public int JerseyNum { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
    }
}