namespace Tennis.Rules
{
    public class AllScoreRule : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return $"{(ScorePoint)gameState.PointsPlayer1}-All";
        }

        public bool IsMatch(GameState gameState)
        {
           return gameState.PointsPlayer1 == gameState.PointsPlayer2 && gameState.PointsPlayer1 < 3;
        }
    }
}
