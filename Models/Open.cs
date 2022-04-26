using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Models
{
    public class Open : Frame
    {
        public Open(int firstRoll, int secondRoll)
        {
            this.firstRoll = firstRoll;
            this.secondRoll = secondRoll;
        }
        public override void BonusPoints(Frame nextFrame, Frame secondNextFrame)
        {
        }
    }
}
