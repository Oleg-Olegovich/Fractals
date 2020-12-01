using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FractalsApp
{
    class KochCurve : Fractal
    {
        public override int Width
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override int Height
            => Math.Min((int)(Iterations * BaseLength) + 1, 3000);

        public override void Draw()
        {
            Color deleteColor = Color.White;
            var pen1 = new Pen(Colors[0], 2);
            var pen2 = new Pen(deleteColor, 2);
            //Определим координаты исходного треугольника
            var point1 = new PointF(0, Height - Height / 20);
            var point2 = new PointF(Width, Height - Height / 20);
            var point3 = new PointF(Width / 2, Height * 2);
            Graphics.DrawLine(pen1, point1, point2);
            DrawLayer(point1, point2, point3, pen1, pen2, Iterations);
        }

        public void DrawLayer(PointF p1, PointF p2, PointF p3, 
            Pen pen1, Pen deletePen, int iteration)
        {
            if (iteration == 0)
            {
                return;
            }
            pen1.Color = Colors[iteration];
            var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
            var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
            var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
            var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
            Graphics.DrawLine(pen1, p4, pn);
            Graphics.DrawLine(pen1, p5, pn);
            Graphics.DrawLine(deletePen, p4, p5);
            DrawLayer(p4, pn, p5, pen1, deletePen, iteration - 1);
            DrawLayer(pn, p5, p4, pen1, deletePen, iteration - 1);
            DrawLayer(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), 
                pen1, deletePen, iteration - 1);
            DrawLayer(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), 
                pen1, deletePen, iteration - 1);
        }
    }
}
