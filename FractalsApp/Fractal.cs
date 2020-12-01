using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalsApp
{
    abstract class Fractal
    {
        private protected float _baseLength = 100;

        public Color StartColor { get; set; } = Color.Black;

        public Color EndColor { get; set; } = Color.Black;

        public Color[] Colors { get; set; } = new Color[]
        {
            Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
            Color.Black, Color.Black, Color.Black, Color.Black, Color.Black,
            Color.Black, Color.Black, Color.Black
        };

        public Control Canvas { get; set; }

        public Graphics Graphics { get; set; }

        public int Iterations { get; set; } = 1;

        public abstract int Width { get; }

        public abstract int Height { get; }

        public float BaseLength 
        { 
            get => _baseLength;
            set => _baseLength = value < 1 ? 1 : value;
        }

        public abstract void Draw();
    }
}