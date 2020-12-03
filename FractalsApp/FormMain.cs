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
    public partial class FormMain : Form
    {
        enum MaxDepth
        {
            FractalTree = 15,
            CantorSet = 10,
            KochCurve = 10,
            SierpinskiCarpet = 7,
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

        public FormMain()
        {
            InitializeComponent();
            _fractal = _fractalTree;
            comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
            textBoxFirstAngleDelta.Text = _fractalTree.FirstAngleDelta.ToString();
            textBoxSecondAngleDelta.Text = _fractalTree.SecondAngleDelta.ToString();
            textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            trackBarDepth.Maximum = (int)MaxDepth.FractalTree;
            _kochCurve.BackColor = BackColor;
            panelOfCantorSetSettings.Visible = false;
            //tableLayoutPanelOfMainMenu.BringToFront();
        }

        private void RedrawFractal()
        {
            pictureBoxOfFractal.SetBounds(0, 0, 0, 0);
            _cantorSet.LayerHeight = trackBarScale.Value
                * float.Parse(textBoxLayerHeight.Text);
            _fractal.Iterations = trackBarDepth.Value;
            _fractal.BaseLength = trackBarScale.Value 
                * (float)Height / _fractal.BaseLengthRatio;
            var firstAndLastColors = GetFirstAndLastColors();
            _fractal.Colors = CalculateColors(firstAndLastColors[0],
                firstAndLastColors[1], 2 * _fractal.Iterations);
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

        private Color[] CalculateColors(Color firstColor, Color lastColor, int numberOfColors)
        {
            var colors = new Color[numberOfColors];

            int rMin = firstColor.R;
            int gMin = firstColor.G;
            int bMin = firstColor.B;

            int rMax = lastColor.R;
            int gMax = lastColor.G;
            int bMax = lastColor.B;

            for (int i = 0; i < numberOfColors; ++i)
            {
                var rAverage = rMin + (rMax - rMin) * i / colors.Length;
                var gAverage = gMin + (gMax - gMin) * i / colors.Length;
                var bAverage = bMin + (bMax - bMin) * i / colors.Length;
                colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }
            return colors;
        }

        private bool TryParseAngle(string input, out double angle)
        {
            if (double.TryParse(input, out angle)
                && angle > 0 && angle <= Math.PI / 2)
            {
                return true;
            }
            ShowErrorMessage("Invalid angle delta set." + Environment.NewLine
                    + "Enter a real number in half-interval (0; PI / 2].");
            angle = Math.PI / 2;
            return false;
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
            RedrawFractal();
        }

        private void ComboBoxTypesOfFractalsSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypesOfFractals.Text)
            {
                case "Wind-blown fractal tree":
                    _fractal = _fractalTree;
                    trackBarDepth.Maximum = (int)MaxDepth.FractalTree;
                    tableLayoutPanelOfFractalTreeSettings.Visible = true;
                    tableLayoutPanelOfFractalTreeSettings.BringToFront();
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
                    panelOfCantorSetSettings.Visible = true;
                    panelOfCantorSetSettings.BringToFront();
                    break;
                default:
                    ShowErrorMessage("Invalid fractal select." + Environment.NewLine
                        + "Select an option from the list.");
                    comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
                    break;
            }
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
            if (!TryParseAngle(textBoxFirstAngleDelta.Text, out double angle))
            {
                textBoxFirstAngleDelta.Text = angle.ToString();
            }
            _fractalTree.FirstAngleDelta = angle;
            RedrawFractal();
        }

        private void TextBoxSecondAngleDeltaTextChanged(object sender, EventArgs e)
        {
            if (!TryParseAngle(textBoxSecondAngleDelta.Text, out double angle))
            {
                textBoxSecondAngleDelta.Text = angle.ToString();
            }
            _fractalTree.SecondAngleDelta = angle;
            RedrawFractal();
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
                _fractalTree.LengthRatio = 0.8f;
                textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            }
        }

        private void FormMainMenuResize(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        private void PictureBoxOfFractalPaint(object sender, PaintEventArgs e)
        {
            _fractal.Graphics = e.Graphics;
            _fractal.Draw();
        }

        private void TextBoxIterationDistanceTextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxIterationDistance.Text, out float distance)
                && distance >= 1 && distance <= 500)
            {
                _cantorSet.IterationDistance = distance;
                RedrawFractal();
            }
            else
            {
                ShowErrorMessage("Invalid distance between iterations."
                    + Environment.NewLine + "Enter a real number in range [1; 500].");
                textBoxIterationDistance.Text = "10";
            }
        }

        private void TextBoxLayerHeightTextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxLayerHeight.Text, out float distance)
                && distance >= 5 && distance <= 100)
            {
                RedrawFractal();
            }
            else
            {
                ShowErrorMessage("Invalid layer height."
                    + Environment.NewLine + "Enter a real number in range [5; 100].");
                textBoxLayerHeight.Text = "10";
            }
        }
    }
}