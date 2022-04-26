using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall.Models
{
    public class Strike : Frame
    {
        public Strike()
        {
            firstRoll = 10;
            secondRoll = 0;
        }
        public override void BonusPoints(Frame nextFrame, Frame secondNextFrame)
        {
            if(nextFrame is Strike)
            {
                bonusScore = 10 + secondNextFrame.firstRoll;
            }
            else
            {
                bonusScore = nextFrame.firstRoll + nextFrame.secondRoll; 
            }
        }
    }
}
