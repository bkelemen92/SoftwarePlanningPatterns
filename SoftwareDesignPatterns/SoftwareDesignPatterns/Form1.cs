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

        

        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
    }
}
