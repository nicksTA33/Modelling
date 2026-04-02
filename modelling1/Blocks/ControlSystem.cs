using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace modelling1.Blocks
{
    public class ControlSystem
    {
        private double dt;
        public double Time = 0;
        

        private ControlObject obj;
        public PIDExtBlock reg1;
        public PIDExtBlock reg2;

        public bool Auto1
        {
            get { return reg1.AutoMode; }
            set { reg1.AutoMode = value; }
        }
        public bool Auto2
        {
            get { return reg2.AutoMode; }
            set { reg2.AutoMode = value; }
        }


        public double Xin 
        {
            get { return obj.Xin; }
            set { obj.Xin = value; }
        }

        public double Xout1
        {
            get { return obj.Xout1; }
            set { obj.Xout1 = value; }

        }


        public double Xout2
        {
            get { return obj.Xout2; }
            set { obj.Xout2 = value; }

        }

        public double X12
        {
            get { return obj.X12; }
            set { obj.X12 = value; }

        }

        public double Z11
        {
            get { return obj.Z11; }
            set { obj.Z11 = value; }

        }

        public double Setpoint1 { get; set; }
        public double Setpoint2 { get; set; }


        public ControlSystem(ControlObject obj, double dt)
        {
            this.obj = obj;
            this.dt = dt;

        }

        public ControlSystem(PIDExtBlock reg1, PIDExtBlock reg2, ControlObject obj, double dt)
        {
            this.obj = obj;
            this.dt = dt;
            this.reg1 = reg1;
            this.reg2 = reg2;

        }


        public (double, double) Calc()
        {
            (double Y1, double Y2) = obj.Calc();

            double error1 = Setpoint1 - Y1;
            double error2 = Setpoint2 - Y2;

            double U1 = reg1.Calc(error1);
            double U2 = reg2.Calc(error2);


            if(Auto1 == true)
            {
                Xin = U1;
            }
            else
            {
                reg1.Umanual = Xin;
            }

            if (Auto2 == true)
            {
                X12 = U2;
            }
            else
            {
                reg2.Umanual = X12;
            }


            //Xin = U1;
            //X12 = U2;

            return (Y1, Y2);
        }


        


    }
}
