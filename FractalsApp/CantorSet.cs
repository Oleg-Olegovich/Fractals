﻿using System;
using System.Drawing;

namespace FractalsApp
{
    class CantorSet : Fractal
    {
        /// <summary>
        /// Vertical distance between layers.
        /// </summary>
        public float IterationDistance { get; set; } = 10;

        /// <summary>
        /// Layer height (the height of each rectangle).
        /// </summary>
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

        /// <summary>
        /// Recursive method for drawing a fractal. 
        /// Draws a single layer at a single recursion step.
        /// </summary>
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
