namespace Tennis.Rules
{
    public interface IScoreRule
    {
        string Evaluate(GameState gameState);
        bool IsMatch(GameState gameState);
    }
}
