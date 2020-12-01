using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class CantorSet : Fractal
    {
        public override int Width
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override int Height
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override void Draw()
        {
            DrawLayer(0, 0, Width, Iterations);
        }

        public void DrawLayer(float x, float y, float width, int iteration)
        {
            if (iteration == 0) 
            { 
                return; 
            }
            using (var brush = new SolidBrush(Colors[iteration]))
            {
                Graphics.FillRectangle(brush, new RectangleF(x, y, width, Height / 20));
            }
            DrawLayer(x, y + Height / 10, width / 3, iteration - 1);
            DrawLayer(x + width * 2 / 3, y + Height / 10, 
                width / 3, iteration - 1);
        }
    }
}
