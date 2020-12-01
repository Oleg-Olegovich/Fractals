using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class SierpinskiTriangle : Fractal
    {
        public override int Width
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override int Height
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override void Draw()
        {
            var topPoint = new PointF(0, Height - Height / 20);
            var leftPoint = new PointF(Width, Height - Height / 20);
            var rightPoint = new PointF(Width / 2, Height * 2);
            DrawLayer(Iterations, topPoint, leftPoint, rightPoint);
        }

        // Draw a triangle between the points.
        private void DrawLayer(int iteration, PointF topPoint, 
            PointF leftPoint, PointF rightPoint)
        {
            // See if we should stop.
            if (iteration == 0)
            {
                // Fill the triangle.
                PointF[] points =
                {
                    topPoint, rightPoint, leftPoint
                };
                using var brush = new SolidBrush(Colors[iteration]);
                Graphics.FillPolygon(brush, points);
            }
            else
            {
                // Find the edge midpoints.
                PointF left_mid = new PointF(
                    (topPoint.X + leftPoint.X) / 2f,
                    (topPoint.Y + leftPoint.Y) / 2f);
                PointF right_mid = new PointF(
                    (topPoint.X + rightPoint.X) / 2f,
                    (topPoint.Y + rightPoint.Y) / 2f);
                PointF bottom_mid = new PointF(
                    (leftPoint.X + rightPoint.X) / 2f,
                    (leftPoint.Y + rightPoint.Y) / 2f);

                // Recursively draw smaller triangles.
                DrawLayer(iteration - 1, topPoint, 
                    left_mid, right_mid);
                DrawLayer(iteration - 1, left_mid, 
                    leftPoint, bottom_mid);
                DrawLayer(iteration - 1, right_mid, 
                    bottom_mid, rightPoint);
            }
        }
    }
}
