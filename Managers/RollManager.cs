using BowlingBall.Models;

namespace BowlingBall.Managers
{
    public class RollManager : IRollManager
    {
        private readonly IFrameManager _frameManager;
        private readonly IScoreManager _scoreManager;
        private static List<Frame> _frames;
        public RollManager(IFrameManager frameManager, IScoreManager scoreManager)
        {
            _frameManager = frameManager;
            _scoreManager = scoreManager;
            _frames = new List<Frame>();
        }
        public void OpenOrSpareRoll(int roll1, int roll2)
        {
            var frame = _frameManager.CreateFrame(roll1, roll2);
            _frames.Add(frame);
        }
        public void StrikeRoll()
        {
            var frame = _frameManager.CreateFrame(10, 0);
            _frames.Add(frame);
        }
        public void LastRoll(int roll1, int roll2, int roll3)
        {
            var frame = _frameManager.CreateFrame(roll1, roll2, roll3);
            _frames.Add(frame);
        }
        public int CalculateScore()
        {
            return _scoreManager.Score(_frames);
        }
    }
}
