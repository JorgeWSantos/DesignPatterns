using System;

namespace DesignPatterns.Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            TenisPlayer tenisP = new TenisPlayer("mikel", new RunFast());
            tenisP.compete();
            tenisP.performRunning();
            tenisP.train();
            tenisP.defineTatics();

            Console.WriteLine("---");
            SoccerPlayer soccerP = new SoccerPlayer("ronaldin", new RunFast());
            soccerP.compete();
            soccerP.performRunning();
            soccerP.train();
            soccerP.defineTatics();

            Console.WriteLine("---");
            ChessPlayer chessP = new ChessPlayer("gurian", new RunNoWay());
            chessP.compete();
            chessP.performRunning();
            chessP.train();
            chessP.defineTatics();
        }
    }
}
