using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class FractalTree : Fractal
    {
        public double FirstAngleDelta { get; set; } = Math.PI / 18;

        public double SecondAngleDelta { get; set; } = Math.PI / 18;

        public float LengthRatio  { get; set; } = (float)0.8;

        public override int Width
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override int Height
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override void Draw()
        {
            DrawLayer(Iterations, Canvas.Width / 2, Canvas.Height,
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
                angle + SecondAngleDelta);
        }
    }
}
