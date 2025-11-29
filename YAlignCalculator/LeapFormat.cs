using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    internal class LeapFormat
    {
        public List<JumpFormat> JumpDeatilList { get; set; } 
        public List<int> JumpPauseList { get; set; } // JumpPauseList[0] is always 1
                                                     // JumpPauseList[i] start from 1
        public int JumpCount { get { return JumpDeatilList.Count; } }
        public int GetJumpFrameTick(int jumpIndex) // JumpIndex start from 0; Result start From 1 
        {
            if (jumpIndex < 0 || jumpIndex >= JumpDeatilList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(jumpIndex), jumpIndex, $"'{nameof(jumpIndex)}' cannot be negative");
            }
            int result = 1;
            for (int i = 0; i <= jumpIndex - 1; i++)
                result += JumpDeatilList[i].GetTotalDuration() + JumpPauseList[i] - 1;
            result += JumpPauseList[jumpIndex] - 1;
            return result;
        }
    }
}
