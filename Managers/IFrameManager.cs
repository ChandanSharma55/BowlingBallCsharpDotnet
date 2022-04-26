using BowlingBall.Models;

namespace BowlingBall.Managers
{
    public interface IFrameManager
    {
        Frame CreateFrame(int firstRoll, int secondRoll, int thirdRoll = 0);
    }
}