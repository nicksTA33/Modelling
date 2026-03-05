using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class DelayBlock : BaseBlock
    {

        private double dt;

        private int cnt;

        private Queue<double> delayQueue = new Queue<double>();

        public DelayBlock(double dt, double tau)
        {

            if (tau >= dt)
            {

                cnt = (int)(tau / dt);

            }

            else
            {

                throw new Exception("tau should be greater than dt");

            }

        }

        public override double Calc(double x)
        {

            delayQueue.Enqueue(x);

            if (delayQueue.Count > cnt)
            {

                return delayQueue.Dequeue();

            }

            else { return 0; }

        }

    }
}
