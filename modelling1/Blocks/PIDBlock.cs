using System;
using System.Collections.Generic;
using System.Text;

    namespace modelling1.Blocks
    {
    
        public class PIDBlock : BaseBlock
        {

            private GainBlock gain;
            private IntBlock integral;
            private DiffBlock diff;
            private double ki;

            public double K
            {
                get
                {
                    if (gain == null) throw new NullReferenceException();
                    return gain.Gain;
                }

                set
                {
                    if (gain != null)
                    {
                        gain.Gain = value;
                    }
                        
                }

            }

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

            public double Kd { get; set; }

            public PIDBlock(double dt)
            {

                this.gain = new GainBlock(1);

                this.integral = new IntBlock(dt);

                this.diff = new DiffBlock(dt);

            }

            public PIDBlock(double k, double ki, double kd, double dt)
            {

                this.K = k;

                this.Ki = ki;

                this.Kd = kd;

                this.gain = new GainBlock(k);

                this.integral = new IntBlock(dt);

                this.diff = new DiffBlock(dt);

            }

            public override double Calc(double x)
            {
                return gain.Calc(x + ki * integral.Calc(x) + Kd * diff.Calc(x));
            }
        }

    
    }
