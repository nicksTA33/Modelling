using modelling1.Blocks;
using System;
using System.Collections.Generic;
using System.Text;

namespace modelling1
{
    public class Criterias
    {
        public static double dt = 0.1;
        public static double maxTime = 10;
        public static double eps = 0.1;
        public static double alpha = 0;
        public static ControlObject obj;

        public static double I2tCriteria(double[] vars)
        {
            double sum=0;

            ControlSystem system = new ControlSystem(obj, dt);
            system.reg1 = new PIDExtBlock(dt);
            system.reg2 = new PIDExtBlock(dt);
            system.reg1.K = vars[0];
            system.reg1.Ti = vars[1];
            system.reg1.Kd = vars[2];
            

            var StepCount = (int)(maxTime / dt);

            for (int i = 0; i <  StepCount; i++)
            {
                system.Calc();

                sum += system.error1 * system.error1 * Math.Pow(system.Time, alpha) * dt;
            }



            return sum;
            
        }


        

    }
}
