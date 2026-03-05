using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class LimitedIntBlock : BaseBlock
    {
        
        private double _min;
        private double _max;
        private double sum;
        private int dt;
        private double prev = 0;
        public double Sum { get; set; }

        public LimitedIntBlock(double min, double max, int dt)
        {
            _max = max;
            _min = min;
            this.dt = dt;
        }

        public override double Calc(double x)
        {
            sum += (prev + x) * dt / 2;
            if (sum > _max) sum = _max;
            if (sum < _min) sum = _min;
            prev = x;
            return sum;
        }

    }
}
