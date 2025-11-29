using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    internal class JumpFormat
    {
        public bool IsJumped { get; set; }
        public List<int> CancelFrameList { get; set; }
        public String GetJumpExpression()
        {
            if (!IsJumped)
                return null;
            if (CancelFrameList.Count == 0)
                return "23f";
            else if (CancelFrameList.Count == 1)
                return $"{CancelFrameList[0]}f";
            StringBuilder sb = new StringBuilder();
            sb.Append($"({CancelFrameList[0]}");
            foreach (int i in CancelFrameList)
                sb.Append($" + {i}");
            sb.Append(")");
            return sb.ToString();
        }
        public int GetCancelFrameTick(int cancelIndex) // CancelIndex start from 0; Return start from 1
        {
            if (cancelIndex < 0 || cancelIndex >= CancelFrameList.Count )
            {
                throw new ArgumentOutOfRangeException(nameof(cancelIndex), cancelIndex, $"'{nameof(cancelIndex)}' cannot be negative");
            }
            int result = 0;
            for (int i = 0; i <= cancelIndex; i++)
                result += CancelFrameList[i];
            return result;
        }
        public int GetTotalDuration()
        {
            if (CancelFrameList.Count == 0)
                return 0;
            return GetCancelFrameTick(CancelFrameList.Count - 1);
        }
        public bool IsFullJump { get { return IsJumped && CancelFrameList.Count == 0; } }
        public bool IsNormalJump { get { return IsJumped && CancelFrameList.Count <= 1; } }
        public bool IsAdvancedJump { get { return IsJumped && CancelFrameList.Count >= 2; } }
        public bool IsJumpCancel { get { return IsAdvancedJump && CancelFrameList[0] == 1; } }
        public bool IsCactus { get { return IsAdvancedJump && CancelFrameList[0] >= 2; } }
    }
}
