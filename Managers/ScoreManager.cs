using BowlingBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Managers
{
    public class ScoreManager : IScoreManager
    {
        public int Score(List<Frame> _frames)
        {
            _frames.Add(new Open(0, 0));
            _frames.Add(new Open(0, 0));
            for (int i = 0; i < 10; i++)
            {
                _frames[i].BonusPoints(_frames[i + 1], _frames[i + 2]);
            }

            int result = 0;
            _frames.ForEach(frame => result += frame.GetScoreFromFrame());

            return result;
        }
    }
}
