using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    public class Circle : GraphicPrimitive
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            for (int i = 0; i <= 360; i++)
            {
                double radians = i * (Math.PI / 180);
                int circleX = X + Convert.ToInt32(Radius * Math.Cos(radians));
                int circleY = Y + Convert.ToInt32(Radius * Math.Sin(radians));

                Console.SetCursorPosition(circleX, circleY);
                Console.Write("*"); 
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(int factor)
        {
            Radius = (int)(Radius * factor);
        }
    }
}
