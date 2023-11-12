using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    public class Rectangle : GraphicPrimitive
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1)
                    {
                        Console.SetCursorPosition(X + j, Y + i);
                        Console.Write("*"); 
                    }
                }
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override void Scale(int factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }
}
