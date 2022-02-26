namespace Tennis.Rules
{
    public class ScoreRule : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return $"{(ScorePoint)gameState.PointsPlayer1}-{(ScorePoint)gameState.PointsPlayer2}";
        }

        public bool IsMatch(GameState gameState)
        {
            return gameState.PointsPlayer1 < 4 && gameState.PointsPlayer2 < 4
                && gameState.PointsPlayer1 != gameState.PointsPlayer2;
        }
    }
}
