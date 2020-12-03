using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class FractalTree : Fractal
    {
        public override float BaseLengthRatio => 10;

        public double FirstAngleDelta { get; set; } = Math.PI / 18;

        public double SecondAngleDelta { get; set; } = Math.PI / 18;

        public float LengthRatio  { get; set; } = (float)0.8;

        public override int Width
            => Math.Min(2 * (int)CalculateWidth(Iterations, 0, BaseLength,
                Math.PI / 2) + 1, 3000);

        public override int Height
            => Math.Min((int)CalculateHeight(Iterations, 0, BaseLength, 
                Math.PI / 2) + 1, 3000);

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

        private void DrawLayer(int iteration, float x, float y, 
            float length, double angle)
        {
            float x1 = (float)(x + length * Math.Cos(angle));
            float y1 = (float)(y - length * Math.Sin(angle));
            Graphics.DrawLine(new Pen(Colors[Iterations - iteration], 2), 
                x, y, x1, y1);
            if (iteration == 1) 
            {
                return;
            }
            length *= LengthRatio;
            DrawLayer(iteration - 1, x1, y1, length, 
                angle + FirstAngleDelta);
            DrawLayer(iteration - 1, x1, y1, length, 
                angle - SecondAngleDelta);
        }
    }
}
