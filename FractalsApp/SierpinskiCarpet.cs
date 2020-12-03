using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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

        private void DrawLayer(int iteration, RectangleF rectangle, int colorIndex)
        {
            // See if we should stop.
            if (iteration == 1)
            {
                // Fill the rectangle.
                using var brush = new SolidBrush(Colors[colorIndex]);
                Graphics.FillRectangle(brush, rectangle);
            }
            else
            {
                // Divide the rectangle into 9 pieces.
                float wid = rectangle.Width / 3f;
                float x0 = rectangle.Left;
                float x1 = x0 + wid;
                float x2 = x0 + wid * 2f;

                float hgt = rectangle.Height / 3f;
                float y0 = rectangle.Top;
                float y1 = y0 + hgt;
                float y2 = y0 + hgt * 2f;

                // Recursively draw smaller carpets.
                DrawLayer(iteration - 1, new RectangleF(x0, y0, wid, hgt), colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x1, y0, wid, hgt), colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x2, y0, wid, hgt), colorIndex);
                DrawLayer(iteration - 1, new RectangleF(x0, y1, wid, hgt), colorIndex + 1);
                DrawLayer(iteration - 1, new RectangleF(x2, y1, wid, hgt), colorIndex + 1);
                DrawLayer(iteration - 1, new RectangleF(x0, y2, wid, hgt), colorIndex + 2);
                DrawLayer(iteration - 1, new RectangleF(x1, y2, wid, hgt), colorIndex + 2);
                DrawLayer(iteration - 1, new RectangleF(x2, y2, wid, hgt), colorIndex + 2);
            }
        }
    }
}