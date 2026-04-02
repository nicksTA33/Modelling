using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;

namespace modelling1.Blocks
{
    public class PIDExtBlock : BaseBlock
    {
        private double ki;
        private double k;
        private double kd;
        private double dt;
        private double intSum;
        private double xPrev;

        public double K {  get { return k; } set { k = value; } }
        
        public double Ki { get { return ki; } set { ki = value; } }

        public double Ti
        {

            get { return 1 / ki; }

            set
            {
                if (value == 0) throw new DivideByZeroException();

                ki = 1 / value;
            }

        }

        public double Kd { get { return kd; } set { kd = value; } }

        public bool AutoMode { get; set; } = true;

        public double Umanual { get; set; }

        public double UpLimit { get; set; } = 100;
        public double LowLimit { get; set; } = 0;

        public PIDExtBlock(double k, double ki, double kd, double dt)
        {
            this.K = k;
            this.Ki = ki;
            this.Kd = kd;
            this.dt = dt;
        }

        public override double Calc(double x)
        {
            
            if (AutoMode == true)
            {
                intSum += (xPrev + x) * dt / 2;
            }
            else
            {
                intSum = (Umanual - k * x - kd * (x - xPrev) / dt) / ki;
            }
            

            //intSum += (xPrev + x) * dt / 2;
            var u = k * x + intSum + kd * (x - xPrev) / dt;
            
            bool limited = false;

            if (u > UpLimit)
            {
                u = UpLimit;
                limited = true;
            }
            else if (u < LowLimit)
            {
                u = LowLimit;
                limited = true;
            }
            
            if (limited == true)
            {
                intSum = (u - k * x - kd * (x - xPrev) / dt) / ki;
            }
            





            xPrev = x;

            return u;
        }

    }
}
