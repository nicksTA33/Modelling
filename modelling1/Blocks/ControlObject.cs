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
        

        //private double Xin = 0, Xout1 = 0, Xout2 = 0, X12 = 0;
        private double Gin = 1, Gout1 = 1, Gout2 = 1, Gout3 = 0.1, G12 = 1;
        private double Y1prev = 0;
        //private double Z11 = 2;

        public double Xin 
        { 
            get;
            set { XLimit.Calc(value); } 
        }
        public double Xout1
        {
            get;
            set { XLimit.Calc(value); }
        }
        public double Xout2
        {
            get;
            set { XLimit.Calc(value); }
        }
        public double X12
        {
            get;
            set { XLimit.Calc(value); }
        }

        public double Z11 { get; set; }

        public ControlObject(double min1, double max1, double min2, double max2, int dt)
        {
            Tank1 = new LimitedIntBlock(min1, max1, dt);
            Tank2 = new LimitedIntBlock(min1, max1, dt);
        }

        public (double, double) Calc()
        {
            double Level1 = (Gin * Xin / 100) - (Gout2 * Xout2 / 100) - (G12 * X12 / 100);

            if (Tank1.Sum > Z11)
            {
                Gout3 = 0.1;
            }
            else
            {
                Gout3 = 0;
            }

            Level1 -= Gout3;


            double Level2 = (G12 * X12 / 100) - (Gout1 * Xout1 / 100);
            double Y1 = Tank1.Calc(Level1);
            double Y2 = Tank2.Calc(Level2);

            return (Y1, Y2);
        }
    }
}
