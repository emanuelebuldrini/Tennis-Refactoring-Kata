namespace Tennis
{
    public class GameState
    {
        public int PointsPlayer1 { get; set; }
        public int PointsPlayer2 { get; set; }

        public int GapPlayer1 => PointsPlayer1 - PointsPlayer2;
        public int GapPlayer2 => PointsPlayer2 - PointsPlayer1;
    }
}
