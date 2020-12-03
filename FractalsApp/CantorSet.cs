using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class CantorSet : Fractal
    {
        public float IterationDistance { get; set; } = 10;

        public float LayerHeight { get; set; }

        public override float BaseLengthRatio => 4;

        public override int Width
            => Math.Min((int)BaseLength + 1, 3000);

        public override int Height
            => Math.Min((int)(Iterations * (BaseLength 
                + IterationDistance)) + 1, 3000);

        public override void Draw()
        {
            DrawLayer(0, 0, BaseLength, Iterations);
        }

        public void DrawLayer(float x, float y, float width, int iteration)
        {
            using (var brush = new SolidBrush(Colors[Iterations - iteration]))
            {
                Graphics.FillRectangle(brush, new RectangleF(x, y, width, LayerHeight));
            }
            if (iteration == 1)
            {
                return;
            }
            DrawLayer(x, y + LayerHeight + IterationDistance, width / 3, iteration - 1);
            DrawLayer(x + width * 2 / 3, y + LayerHeight + IterationDistance, 
                width / 3, iteration - 1);
        }
    }
}
