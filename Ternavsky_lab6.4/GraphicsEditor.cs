using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    public class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public void ScaleAll(int factor)
        {
            foreach (var primitive in primitives)
            {
                primitive.Scale(factor);
            }
        }
    }
}
