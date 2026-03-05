using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class DiffBlock : BaseBlock
    {

        private double dt;

        private double prev = 0;

        public DiffBlock(double dt)
        {

            this.dt = dt;

        }

        public override double Calc(double x)
        {

            var y = (x - prev) / dt;

            prev = x;

            return y;

        }

    }
}
