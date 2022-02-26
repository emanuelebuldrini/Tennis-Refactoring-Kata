using Tennis.RulesEngines;

namespace Tennis
{
    public class ScoreCalculator
    {
        private readonly ScoreRuleEngine scoreRuleEngine;

        public ScoreCalculator(ScoreRuleEngine scoreRuleEngine)
        {
            this.scoreRuleEngine = scoreRuleEngine;
        }
        public string CalculateScore(GameState gameState)
        {
            return scoreRuleEngine.CalculateScore(gameState);
        }
    }
}
