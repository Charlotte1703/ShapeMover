using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shape
{
    class ShapeRectangle : Shape
    {
        public ShapeRectangle(int x, int y, int width, int depth, Color fillColour, Color edgeColour)
            : base(x, y, width, depth, fillColour, edgeColour)
        {
        }

        public ShapeRectangle()
            : base(0, 0, 100, 70, Color.Red, Color.Black)
        {
        }

        public override void Draw(Graphics g)
        {

            Rectangle r = EnclosingRectangle();
            g.FillRectangle(new SolidBrush(FillColour), r);
            g.DrawRectangle(new Pen(EdgeColour), r);
        }
    }
}
