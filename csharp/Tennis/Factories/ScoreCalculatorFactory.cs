using System;
using System.Linq;
using Tennis.Rules;
using Tennis.RulesEngines;

namespace Tennis.Factories
{
    public static class ScoreCalculatorFactory
    {
        public static ScoreCalculator CreateInstance()
        {
            var scoreRule = typeof(IScoreRule);
            var scoreRuleEngine = new ScoreRuleEngine(
                    typeof(ScoreRule).Assembly.GetTypes()
                    .Where(type => scoreRule.IsAssignableFrom(type) && !type.IsInterface)
                    .Select(rule => Activator.CreateInstance(rule) as IScoreRule));
            return new ScoreCalculator(scoreRuleEngine);
        }
    }
}
