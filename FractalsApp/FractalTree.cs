using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class FractalTree : Fractal
    {
        public override float BaseLengthRatio => 10;

        /// <summary>
        /// Values of the slope angle of the first segment.
        /// </summary>
        public double FirstAngleDelta { get; set; } = Math.PI / 18;

        /// <summary>
        /// Values of the slope angle of the second segment.
        /// </summary>
        public double SecondAngleDelta { get; set; } = Math.PI / 18;

        /// <summary>
        /// The ratio of the length of the segment to the previous one.
        /// </summary>
        public float LengthRatio  { get; set; } = (float)0.8;

        public override int Width
            => Math.Min(2 * (int)CalculateWidth(Iterations, 0, BaseLength,
                Math.PI / 2) + 1, 3000);

        public override int Height
            => Math.Min((int)CalculateHeight(Iterations, 0, BaseLength, 
                Math.PI / 2) + 1, 3000);

        /// <summary>
        /// This method calculates the width of the image.
        /// </summary>
        private float CalculateWidth(int iteration, float width,
            float length, double angle)
        {
            width += (float)(length * Math.Cos(angle));
            if (iteration == 1)
            {
                return width;
            }
            length *= LengthRatio;
            return Math.Max(CalculateHeight(iteration - 1, width,
                length, angle + FirstAngleDelta),
                CalculateHeight(iteration - 1, width,
                length, angle - SecondAngleDelta));
        }

        /// <summary>
        /// This method calculates the height of the image.
        /// </summary>
        private float CalculateHeight(int iteration, float height, 
            float length, double angle)
        {
            height += (float)(length * Math.Sin(angle));
            if (iteration == 1)
            {
                return height;
            }
            length *= LengthRatio;
            return Math.Max(CalculateHeight(iteration - 1, height,
                length, angle + FirstAngleDelta),
                CalculateHeight(iteration - 1, height,
                length, angle - SecondAngleDelta));
        }

        public override void Draw()
        {
            DrawLayer(Iterations, Width / 2, Height,
                BaseLength, Math.PI / 2);
        }

        /// <summary>
        /// Recursive method for drawing a fractal. 
        /// Draws a single layer at a single recursion step.
        /// </summary>
        private void DrawLayer(int iteration, float x, float y, 
            float length, double angle)
        {
            float xEnd = (float)(x + length * Math.Cos(angle));
            float yEnd = (float)(y - length * Math.Sin(angle));
            Graphics.DrawLine(new Pen(Colors[Iterations - iteration], 2), 
                x, y, xEnd, yEnd);
            if (iteration == 1) 
            {
                return;
            }
            length *= LengthRatio;
            DrawLayer(iteration - 1, xEnd, yEnd, length, 
                angle + FirstAngleDelta);
            DrawLayer(iteration - 1, xEnd, yEnd, length, 
                angle - SecondAngleDelta);
        }
    }
}
