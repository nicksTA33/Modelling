using modelling1.Blocks;
using modelling2;


namespace modelling1
{
    public partial class MainForm : Form
    {
        //private double Xin = 0, Xout1 = 0, Xout2 = 0, X12 = 0;
        //private double Gin = 1, Gout1 = 1, Gout2 = 1, Gout3 = 0.1, G12 = 1;
        //private double Z11 = 2;
        //private double Level1, Level2;
        //private double Y1, Y2;
        private double Time = 0;
        private int dt = 1;
        //private LimitedIntBlock Tank1 = new LimitedIntBlock(0, 5, 1);
        //private LimitedIntBlock Tank2 = new LimitedIntBlock(0, 5, 1);

        //private LimitBlock XLimit = new LimitBlock(0, 100);

        private ControlObject Tanks = new ControlObject(0, 5, 0, 5, 2, 1);
        private PIDExtBlock Regulator1 = new PIDExtBlock(2, 0.3, 2, 1);
        private PIDExtBlock Regulator2 = new PIDExtBlock(2, 0.3, 2, 1);
        private ControlSystem controlSystem;






        public MainForm()
        {
            InitializeComponent();
        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MainTimer.Stop();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controlSystem = new ControlSystem(Regulator1, Regulator2, Tanks, 1);
            //controlSystem.Setpoint1 = 3;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void MainTimer_Tick(object sender, EventArgs e)
        {
            /*
            Level1 = (Gin * Xin / 100) - (Gout2 * Xout2 / 100) - (G12 * X12 / 100);

            if (Y1 > Z11)
            {
                Gout3 = 0.1;
            }
            else
            {
                Gout3 = 0;
            }

            Level1 -= Gout3;


            Level2 = (G12 * X12 / 100) - (Gout1 * Xout1 / 100);
            */

            //(double Y1, double Y2) = Tanks.Calc();
            //Tanks.Z11 = 2;
            (double Y1, double Y2) = controlSystem.Calc();
            label1.Text = $"Level1={Y1}";
            LbXin.Text = $"{controlSystem.Xin:F1}";
            LbX12.Text = $"{controlSystem.X12:F1}";

            Time += dt;
            FirstTank.Series[0].Points.AddXY(Time, Y1);
            //FirstTank.Series[1].Points.AddXY(Time, Regulator1.);
            SecondTank.Series[0].Points.AddXY(Time, Y2);


        }

        private void XinDOWN_Click(object sender, EventArgs e)
        {
            controlSystem.Xin -= 1;

            LbXin.Text = $"{controlSystem.Xin}";
        }

        private void XinUP_Click(object sender, EventArgs e)
        {
            controlSystem.Xin += 1;

            LbXin.Text = $"{controlSystem.Xin}";
        }

        private void Xout2DOWN_Click(object sender, EventArgs e)
        {
            controlSystem.Xout2 -= 1;

            LbXout2.Text = $"{controlSystem.Xout2}";
        }

        private void X2outUP_Click(object sender, EventArgs e)
        {
            controlSystem.Xout2 += 1;

            LbXout2.Text = $"{controlSystem.Xout2}";
        }

        private void X12DOWN_Click(object sender, EventArgs e)
        {
            controlSystem.X12 -= 1;

            LbX12.Text = $"{controlSystem.X12}";
        }

        private void X12UP_Click(object sender, EventArgs e)
        {
            controlSystem.X12 += 1;

            LbX12.Text = $"{controlSystem.X12}";
        }

        private void Xout1DOWN_Click(object sender, EventArgs e)
        {
            controlSystem.Xout1 -= 1;

            LbXout1.Text = $"{controlSystem.Xout1}";
        }

        private void Xout1UP_Click(object sender, EventArgs e)
        {
            controlSystem.Xout1 += 1;

            LbXout1.Text = $"{controlSystem.Xout1}";
        }

        private void TimeX10_Click(object sender, EventArgs e)
        {
            MainTimer.Interval = MainTimer.Interval / 10;
        }

        private void TimeX1_Click(object sender, EventArgs e)
        {
            MainTimer.Interval = MainTimer.Interval * 10;
        }

        private void SetpointFirst_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(SetpointFirst.Text, out value))
            {
                controlSystem.Setpoint1 = value;
            }
        }

        private void SetpointSecond_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(SetpointSecond.Text, out value))
            {
                controlSystem.Setpoint2 = value;
            }
        }

        private void KpFirst_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(KpFirst.Text, out value))
            {
                controlSystem.reg1.K = value;
            }
        }

        private void TiFirst_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(TiFirst.Text, out value))
            {
                controlSystem.reg1.Ti = value;
                controlSystem.reg1.Ki = controlSystem.reg1.K / value;
            }
        }

        private void TdFirst_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(TdFirst.Text, out value))
            {
                controlSystem.reg1.Kd = value * controlSystem.reg1.K;
            }
        }

        private void KpSecond_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(KpSecond.Text, out value))
            {
                controlSystem.reg2.K = value;
            }
        }

        private void TiSecond_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(TiSecond.Text, out value))
            {
                controlSystem.reg2.Ti = value;
                controlSystem.reg2.Ki = controlSystem.reg2.K / value;
            }
        }

        private void TdSecond_TextChanged(object sender, EventArgs e)
        {
            double value;

            if (double.TryParse(TdSecond.Text, out value))
            {
                controlSystem.reg2.Kd = value * controlSystem.reg2.K;
            }
        }



        private void ChangeMode1_Click(object sender, EventArgs e)
        {
            controlSystem.Auto1 = !controlSystem.Auto1;
            ChangeMode1.Text = (controlSystem.Auto1 == true) ? "Auto 1" : "Manual 1";
        }

        private void ChangeMode2_Click(object sender, EventArgs e)
        {
            controlSystem.Auto2 = !controlSystem.Auto2;
            ChangeMode2.Text = (controlSystem.Auto2 == true) ? "Auto 2" : "Manual 2";
        }

        private void FirstLess_Click(object sender, EventArgs e)
        {

            controlSystem.Xin -= 1;



        }

        private void button2_Click(object sender, EventArgs e)
        {


            controlSystem.Xin += 1;

        }

        private void SecondLess_Click(object sender, EventArgs e)
        {
            controlSystem.X12 -= 1;


        }

        private void SecondMore_Click(object sender, EventArgs e)
        {
            controlSystem.X12 += 1;
        }

        private void Optimize_Click(object sender, EventArgs e)
        {
            var obj = new ControlObject(0, 5, 0, 0, 2, 1);
            Criterias.obj = obj;
            Criterias.maxTime = 100;
            Criterias.alpha = 1;
            


            double[] initial = { 2, 60, 4};
            var I1 = Criterias.I2tCriteria(initial);
            
            ShowProcess(initial, obj, FirstTank);
            double[] res = NelderMead.Optimize(Criterias.I2tCriteria, initial, 1e-06, 5000, 1, 0.5, 2);
            ShowProcess(res, obj, SecondTank);
            var I2 = Criterias.I2tCriteria(res);
            MessageBox.Show($"K={res[0]}, Ti = {res[1]}, Td = {res[2]}");
        }

        public void ShowProcess(double[] vars, ControlObject obj, int series)
        {
            var MaxTime = Criterias.maxTime;
            ControlSystem system = new ControlSystem(obj, dt);
            system.reg1 = new PIDExtBlock(dt);
            system.reg2 = new PIDExtBlock(dt);
            system.reg1.K = vars[0];
            system.reg1.Ti = vars[1];
            system.reg1.Kd = vars[2];
            system.Setpoint1 = 1;
            var StepCount = (int)(MaxTime / dt);
            FirstTank.Series[series].Points.Clear();

            for (int i = 0; i < StepCount; i++)
            {
                FirstTank.Series[series].Points.AddXY(system.Time, system.out1);
                system.Calc();

                
            }
        }

        public void ShowProcess(double[] vars, ControlObject obj, System.Windows.Forms.DataVisualization.Charting.Chart ch)
        {
            var MaxTime = Criterias.maxTime;
            ControlSystem system = new ControlSystem(obj, dt);
            system.reg1 = new PIDExtBlock(dt);
            system.reg2 = new PIDExtBlock(dt);
            system.reg1.K = vars[0];
            system.reg1.Ti = vars[1];
            system.reg1.Kd = vars[2];
            system.Setpoint1 = 1;
            var StepCount = (int)(MaxTime / dt);
            ch.Series[0].Points.Clear();

            for (int i = 0; i < StepCount; i++)
            {
                ch.Series[0].Points.AddXY(system.Time, system.out1);
                system.Calc();


            }
        }
    }
}
