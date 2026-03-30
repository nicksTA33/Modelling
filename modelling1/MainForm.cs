using modelling1.Blocks;

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

        private ControlObject Tanks = new ControlObject(0,5, 0,5, 2, 1);
        





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

            (double Y1, double Y2) = Tanks.Calc();
            //Tanks.Z11 = 2;
            label1.Text = $"Level1={Y1}";

            Time += dt;
            FirstTank.Series[0].Points.AddXY(Time, Y1);
            SecondTank.Series[0].Points.AddXY(Time, Y2);


        }

        private void XinDOWN_Click(object sender, EventArgs e)
        {
            Tanks.Xin -= 1;
            
            LbXin.Text = $"{Tanks.Xin}";
        }

        private void XinUP_Click(object sender, EventArgs e)
        {
            Tanks.Xin += 1;
            
            LbXin.Text = $"{Tanks.Xin}";
        }

        private void Xout2DOWN_Click(object sender, EventArgs e)
        {
            Tanks.Xout2 -= 1;
            
            LbXout2.Text = $"{Tanks.Xout2}";
        }

        private void X2outUP_Click(object sender, EventArgs e)
        {
            Tanks.Xout2 += 1;
            
            LbXout2.Text = $"{Tanks.Xout2}";
        }

        private void X12DOWN_Click(object sender, EventArgs e)
        {
            Tanks.X12 -= 1;
          
            LbX12.Text = $"{Tanks.X12}";
        }

        private void X12UP_Click(object sender, EventArgs e)
        {
            Tanks.X12 += 1;
            
            LbX12.Text = $"{Tanks.X12}";
        }

        private void Xout1DOWN_Click(object sender, EventArgs e)
        {
            Tanks.Xout1 -= 1;
            
            LbXout1.Text = $"{Tanks.Xout1}";
        }

        private void Xout1UP_Click(object sender, EventArgs e)
        {
            Tanks.Xout1 += 1;
            
            LbXout1.Text = $"{Tanks.Xout1}";
        }

        private void TimeX10_Click(object sender, EventArgs e)
        {
            MainTimer.Interval = MainTimer.Interval / 10;
        }

        private void TimeX1_Click(object sender, EventArgs e)
        {
            MainTimer.Interval = MainTimer.Interval * 10;
        }
    }
}
