namespace BowlingBall.Managers
{
    public interface IRollManager
    {
        int CalculateScore();
        void LastRoll(int roll1, int roll2, int roll3);
        void OpenOrSpareRoll(int roll1, int roll2);
        void StrikeRoll();
    }
}