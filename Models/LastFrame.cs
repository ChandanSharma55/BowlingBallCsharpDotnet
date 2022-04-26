using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Models
{
    public class LastFrame : Frame
    {
        public int thirdRoll { get; set; }
        public LastFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            this.firstRoll = firstRoll;
            this.secondRoll = secondRoll;
            this.thirdRoll = thirdRoll;
        }

        public override void BonusPoints(Frame nextFrame,Frame secondNextFrame)
        {
            bonusScore += thirdRoll;
        }
    }
}
