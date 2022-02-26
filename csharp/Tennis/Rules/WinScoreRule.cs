﻿using System;

namespace Tennis.Rules
{
    public class WinScoreRule : IScoreRule
    {
        public string Evaluate(GameState gameState)
        {
            return $"Win for {(gameState.GapPlayer1 > 0 ? "player1" : "player2")}";
        }

        public bool IsMatch(GameState gameState)
        {
            return (gameState.PointsPlayer1 > 3 || gameState.PointsPlayer2 > 3) && Math.Abs(gameState.GapPlayer1) > 1;
        }
    }
}