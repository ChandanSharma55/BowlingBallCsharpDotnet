using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Models
{
    public abstract class Frame
    {
        public int firstRoll { get; set; }
        public int secondRoll { get; set; }
        public int bonusScore { get; set; }

        public abstract void BonusPoints(Frame nextFrame, Frame secondNextFrame);

    }
}
