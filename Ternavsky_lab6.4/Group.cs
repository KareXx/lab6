using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._4
{
    public class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> members = new List<GraphicPrimitive>();

        public void AddMember(GraphicPrimitive member)
        {
            members.Add(member);
        }

        public override void Draw()
        {
            foreach (var member in members)
            {
                member.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            foreach (var member in members)
            {
                member.Move(x, y);
            }
        }

        public override void Scale(int factor)
        {
            foreach (var member in members)
            {
                member.Scale(factor);
            }
        }
    }
}
