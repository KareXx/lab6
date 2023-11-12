using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsEditor editor = new GraphicsEditor();

            Circle circle = new Circle(10, 20, 2);
            Group group = new Group();

            editor.AddPrimitive(circle);
           

            circle.Scale(2);
            circle.Move(20, 20);

            Rectangle rectangle = new Rectangle(0, 0, 10, 30);
            editor.AddPrimitive(rectangle);

            Triangle triangle = new Triangle(50, 10, 8);
            editor.AddPrimitive(triangle);

            group.AddMember(circle);
            group.AddMember(rectangle);
            group.AddMember(triangle);

            group.Move(20, 20);

            group.Draw();



            Console.ReadLine();
        }
    }
}
