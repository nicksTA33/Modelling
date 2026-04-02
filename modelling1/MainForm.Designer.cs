using System.Windows.Forms.DataVisualization.Charting;

namespace modelling1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            StartButton = new Button();
            StopButton = new Button();
            ObjectPicture = new PictureBox();
            FirstTank = new Chart();
            SecondTank = new Chart();
            XinUP = new Button();
            XinDOWN = new Button();
            Xout1DOWN = new Button();
            Xout1UP = new Button();
            X12DOWN = new Button();
            X12UP = new Button();
            Xout2DOWN = new Button();
            X2outUP = new Button();
            MainTimer = new System.Windows.Forms.Timer(components);
            LbXout1 = new Label();
            LbX12 = new Label();
            LbXout2 = new Label();
            LbXin = new Label();
            TimeX10 = new Button();
            TimeX1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SetpointFirst = new TextBox();
            SetpointSecond = new TextBox();
            label4 = new Label();
            label5 = new Label();
            KpFirst = new TextBox();
            TiFirst = new TextBox();
            TdFirst = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            TdSecond = new TextBox();
            TiSecond = new TextBox();
            KpSecond = new TextBox();
            ChangeMode1 = new Button();
            ChangeMode2 = new Button();
            FirstLess = new Button();
            FirstMore = new Button();
            SecondLess = new Button();
            SecondMore = new Button();
            ((System.ComponentModel.ISupportInitialize)ObjectPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstTank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondTank).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(86, 37);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(86, 76);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(75, 23);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // ObjectPicture
            // 
            ObjectPicture.Image = (Image)resources.GetObject("ObjectPicture.Image");
            ObjectPicture.Location = new Point(238, 37);
            ObjectPicture.Name = "ObjectPicture";
            ObjectPicture.Size = new Size(590, 211);
            ObjectPicture.TabIndex = 2;
            ObjectPicture.TabStop = false;
            // 
            // FirstTank
            // 
            chartArea1.Name = "ChartArea1";
            FirstTank.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            FirstTank.Legends.Add(legend1);
            FirstTank.Location = new Point(12, 254);
            FirstTank.Name = "FirstTank";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ємність 1";
            FirstTank.Series.Add(series1);
            FirstTank.Size = new Size(590, 300);
            FirstTank.TabIndex = 3;
            FirstTank.Text = "First Tank";
            // 
            // SecondTank
            // 
            chartArea2.Name = "ChartArea1";
            SecondTank.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            SecondTank.Legends.Add(legend2);
            SecondTank.Location = new Point(608, 254);
            SecondTank.Name = "SecondTank";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ємність 2";
            SecondTank.Series.Add(series2);
            SecondTank.Size = new Size(590, 300);
            SecondTank.TabIndex = 4;
            SecondTank.Text = "Second Tank";
            // 
            // XinUP
            // 
            XinUP.Location = new Point(404, 26);
            XinUP.Name = "XinUP";
            XinUP.Size = new Size(24, 23);
            XinUP.TabIndex = 5;
            XinUP.Text = ">";
            XinUP.UseVisualStyleBackColor = true;
            XinUP.Click += XinUP_Click;
            // 
            // XinDOWN
            // 
            XinDOWN.Location = new Point(354, 26);
            XinDOWN.Name = "XinDOWN";
            XinDOWN.Size = new Size(24, 23);
            XinDOWN.TabIndex = 6;
            XinDOWN.Text = "<";
            XinDOWN.UseVisualStyleBackColor = true;
            XinDOWN.Click += XinDOWN_Click;
            // 
            // Xout1DOWN
            // 
            Xout1DOWN.Location = new Point(670, 209);
            Xout1DOWN.Name = "Xout1DOWN";
            Xout1DOWN.Size = new Size(24, 23);
            Xout1DOWN.TabIndex = 8;
            Xout1DOWN.Text = "<";
            Xout1DOWN.UseVisualStyleBackColor = true;
            Xout1DOWN.Click += Xout1DOWN_Click;
            // 
            // Xout1UP
            // 
            Xout1UP.Location = new Point(720, 209);
            Xout1UP.Name = "Xout1UP";
            Xout1UP.Size = new Size(24, 23);
            Xout1UP.TabIndex = 7;
            Xout1UP.Text = ">";
            Xout1UP.UseVisualStyleBackColor = true;
            Xout1UP.Click += Xout1UP_Click;
            // 
            // X12DOWN
            // 
            X12DOWN.Location = new Point(463, 209);
            X12DOWN.Name = "X12DOWN";
            X12DOWN.Size = new Size(24, 23);
            X12DOWN.TabIndex = 10;
            X12DOWN.Text = "<";
            X12DOWN.UseVisualStyleBackColor = true;
            X12DOWN.Click += X12DOWN_Click;
            // 
            // X12UP
            // 
            X12UP.Location = new Point(513, 209);
            X12UP.Name = "X12UP";
            X12UP.Size = new Size(24, 23);
            X12UP.TabIndex = 9;
            X12UP.Text = ">";
            X12UP.UseVisualStyleBackColor = true;
            X12UP.Click += X12UP_Click;
            // 
            // Xout2DOWN
            // 
            Xout2DOWN.Location = new Point(318, 162);
            Xout2DOWN.Name = "Xout2DOWN";
            Xout2DOWN.Size = new Size(24, 23);
            Xout2DOWN.TabIndex = 12;
            Xout2DOWN.Text = "<";
            Xout2DOWN.UseVisualStyleBackColor = true;
            Xout2DOWN.Click += Xout2DOWN_Click;
            // 
            // X2outUP
            // 
            X2outUP.Location = new Point(368, 162);
            X2outUP.Name = "X2outUP";
            X2outUP.Size = new Size(24, 23);
            X2outUP.TabIndex = 11;
            X2outUP.Text = ">";
            X2outUP.UseVisualStyleBackColor = true;
            X2outUP.Click += X2outUP_Click;
            // 
            // MainTimer
            // 
            MainTimer.Interval = 1000;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // LbXout1
            // 
            LbXout1.AutoSize = true;
            LbXout1.Location = new Point(695, 213);
            LbXout1.Name = "LbXout1";
            LbXout1.Size = new Size(25, 15);
            LbXout1.TabIndex = 13;
            LbXout1.Text = "000";
            // 
            // LbX12
            // 
            LbX12.AutoSize = true;
            LbX12.Location = new Point(488, 213);
            LbX12.Name = "LbX12";
            LbX12.Size = new Size(25, 15);
            LbX12.TabIndex = 14;
            LbX12.Text = "000";
            // 
            // LbXout2
            // 
            LbXout2.AutoSize = true;
            LbXout2.Location = new Point(342, 166);
            LbXout2.Name = "LbXout2";
            LbXout2.Size = new Size(25, 15);
            LbXout2.TabIndex = 15;
            LbXout2.Text = "000";
            // 
            // LbXin
            // 
            LbXin.AutoSize = true;
            LbXin.Location = new Point(378, 30);
            LbXin.Name = "LbXin";
            LbXin.Size = new Size(25, 15);
            LbXin.TabIndex = 16;
            LbXin.Text = "000";
            // 
            // TimeX10
            // 
            TimeX10.Location = new Point(86, 122);
            TimeX10.Name = "TimeX10";
            TimeX10.Size = new Size(75, 23);
            TimeX10.TabIndex = 18;
            TimeX10.Text = "Time 10x";
            TimeX10.UseVisualStyleBackColor = true;
            TimeX10.Click += TimeX10_Click;
            // 
            // TimeX1
            // 
            TimeX1.Location = new Point(86, 162);
            TimeX1.Name = "TimeX1";
            TimeX1.Size = new Size(75, 23);
            TimeX1.TabIndex = 19;
            TimeX1.Text = "Time 1x";
            TimeX1.UseVisualStyleBackColor = true;
            TimeX1.Click += TimeX1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(850, 45);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 21;
            label2.Text = "Setpoint for first tank:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(850, 76);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 22;
            label3.Text = "Setpoint for second tank:";
            // 
            // SetpointFirst
            // 
            SetpointFirst.Location = new Point(998, 38);
            SetpointFirst.Name = "SetpointFirst";
            SetpointFirst.Size = new Size(100, 23);
            SetpointFirst.TabIndex = 23;
            SetpointFirst.TextChanged += SetpointFirst_TextChanged;
            // 
            // SetpointSecond
            // 
            SetpointSecond.Location = new Point(998, 73);
            SetpointSecond.Name = "SetpointSecond";
            SetpointSecond.Size = new Size(100, 23);
            SetpointSecond.TabIndex = 24;
            SetpointSecond.TextChanged += SetpointSecond_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(850, 130);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 25;
            label4.Text = "First regulator parameters:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1053, 130);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 26;
            label5.Text = "Second regulator parameters:";
            // 
            // KpFirst
            // 
            KpFirst.Location = new Point(889, 158);
            KpFirst.Name = "KpFirst";
            KpFirst.Size = new Size(100, 23);
            KpFirst.TabIndex = 27;
            KpFirst.TextChanged += KpFirst_TextChanged;
            // 
            // TiFirst
            // 
            TiFirst.Location = new Point(889, 187);
            TiFirst.Name = "TiFirst";
            TiFirst.Size = new Size(100, 23);
            TiFirst.TabIndex = 28;
            TiFirst.TextChanged += TiFirst_TextChanged;
            // 
            // TdFirst
            // 
            TdFirst.Location = new Point(889, 216);
            TdFirst.Name = "TdFirst";
            TdFirst.Size = new Size(100, 23);
            TdFirst.TabIndex = 29;
            TdFirst.TextChanged += TdFirst_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(850, 161);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 30;
            label6.Text = "Kp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(850, 190);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 31;
            label7.Text = "Ti";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(850, 219);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 32;
            label8.Text = "Td";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1059, 219);
            label9.Name = "label9";
            label9.Size = new Size(20, 15);
            label9.TabIndex = 38;
            label9.Text = "Td";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1059, 190);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 37;
            label10.Text = "Ti";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1059, 161);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 36;
            label11.Text = "Kp";
            // 
            // TdSecond
            // 
            TdSecond.Location = new Point(1098, 216);
            TdSecond.Name = "TdSecond";
            TdSecond.Size = new Size(100, 23);
            TdSecond.TabIndex = 35;
            TdSecond.TextChanged += TdSecond_TextChanged;
            // 
            // TiSecond
            // 
            TiSecond.Location = new Point(1098, 187);
            TiSecond.Name = "TiSecond";
            TiSecond.Size = new Size(100, 23);
            TiSecond.TabIndex = 34;
            TiSecond.TextChanged += TiSecond_TextChanged;
            // 
            // KpSecond
            // 
            KpSecond.Location = new Point(1098, 158);
            KpSecond.Name = "KpSecond";
            KpSecond.Size = new Size(100, 23);
            KpSecond.TabIndex = 33;
            KpSecond.TextChanged += KpSecond_TextChanged;
            // 
            // ChangeMode1
            // 
            ChangeMode1.Location = new Point(1123, 9);
            ChangeMode1.Name = "ChangeMode1";
            ChangeMode1.Size = new Size(75, 23);
            ChangeMode1.TabIndex = 39;
            ChangeMode1.Text = "Manual 1";
            ChangeMode1.UseVisualStyleBackColor = true;
            ChangeMode1.Click += ChangeMode1_Click;
            // 
            // ChangeMode2
            // 
            ChangeMode2.Location = new Point(1123, 68);
            ChangeMode2.Name = "ChangeMode2";
            ChangeMode2.Size = new Size(75, 23);
            ChangeMode2.TabIndex = 40;
            ChangeMode2.Text = "Manual 2";
            ChangeMode2.UseVisualStyleBackColor = true;
            ChangeMode2.Click += ChangeMode2_Click;
            // 
            // FirstLess
            // 
            FirstLess.Location = new Point(1124, 37);
            FirstLess.Name = "FirstLess";
            FirstLess.Size = new Size(24, 23);
            FirstLess.TabIndex = 42;
            FirstLess.Text = "<";
            FirstLess.UseVisualStyleBackColor = true;
            FirstLess.Click += FirstLess_Click;
            // 
            // FirstMore
            // 
            FirstMore.Location = new Point(1174, 37);
            FirstMore.Name = "FirstMore";
            FirstMore.Size = new Size(24, 23);
            FirstMore.TabIndex = 41;
            FirstMore.Text = ">";
            FirstMore.UseVisualStyleBackColor = true;
            FirstMore.Click += button2_Click;
            // 
            // SecondLess
            // 
            SecondLess.Location = new Point(1124, 97);
            SecondLess.Name = "SecondLess";
            SecondLess.Size = new Size(24, 23);
            SecondLess.TabIndex = 44;
            SecondLess.Text = "<";
            SecondLess.UseVisualStyleBackColor = true;
            SecondLess.Click += SecondLess_Click;
            // 
            // SecondMore
            // 
            SecondMore.Location = new Point(1174, 97);
            SecondMore.Name = "SecondMore";
            SecondMore.Size = new Size(24, 23);
            SecondMore.TabIndex = 43;
            SecondMore.Text = ">";
            SecondMore.UseVisualStyleBackColor = true;
            SecondMore.Click += SecondMore_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1215, 576);
            Controls.Add(SecondLess);
            Controls.Add(SecondMore);
            Controls.Add(FirstLess);
            Controls.Add(FirstMore);
            Controls.Add(ChangeMode2);
            Controls.Add(ChangeMode1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(TdSecond);
            Controls.Add(TiSecond);
            Controls.Add(KpSecond);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TdFirst);
            Controls.Add(TiFirst);
            Controls.Add(KpFirst);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SetpointSecond);
            Controls.Add(SetpointFirst);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TimeX1);
            Controls.Add(TimeX10);
            Controls.Add(LbXin);
            Controls.Add(LbXout2);
            Controls.Add(LbX12);
            Controls.Add(LbXout1);
            Controls.Add(Xout2DOWN);
            Controls.Add(X2outUP);
            Controls.Add(X12DOWN);
            Controls.Add(X12UP);
            Controls.Add(Xout1DOWN);
            Controls.Add(Xout1UP);
            Controls.Add(XinDOWN);
            Controls.Add(XinUP);
            Controls.Add(SecondTank);
            Controls.Add(FirstTank);
            Controls.Add(ObjectPicture);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)ObjectPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstTank).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondTank).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private PictureBox ObjectPicture;
        private System.Windows.Forms.DataVisualization.Charting.Chart FirstTank;
        private System.Windows.Forms.DataVisualization.Charting.Chart SecondTank;
        private Button XinUP;
        private Button XinDOWN;
        private Button Xout1DOWN;
        private Button Xout1UP;
        private Button X12DOWN;
        private Button X12UP;
        private Button Xout2DOWN;
        private Button X2outUP;
        private System.Windows.Forms.Timer MainTimer;
        private Label LbXout1;
        private Label LbX12;
        private Label LbXout2;
        private Label LbXin;
        private Button TimeX10;
        private Button TimeX1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox SetpointFirst;
        private TextBox SetpointSecond;
        private Label label4;
        private Label label5;
        private TextBox KpFirst;
        private TextBox TiFirst;
        private TextBox TdFirst;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox TdSecond;
        private TextBox TiSecond;
        private TextBox KpSecond;
        private Button ChangeMode1;
        private Button ChangeMode2;
        private Button FirstLess;
        private Button FirstMore;
        private Button SecondLess;
        private Button SecondMore;
    }
}
