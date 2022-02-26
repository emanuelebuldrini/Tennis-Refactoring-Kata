using System.Collections.Generic;
using Tennis.Rules;
using System.Linq;

namespace Tennis.RulesEngines
{
    public class ScoreRuleEngine
    {
        private readonly IEnumerable<IScoreRule> rules;

        public ScoreRuleEngine(IEnumerable<IScoreRule> rules)
        {
            this.rules = rules;
        }

        public string CalculateScore(GameState gameState)
        {
            return rules.Single(rule => rule.IsMatch(gameState))
                .Evaluate(gameState);
        }
    }
}
