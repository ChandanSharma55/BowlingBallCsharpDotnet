using BowlingBall.Models;

namespace BowlingBall.Managers
{
    public class FrameManager : IFrameManager
    {
        public Frame CreateFrame(int firstRoll, int secondRoll, int thirdRoll = 0)
        {
            if (thirdRoll != 0)
                return new LastFrame(firstRoll, secondRoll, thirdRoll);
            if (firstRoll == 10)
                return new Strike();
            if (firstRoll + secondRoll == 10)
                return new Spare(firstRoll, secondRoll);

            return new Open(firstRoll, secondRoll);
        }
    }
}
