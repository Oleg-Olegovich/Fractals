using System;
using System.Drawing;

namespace FractalsApp
{
    class SierpinskiTriangle : Fractal
    {
        public override float BaseLengthRatio => 2;

        public override int Width
            => Math.Min((int)BaseLength + 1, 3000);

        public override int Height
            => Math.Min((int)(1.5 * BaseLength) + 1, 3000);

        public override void Draw()
        {
            var topPoint = new PointF(BaseLength / 2, 5);
            var leftPoint = new PointF(0, 
                (float)(BaseLength * Math.Sqrt(3) / 2 + 5));
            var rightPoint = new PointF(BaseLength, 
                (float)(BaseLength * Math.Sqrt(3) / 2 + 5));
            DrawLayer(Iterations, topPoint, leftPoint, rightPoint, 0);
        }

        /// <summary>
        /// Recursive method for drawing a fractal. 
        /// Draws a single layer at a single recursion step.
        /// </summary>
        private void DrawLayer(int iteration, PointF topPoint, 
            PointF leftPoint, PointF rightPoint, int colorIndex)
        {
            // See if the recursion should stop.
            if (iteration == 1)
            {
                // Fill the triangle.
                PointF[] points =
                {
                    topPoint, rightPoint, leftPoint
                };
                // Draw a triangle between the points.
                Graphics.DrawPolygon(new Pen(Colors[colorIndex], 2), 
                    points);
            }
            else
            {
                // Find the edge midpoints.
                PointF leftMiddle = new PointF(
                    (topPoint.X + leftPoint.X) / 2f,
                    (topPoint.Y + leftPoint.Y) / 2f);
                PointF rightMiddle = new PointF(
                    (topPoint.X + rightPoint.X) / 2f,
                    (topPoint.Y + rightPoint.Y) / 2f);
                PointF bottomMiddle = new PointF(
                    (leftPoint.X + rightPoint.X) / 2f,
                    (leftPoint.Y + rightPoint.Y) / 2f);
                // Recursively draw smaller triangles.
                DrawLayer(iteration - 1, topPoint, 
                    leftMiddle, rightMiddle, colorIndex);
                DrawLayer(iteration - 1, leftMiddle, 
                    leftPoint, bottomMiddle, colorIndex + 1);
                DrawLayer(iteration - 1, rightMiddle, 
                    bottomMiddle, rightPoint, colorIndex + 2);
            }
        }
    }
}
