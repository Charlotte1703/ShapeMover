using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace Shape
{
    abstract class Shape
    {
        private Color fillColour;
        private Color edgeColour;

        protected Point position;
        protected int width;
        protected int depth;

        private bool isSelected;

        public Shape(int x, int y, int width, int height, Color fillColour, Color edgeColour)
        {
            position.X = x;
            position.Y = y;

            this.fillColour = fillColour;
            this.edgeColour = edgeColour;

            this.width = width;
            this.depth = height;
        }

        public abstract void Draw(Graphics g);

        public void SetXY(int x, int y)
        {
            position.X = x;
            position.Y = y;
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        public Color FillColour
        {
            get { return fillColour; }
            set { fillColour = value; }
        }

        public Color EdgeColour
        {
            get
            {
                if (isSelected)
                {
                    return (Color.White);
                }
                else
                {
                    return edgeColour;
                }
            }

            set { edgeColour = value; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        public Rectangle EnclosingRectangle()
        {
            return new Rectangle(position.X, position.Y, width, depth);
        }

        public void Move(int X, int Y)
        {
            position.X += X;
            position.Y += Y;
        }

       
    }
}
