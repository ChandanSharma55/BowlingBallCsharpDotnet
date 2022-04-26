using BowlingBall.Models;

namespace BowlingBall
{
    public static class Extensions
    {
        public static int GetScoreFromFrame(this Frame frame)
        {
            return frame.firstRoll + frame.secondRoll + frame.bonusScore;
        }
    }
}
