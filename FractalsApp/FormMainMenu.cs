using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsApp
{
    public partial class FormMainMenu : Form
    {
        const int NumberOfColors = 21;

        enum MaxDepth
        {
            FractalTree = 20,
            CantorSet = 10,
            KochCurve = 10,
            SierpinskiCarpet = 10,
            SierpinskiTriangle = 10
        }

        private FractalTree _fractalTree
            = new FractalTree();

        private CantorSet _cantorSet
            = new CantorSet();

        private KochCurve _kochCurve
            = new KochCurve();

        private SierpinskiCarpet _sierpinskiCarpet
            = new SierpinskiCarpet();

        private SierpinskiTriangle _sierpinskiTriangle
            = new SierpinskiTriangle();

        private Fractal _fractal;

        public FormMainMenu()
        {
            InitializeComponent();
            _fractal = _fractalTree;
            _fractalTree.Canvas = pictureBoxOfFractal;
            _kochCurve.Canvas = pictureBoxOfFractal;
            _sierpinskiCarpet.Canvas = pictureBoxOfFractal;
            _sierpinskiTriangle.Canvas = pictureBoxOfFractal;
            _cantorSet.Canvas = pictureBoxOfFractal;
            comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
            textBoxFirstAngleDelta.Text = _fractalTree.FirstAngleDelta.ToString();
            textBoxSecondAngleDelta.Text = _fractalTree.SecondAngleDelta.ToString();
            textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            trackBarDepth.Maximum = (int)MaxDepth.FractalTree;
        }

        private void RedrawFractal()
        {
            _fractal.Iterations = trackBarDepth.Value;
            _fractal.BaseLength = trackBarScale.Value * (float)Height / 10;
            var firstAndLastColors = GetFirstAndLastColors();
            _fractal.Colors = CalculateColors(firstAndLastColors[0], 
                firstAndLastColors[1]);
            pictureBoxOfFractal.SetBounds(0, 0, _fractal.Width, 
                _fractal.Height);
            pictureBoxOfFractal.Invalidate();
        }

        private Color[] GetFirstAndLastColors()
        {
            var colors = new Color[2];
            try
            {
                colors[0] = ColorTranslator.FromHtml(textBoxFirstColor.Text);
                colors[1] = ColorTranslator.FromHtml(textBoxLastColor.Text);
            }
            catch (Exception)
            {
                ShowErrorMessage("Invalid color set." + Environment.NewLine 
                    + "Input format: #FFFFFF (in hexadecimal).");
                textBoxFirstColor.Text = "#000000";
                textBoxLastColor.Text = "#FFFFFF";
                colors[0] = Color.Black;
                colors[1] = Color.White;
            }
            return colors;
        }

        private void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Error!");
        }

        public Color[] CalculateColors(Color firstColor, Color lastColor)
        {
            var colors = new Color[NumberOfColors];

            int rMin = firstColor.R;
            int gMin = firstColor.G;
            int bMin = firstColor.B;

            int rMax = lastColor.R;
            int gMax = lastColor.G;
            int bMax = lastColor.B;

            for (int i = 0; i < NumberOfColors; ++i)
            {
                var rAverage = rMin + (rMax - rMin) * i / colors.Length;
                var gAverage = gMin + (gMax - gMin) * i / colors.Length;
                var bAverage = bMin + (bMax - bMin) * i / colors.Length;
                colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }
            return colors;
        }

        private void ButtonGoToGenerationClick(object sender, EventArgs e)
        {
            tableLayoutPanelOfGeneration.BringToFront();
        }

        private void ButtonGoToMainMenuClick(object sender, EventArgs e)
        {
            tableLayoutPanelOfMainMenu.BringToFront();
        }

        private void TrackBarDepthScroll(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        private void TrackBarScaleScroll(object sender, EventArgs e)
        {
            pictureBoxOfFractal.Scale((sender as TrackBar).Value);
            RedrawFractal();
        }

        private void ComboBoxTypesOfFractalsSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypesOfFractals.Text)
            {
                case "Wind-blown fractal tree":
                    _fractal = _fractalTree;
                    trackBarDepth.Maximum = (int)MaxDepth.FractalTree;
                    break;
                case "Koch Curve":
                    _fractal = _kochCurve;
                    trackBarDepth.Maximum = (int)MaxDepth.KochCurve;
                    break;
                case "Sierpinski Carpet":
                    _fractal = _sierpinskiCarpet;
                    trackBarDepth.Maximum = (int)MaxDepth.SierpinskiCarpet;
                    break;
                case "Sierpinski Triangle":
                    _fractal = _sierpinskiTriangle;
                    trackBarDepth.Maximum = (int)MaxDepth.SierpinskiTriangle;
                    break;
                case "Cantor Set":
                    _fractal = _cantorSet;
                    trackBarDepth.Maximum = (int)MaxDepth.CantorSet;
                    break;
                default:
                    ShowErrorMessage("Invalid fractal select." + Environment.NewLine
                        + "Select an option from the list.");
                    _fractal = _fractalTree;
                    break;
            }
            tableLayoutPanelOfFractalTreeSettings.Visible = _fractal == _fractalTree;
            RedrawFractal();
        }

        private void TextBoxFirstColorTextChanged(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        private void TextBoxLastColorTextChanged(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        private void TextBoxFirstAngleDeltaTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxFirstAngleDelta.Text, out double angle))
            {
                _fractalTree.FirstAngleDelta = angle;
                RedrawFractal();
            }
            else
            {
                ShowErrorMessage("Invalid first angle delta set." + Environment.NewLine
                    + "Enter a real number.");
                _fractalTree.FirstAngleDelta = Math.PI / 2;
                textBoxFirstAngleDelta.Text = _fractalTree.FirstAngleDelta.ToString();
            }
        }

        private void TextBoxSecondAngleDeltaTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxSecondAngleDelta.Text, out double angle))
            {
                _fractalTree.SecondAngleDelta = angle;
                RedrawFractal();
            }
            else
            {
                ShowErrorMessage("Invalid second angle delta set." 
                    + Environment.NewLine + "Enter a real number.");
                _fractalTree.SecondAngleDelta = Math.PI / 2;
                textBoxSecondAngleDelta.Text = _fractalTree.SecondAngleDelta.ToString();
            }
        }

        private void TextBoxLengthRatioTextChanged(object sender, EventArgs e)
        {

            if (float.TryParse(textBoxLengthRatio.Text, out float ratio)
                && ratio > 0 && ratio <= 1)
            {
                _fractalTree.LengthRatio = ratio;
                RedrawFractal();
            }
            else
            {
                ShowErrorMessage("Invalid ratio of the length set."
                    + Environment.NewLine + "Enter a real number in half-interval (0; 1].");
                _fractalTree.LengthRatio = (float)0.8;
                textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            }
        }

        private void FormMainMenuResize(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        private void PanelOfFractalImagePaint(object sender, PaintEventArgs e)
        {
            _fractal.Graphics = e.Graphics;
            _fractal.Draw();
        }
    }
}