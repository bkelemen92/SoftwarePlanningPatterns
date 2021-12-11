using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareDesignPatterns.Entities;

namespace SoftwareDesignPatterns
{
    public partial class Form1 : Form
    {
        private List<Ball> _balls = new List<Ball>();
        Timer createTimer = new Timer { Interval = 3000, Enabled = true };
        Timer conveyorTimer = new Timer { Interval = 10, Enabled = true };



        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Factory = new BallFactory();
            createTimer.Tick += CreateTimer_Tick;
            conveyorTimer.Tick += ConveyorTimer_Tick;
        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _balls.Add(ball);
            ball.Left = -ball.Width;
            mainPanel.Controls.Add(ball);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _balls)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition) maxPosition = ball.Left;
            }
            if(maxPosition > mainPanel.Width)
            {
                var oldestBall = _balls[0];
                mainPanel.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);
            }
        }

        

        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
    }
}
