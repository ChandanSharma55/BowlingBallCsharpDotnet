using BowlingBall.Models;

namespace BowlingBall.Managers
{
    public interface IScoreManager
    {
        int Score(List<Frame> _frames);
    }
}