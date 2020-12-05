using System;
using System.Drawing;

namespace FractalsApp
{
    class KochCurve : Fractal
    {
        /// <summary>
        /// Width of the fractal (for calculations).
        /// </summary>
        private float FractalWidth
            => Math.Min(Iterations * BaseLength, 3000);

        /// <summary>
        /// Height of the fractal (for calculations).
        /// </summary>
        private float FractalHeight
            => Math.Min(Iterations * BaseLength, 3000);

        /// <summary>
        /// Background color (to remove unnecessary segments).
        /// </summary>
        public Color BackColor { get; set; } = Color.Gray;

        public override float BaseLengthRatio => 2;

        public override int Width
            => Math.Min((int)FractalWidth + 1, 3000);

        public override int Height
            => Math.Min((int)(FractalHeight - FractalHeight / (float)1.7) + 1, 3000);

        public override void Draw()
        {
            var pen = new Pen(Colors[0], 2);
            var eraser = new Pen(BackColor, 2);
            // Determine the coordinates of the base triangle.
            var leftPoint = new PointF(0, FractalHeight - FractalHeight / 20);
            var rightPoint = new PointF(FractalWidth, FractalHeight - FractalHeight / 20);
            var topPoint = new PointF(FractalWidth / 2, 2 * FractalHeight);
            DrawSegment(pen, leftPoint, rightPoint);
            DrawLayer(leftPoint, rightPoint, topPoint, pen, eraser, Iterations);
        }

        /// <summary>
        /// Recursive method for drawing a fractal. 
        /// Draws a single layer at a single recursion step.
        /// </summary>
        public void DrawLayer(PointF leftPoint, PointF rightPoint, PointF topPoint, 
            Pen pen, Pen eraser, int iteration)
        {
            if (iteration == 1)
            {
                return;
            }
            pen.Color = Colors[Iterations - iteration + 1];
            var point1 = new PointF((rightPoint.X + 2 * leftPoint.X) / 3, 
                (rightPoint.Y + 2 * leftPoint.Y) / 3);
            var point2 = new PointF((2 * rightPoint.X + leftPoint.X) / 3, 
                (leftPoint.Y + 2 * rightPoint.Y) / 3);
            var auxiliaryPoint = new PointF((rightPoint.X + leftPoint.X) / 2, 
                (rightPoint.Y + leftPoint.Y) / 2);
            var point3 = new PointF((4 * auxiliaryPoint.X - topPoint.X) / 3, 
                (4 * auxiliaryPoint.Y - topPoint.Y) / 3);
            DrawSegment(pen, point1, point3);
            DrawSegment(pen, point2, point3);
            DrawSegment(eraser, point1, point2);
            DrawLayer(point1, point3, point2, pen, eraser, iteration - 1);
            DrawLayer(point3, point2, point1, pen, eraser, iteration - 1);
            DrawLayer(leftPoint, point1, new PointF((2 * leftPoint.X + topPoint.X) / 3, 
                (2 * leftPoint.Y + topPoint.Y) / 3), pen, eraser, iteration - 1);
            DrawLayer(point2, rightPoint, new PointF((2 * rightPoint.X + topPoint.X) / 3, 
                (2 * rightPoint.Y + topPoint.Y) / 3), pen, eraser, iteration - 1);
        }

        /// <summary>
        /// General method for drawing segments.
        /// All points are raised for visual beauty.
        /// </summary>
        private void DrawSegment(Pen pen, PointF first, PointF second)
        {
            float heightDelta = FractalHeight / (float)1.7;
            Graphics.DrawLine(pen, new PointF(first.X, first.Y - heightDelta),
                new PointF(second.X, second.Y - heightDelta));
        }
    }
}
