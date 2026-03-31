using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1.Blocks
{
    public class ControlObject
    {
        //private LimitedIntBlock Tank1 = new LimitedIntBlock(0, 5, 1);
        //private LimitedIntBlock Tank2 = new LimitedIntBlock(0, 5, 1);
        private LimitedIntBlock Tank1;
        private LimitedIntBlock Tank2;
        private LimitBlock XLimit = new LimitBlock(0, 100);
        

        private double xin = 0, xout1 = 0, xout2 = 0, x12 = 0;
        private double Gin = 1, Gout1 = 1, Gout2 = 1, Gout3 = 0.2, G12 = 1;
        private double Y1prev = 0;
        private double z11 = 0;

        public double Xin 
        {
            get { return xin; }
            set { xin = XLimit.Calc(value); } 
        }
        public double Xout1
        {
            get { return xout1; }
            set { xout1 = XLimit.Calc(value); }
        }
        public double Xout2
        {
            get { return xout2; }
            set { xout2 = XLimit.Calc(value); }
        }
        public double X12
        {
            get { return x12; }
            set { x12 = XLimit.Calc(value); }
        }

        public double Z11 
        {
            get { return z11; }
            set { z11 = value < 0 ? z11 = 0 : z11 = value; }
        }

        public ControlObject(double min1, double max1, double min2, double max2, double z11, int dt)
        {
            Tank1 = new LimitedIntBlock(min1, max1, dt);
            Tank2 = new LimitedIntBlock(min1, max1, dt);

            //this.z11 = z11 < 0 ? z11 = 0 : this.z11 = z11;
            this.z11 = 2;
        }

        public (double, double) Calc()
        {
            double Level1 = (Gin * xin / 100) - (Gout2 * xout2 / 100) - (G12 * x12 / 100);

            if (Y1prev > z11)
            {
                Gout3 = 0.2;
            }
            else
            {
                Gout3 = 0;
            }

            Level1 -= Gout3;


            double Level2 = (G12 * x12 / 100) - (Gout1 * xout1 / 100);
            double Y1 = Tank1.Calc(Level1);
            double Y2 = Tank2.Calc(Level2);
            Y1prev = Y1;
            return (Y1, Y2);
        }
    }
}
