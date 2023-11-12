using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    public class Triangle : GraphicPrimitive
    {
        public int Height { get; set; }

        public Triangle(int x, int y, int height)
        {
            X = x;
            Y = y;
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Height - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.SetCursorPosition(X + k, Y + i);
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(int factor)
        {
            Height *= factor;
        }
    }
}
