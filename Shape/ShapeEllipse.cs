using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shape
{
    class ShapeEllipse : Shape
    {
        public ShapeEllipse()
            : base(0, 0, 100, 50, Color.Green, Color.Black)
        {
        }

        public override void Draw(Graphics g)
        {
            Rectangle r = EnclosingRectangle();
            g.FillEllipse(new SolidBrush(FillColour), r);
            g.DrawEllipse(new Pen(EdgeColour), r);

        }
    }
}
