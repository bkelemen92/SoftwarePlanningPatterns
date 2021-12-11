using SoftwareDesignPatterns.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics graphics)
        {
            graphics.DrawImage(Image.FromFile("Images/car.png"), new Rectangle(0, 0, Width, Height));
        }
    }
}
