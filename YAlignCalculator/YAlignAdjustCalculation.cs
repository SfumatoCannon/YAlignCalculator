using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAlignCalculator
{
    internal class YAlignAdjustCalculation
    {
        public float StartY { get; set; }
        public float TargetYLeft { get; set; }
        public float TargetYRight { get; set; }
        public enum HeightLimitTypeEnum { None, Solid, Deadly };
        public HeightLimitTypeEnum HeightLimitType { get; set; }
        public int HeightLimitY { get; set; }
        public enum SearchStrategyEnum { Easiest, Fastest };
        public SearchStrategyEnum SearchStrategy { get; set; }

        public class AdditionalSettingsClass
        {
            public bool CanCactus { get; set; }
            public bool CanJumpCancel { get; set; }
            public bool PlatformLanding { get; set; }
            public bool SingleJumpOnly { get; set; }
            public bool NoBunnyHop { get; set; }
        };
        public AdditionalSettingsClass AdditionalSettings { get; set; }
    }
}
