using System;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            if (m_score1 == m_score2)
            {
                return MapAllScore(m_score1);
            }
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                return MapAdvantageScore(m_score1, m_score2);
            }
            else
            {
                return $"{MapScore(m_score1)}-{MapScore(m_score2)}";
            }
        }

        private string MapScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";

                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    throw new ArgumentOutOfRangeException($"Invalid score: {score}");
            }
        }

        private string MapAllScore(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";

                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }

        private string MapAdvantageScore(int score1, int score2)
        {
            string score;
            var minusResult = score1 - score2;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

    }
}

