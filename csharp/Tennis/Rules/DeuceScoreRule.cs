namespace Tennis.Rules
{
    public class DeuceScoreRule : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return "Deuce";
        }

        public bool IsMatch(GameState gameState)
        {
            return gameState.PointsPlayer1 == gameState.PointsPlayer2 && gameState.PointsPlayer1 > 2;
        }
    }
}
