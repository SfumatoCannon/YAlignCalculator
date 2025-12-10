using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    internal class YAlignAdjustOutputFormat
    {
        int Id { get; set; }
        float StartY { get; set; }
        float EndY { get; set; }
        List<LeapFormat> LeapList { get; set; }
        List<float> YProgressList { get; set; }
    }
}
