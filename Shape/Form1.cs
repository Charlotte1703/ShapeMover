using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {

        List<Shape> shapeList;

        int moveSpeed = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shapeList = new List<Shape>();
            shapeList.Add(new ShapeRectangle());
            shapeList[0].Move(50, 50);
            shapeList.Add(new ShapeRectangle());
            shapeList[1].FillColour = Color.BlueViolet;
            shapeList.Add(new ShapeEllipse());
            shapeList[2].Move(120, 40);
            pictureBoxDisplay.Invalidate();
        }

        private void pictureBoxDisplay_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int i = 0;
            while (i < shapeList.Count)
            {
                Shape s = shapeList[i];
                s.Draw(g);
                i++;
            }
            
        }

        private void pbxDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            int mouseX;
            int mouseY;
            int i;
            int shapeChosenIndex = -1;

            mouseX = e.X;
            mouseY = e.Y;

            i = shapeList.Count - 1;
            bool found = false;
            bool shiftPressed = false;

            if (Control.ModifierKeys == Keys.Shift)
            {
                shiftPressed = true;
                }

            while ((i >= 0) && !found)
            {
                Shape s = shapeList[i];
                if ((s.Position.X < mouseX) &&
                    (s.Position.Y < mouseY) &&
                    ((s.Position.X + s.Width) > mouseX) &&
                    ((s.Position.Y + s.Depth) > mouseY))
                {
                    found = true;
                    shapeChosenIndex = i;
                }
                else
                {
                    i--;
                }
            }

            i = 0;
            while (i < shapeList.Count)
            {
                if (found && (i == shapeChosenIndex))
                {
                    shapeList[i].IsSelected = true;
                }
                else
                {
                    if (!shiftPressed)
                    {
                        shapeList[i].IsSelected = false;
                    }
                }
                
                
                i++;
            }

            pictureBoxDisplay.Invalidate();
        }

             private void MoveAllSelectedShapes(int x, int y)
        {
            int i = 0;
            Shape currentShape;
            while (i < shapeList.Count)
            {
                currentShape = shapeList[i];
                if (currentShape.IsSelected)
                {
                    currentShape.Move(x, y);
                }
                i++;
            }
            pictureBoxDisplay.Invalidate();
        
        }

             private void buttonLeft_Click(object sender, EventArgs e)
             {
                 if (Control.ModifierKeys == Keys.Shift)
                 {
                     MoveAllSelectedShapes(-moveSpeed * 10, 0);
                 }
                 else
                 {
                     MoveAllSelectedShapes(-moveSpeed, 0);
                 }
             }

             private void buttonRight_Click(object sender, EventArgs e)
             {
                 if (Control.ModifierKeys == Keys.Shift)
                 {
                     MoveAllSelectedShapes(moveSpeed * 10, 0);
                 }
                 else
                 {
                     MoveAllSelectedShapes(moveSpeed, 0);
                 }
             }

             private void buttonUp_Click(object sender, EventArgs e)
             {
                 if (Control.ModifierKeys == Keys.Shift)
                 {
                     MoveAllSelectedShapes(-moveSpeed * 10, 0);
                 }
                 else
                 {
                     MoveAllSelectedShapes(0, -moveSpeed);
                 }
             }

             private void buttonDown_Click(object sender, EventArgs e)
             {
                 if (Control.ModifierKeys == Keys.Shift)
                 {
                     MoveAllSelectedShapes(moveSpeed * 10 , 0);
                 }
                 else
                 {
                     MoveAllSelectedShapes(0, moveSpeed);
                 }
             }

             private void buttonAddRect_Click(object sender, EventArgs e)
             {
                 Shape newShape = new ShapeRectangle();
                 shapeList.Add(newShape);
                 pictureBoxDisplay.Invalidate();
             }

             private void buttonAddEllipse_Click(object sender, EventArgs e)
             {
                 Shape newShape = new ShapeEllipse();
                 shapeList.Add(newShape);
                 pictureBoxDisplay.Invalidate();
             }

             private void buttonAddTriangle_Click(object sender, EventArgs e)
             {
                 Shape newShape = new ShapeTriangle();
                 shapeList.Add(newShape);
                 pictureBoxDisplay.Invalidate();
             }

             private void buttonDelete_Click(object sender, EventArgs e)
             {
                 DeleteAllSelectedShapes();
             }
             private void DeleteAllSelectedShapes()
             {
                 int i = 0;
                 Shape currentShape;
                 while (i < shapeList.Count)
                 {
                     currentShape = shapeList[i];
                     if (currentShape.IsSelected)
                     {
                         shapeList.RemoveAt(i);
                     }
                     else
                     {
                         i++;
                     }

                 }

                 pictureBoxDisplay.Invalidate();
             }

             private void buttonChooseColour_Click(object sender, EventArgs e)
             {
                 colorDialog1.AllowFullOpen = true;
                 colorDialog1.ShowHelp = true;

                 if (colorDialog1.ShowDialog() == DialogResult.OK)
                 {
                     ColourSelectedShapes(colorDialog1.Color);
                 }
             }
             private void ColourSelectedShapes(Color newColour)
             {
                 int i = 0;
                 Shape currentShape;
                 while (i < shapeList.Count)
                 {
                     currentShape = shapeList[i];
                     if (currentShape.IsSelected)
                     {
                         currentShape.FillColour = newColour;
                     }
                     i++;
                 }
                 pictureBoxDisplay.Invalidate();

             }

             private void buttonBTF_Click(object sender, EventArgs e)
             {
                 BTFSelectedShapes();
             }

             private void BTFSelectedShapes()
             {
                 Shape shape;
                 int i = 0;

                 while (i < shapeList.Count)
                 {
                     shape = shapeList[i];
                     if (shape.IsSelected)
                     {
                         BTFShapeAtIndex(i);
                     }
                     i++;
                 }
                 pictureBoxDisplay.Invalidate();
             }
             private void BTFShapeAtIndex(int index)
             {
                 Shape shape = shapeList[index];
                 shapeList.RemoveAt(index);
                 shapeList.Add(shape);
             }
     }
}
