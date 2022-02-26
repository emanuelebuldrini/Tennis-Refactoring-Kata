using System;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private string player1Name;
        private string player2Name;
        private readonly ScoreCalculator scoreCalculator;
        private GameState gameState = new GameState();

        public TennisGame1(string player1Name, string player2Name, ScoreCalculator scoreCalculator)
        {
            this.scoreCalculator = scoreCalculator;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (player1Name == playerName)
            {
                gameState.PointsPlayer1 += 1;

            }
            else if (player2Name == playerName)
            {
                gameState.PointsPlayer2 += 1;
            }
            else
            {
                throw new ArgumentException($"Invalid player name:{playerName}");
            }
        }

        public string GetScore() => scoreCalculator.CalculateScore(gameState);

    }
}

