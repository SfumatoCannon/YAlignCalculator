using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    internal class LeapFormat
    {
        public List<JumpFormat> JumpDetailList { get; set; } = new List<JumpFormat>();
        public List<int> JumpPauseList { get; set; } = new List<int>(); // JumpPauseList[0] is always 1
                                                                        // JumpPauseList[i] start from 1
        public int JumpCount { get { return JumpDetailList.Count; } }
        public void SetFromString(string leapFormatString)
        {
            JumpDetailList.Clear();
            JumpPauseList.Clear();
            string regexString = @"(?<=\()\d+(?:\+\d+)+(?=\))|\d+";
            string[] regexMatches = System.Text.RegularExpressions.Regex.Matches(leapFormatString, regexString)
                .Cast<System.Text.RegularExpressions.Match>()
                .Select(m => m.Value)
                .ToArray();
            if (regexMatches.Length == 0 || regexMatches.Length % 2 == 0)
            {
                throw new FormatException($"Invalid format: '{leapFormatString}' has no valid jump format.");
            }
            JumpPauseList.Add(1);
            for (int i = 0; i < regexMatches.Length; i += 2)
            {
                JumpFormat jumpFormat = new JumpFormat();
                try
                {
                    jumpFormat.SetFromString(regexMatches[i]);
                }
                catch (FormatException ex)
                {
                    throw new FormatException($"Invalid format: '{regexMatches[i]}' is not a valid jump format.", ex);
                }
                JumpDetailList.Add(jumpFormat);
                if (i + 1 < regexMatches.Length)
                {
                    if (int.TryParse(regexMatches[i + 1], out int jumpPause))
                    {
                        JumpPauseList.Add(jumpPause);
                    }
                    else
                    {
                        throw new FormatException($"Invalid format: '{regexMatches[i + 1]}' is not a valid integer.");
                    }
                }
            }
        }
        public int GetJumpFrameTick(int jumpIndex) // JumpIndex start from 0; Result start From 1 
        {
            if (jumpIndex < 0 || jumpIndex >= JumpDetailList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(jumpIndex), jumpIndex, $"'{nameof(jumpIndex)}' cannot be negative");
            }
            int result = 1;
            for (int i = 0; i <= jumpIndex - 1; i++)
                result += JumpDetailList[i].GetTotalDuration() + JumpPauseList[i] - 1;
            result += JumpPauseList[jumpIndex] - 1;
            return result;
        }
        public int GetTotalDuration()
        {
            if (JumpDetailList.Count == 0)
                return 0;
            return GetJumpFrameTick(JumpDetailList.Count - 1)
                + JumpDetailList[JumpDetailList.Count - 1].GetTotalDuration();
        }
    }
}
