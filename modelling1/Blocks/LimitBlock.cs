using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class LimitBlock : BaseBlock
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public LimitBlock(double Min, double Max)
        {
            this.Min = Min;
            this.Max = Max;
        }

        public override double Calc(double x)
        {
            if (x < Min) return Min;
            if (x > Max) return Max;
            return x;
        }
    }
}
