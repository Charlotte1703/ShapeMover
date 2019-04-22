using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shape
{
    class ShapeTriangle : Shape
    {
        public ShapeTriangle()
            : base(0, 0, 120, 120, Color.Cyan, Color.Black)
        {
        }

        public override void Draw(Graphics g)
        {
            Point[] pointList = new Point[3];
            pointList[0] = new Point(position.X, position.Y + Depth);
            pointList[1] = new Point(position.X + (Width / 2), position.Y);
            pointList[2] = new Point(position.X + Width, position.Y + Depth);

            g.FillPolygon(new SolidBrush(FillColour), pointList);
            g.DrawPolygon(new Pen(EdgeColour), pointList);
        
        }
    }
}
