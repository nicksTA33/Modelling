using modelling1.Blocks;

namespace modelling1
{
    public partial class MainForm : Form
    {
        private double Xin = 0, Xout1 = 0, Xout2 = 0, X12 = 0;
        private double Gin = 1, Gout1 = 1, Gout2 = 1, Gout3 = 0.1, G12 = 1;
        private double Z11 = 2;
        private double Level1, Level2;
        private double Y1, Y2;
        private double Time = 0;
        private int dt = 1;
        private LimitedIntBlock Tank1 = new LimitedIntBlock(0, 5, 1);
        private LimitedIntBlock Tank2 = new LimitedIntBlock(0, 5, 1);

        private LimitBlock XLimit = new LimitBlock(0, 100);


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
            Y1 = Tank1.Calc(Level1);
            Y2 = Tank2.Calc(Level2);
            //label1.Text = $"Level1={Y1}, Gout3={Gout3}, Xin={Xin}, Xout2={Xout2}, X12={X12}";

            Time += dt;
            FirstTank.Series[0].Points.AddXY(Time, Y1);
            SecondTank.Series[0].Points.AddXY(Time, Y2);


        }

        private void XinDOWN_Click(object sender, EventArgs e)
        {
            Xin -= 1;
            Xin = XLimit.Calc(Xin);
            LbXin.Text = $"{Xin}";
        }

        private void XinUP_Click(object sender, EventArgs e)
        {
            Xin += 1;
            Xin = XLimit.Calc(Xin);
            LbXin.Text = $"{Xin}";
        }

        private void Xout2DOWN_Click(object sender, EventArgs e)
        {
            Xout2 -= 1;
            Xout2 = XLimit.Calc(Xout2);
            LbXout2.Text = $"{Xout2}";
        }

        private void X2outUP_Click(object sender, EventArgs e)
        {
            Xout2 += 1;
            Xout2 = XLimit.Calc(Xout2);
            LbXout2.Text = $"{Xout2}";
        }

        private void X12DOWN_Click(object sender, EventArgs e)
        {
            X12 -= 1;
            X12 = XLimit.Calc(X12);
            LbX12.Text = $"{X12}";
        }

        private void X12UP_Click(object sender, EventArgs e)
        {
            X12 += 1;
            X12 = XLimit.Calc(X12);
            LbX12.Text = $"{X12}";
        }

        private void Xout1DOWN_Click(object sender, EventArgs e)
        {
            Xout1 -= 1;
            Xout1 = XLimit.Calc(Xout1);
            LbXout1.Text = $"{Xout1}";
        }

        private void Xout1UP_Click(object sender, EventArgs e)
        {
            Xout1 += 1;
            Xout1 = XLimit.Calc(Xout1);
            LbXout1.Text = $"{Xout1}";
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
