using System;
using System.Drawing;

namespace FractalsApp
{
    class SierpinskiCarpet : Fractal
    {
        public override float BaseLengthRatio => 5;

        public override int Width
            => Math.Min((int)BaseLength + 2, 3000);

        public override int Height
            => Math.Min((int)BaseLength + 2, 3000);

        public override void Draw()
        {
            DrawLayer(Iterations, new RectangleF(0, 0, BaseLength, BaseLength), 0);
        }

        /// <summary>
        /// Recursive method for drawing a fractal. 
        /// Draws a single layer at a single recursion step.
        /// </summary>
        private void DrawLayer(int iteration, RectangleF rectangle, int colorIndex)
        {
            // See if the recursion should stop.
            if (iteration == 1)
            {
                // Fill the rectangle.
                using var brush = new SolidBrush(Colors[colorIndex]);
                Graphics.FillRectangle(brush, rectangle);
            }
            else
            {
                // Divide the rectangle into 9 pieces.
                float width = rectangle.Width / 3f;
                float x0 = rectangle.Left;
                float x1 = x0 + width;
                float x2 = x0 + width * 2f;
                float height = rectangle.Height / 3f;
                float y0 = rectangle.Top;
                float y1 = y0 + height;
                float y2 = y0 + height * 2f;
                // Recursively draw smaller carpets.
                DrawLayer(iteration - 1, new RectangleF(x0, y0, width, height), 
                    colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x1, y0, width, height), 
                    colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x2, y0, width, height), 
                    colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x0, y1, width, height), 
                    colorIndex + 1);
                DrawLayer(iteration - 1, new RectangleF(x2, y1, width, height), 
                    colorIndex + 1);
                DrawLayer(iteration - 1, new RectangleF(x0, y2, width, height), 
                    colorIndex + 2);
                DrawLayer(iteration - 1, new RectangleF(x1, y2, width, height), 
                    colorIndex + 2);
                DrawLayer(iteration - 1, new RectangleF(x2, y2, width, height), 
                    colorIndex + 2);
            }
        }
    }
}