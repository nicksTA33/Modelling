using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class GainBlock : BaseBlock
    {

        public double Gain { get; set; }

        public GainBlock(double Gain)
        {
            this.Gain = Gain;
        }

        public override double Calc(double x)
        {
            return Gain * x;
        }

    }
}
