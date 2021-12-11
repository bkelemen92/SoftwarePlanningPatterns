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
using SoftwareDesignPatterns.Abstractions;

namespace SoftwareDesignPatterns
{
    public partial class Form1 : Form
    {
        private Toy _nextToy;
        private List<Toy> _toys = new List<Toy>();
        Timer createTimer = new Timer { Interval = 3000, Enabled = true };
        Timer conveyorTimer = new Timer { Interval = 10, Enabled = true };



        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Factory = new BallFactory();

            createTimer.Tick += CreateTimer_Tick;
            conveyorTimer.Tick += ConveyorTimer_Tick;

            Btn_Ball.Click += Btn_Ball_Click;
            Btn_Car.Click += Btn_Car_Click;
            Btn_Present.Click += Btn_Present_Click;
            
            Btn_BallColor.Click += ChangeColor;
            Btn_BoxColor.Click += ChangeColor;
            Btn_RibbonColor.Click += ChangeColor;
        }

        

        private void ChangeColor(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog { Color = button.BackColor };

            if (colorPicker.ShowDialog() != DialogResult.OK) return;
            button.BackColor = colorPicker.Color;
        }

        private void Btn_Ball_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory { BallColor = Btn_BallColor.BackColor };
        }

        private void Btn_Car_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }
        private void Btn_Present_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory { BoxColor = Btn_BoxColor.BackColor, RibbonColor = Btn_RibbonColor.BackColor };
        }



        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition) maxPosition = toy.Left;
            }
            if(maxPosition > mainPanel.Width)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void DisplayNext()
        {
            if (_nextToy != null) Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = Lbl_Next.Top + Lbl_Next.Height + 20;
            _nextToy.Left = Lbl_Next.Left;
            Controls.Add(_nextToy);
        }

        

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; DisplayNext(); }
        }
    }
}
