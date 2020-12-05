using System.Drawing;

namespace FractalsApp
{
    abstract class Fractal
    {
        /// <summary>
        /// Base value of the length of the fractal segment.
        /// This field is used by the property BaseLength.
        /// </summary>
        private protected float _baseLength = 100;

        /// <summary>
        /// Array of gradient colors.
        /// </summary>
        public Color[] Colors { get; set; }

        /// <summary>
        /// The instance of the Graphics class where 
        /// the fractal image is drawn.
        /// </summary>
        public Graphics Graphics { get; set; }

        /// <summary>
        /// Recursion depth of image rendering.
        /// </summary>
        public int Iterations { get; set; } = 1;

        /// <summary>
        /// Width of the fractal image.
        /// </summary>
        public abstract int Width { get; }

        /// <summary>
        /// Height of the fractal image
        /// </summary>
        public abstract int Height { get; }

        /// <summary>
        /// The ratio of the length of the base segment 
        /// to the height of the application window.
        /// </summary>
        public abstract float BaseLengthRatio { get; }

        /// <summary>
        /// Property for accessing the base length. This is 
        /// necessary to reduce the number of calculations 
        /// and implement polymorphism.
        /// </summary>
        public float BaseLength 
        { 
            get => _baseLength;
            set => _baseLength = value < 1 ? 1 : value;
        }

        /// <summary>
        /// Method for drawing a fractal image.
        /// </summary>
        public abstract void Draw();
    }
}