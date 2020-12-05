using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FractalsApp
{
    public partial class FormMain : Form
    {
        private readonly string _endl = Environment.NewLine; 

        /// <summary>
        /// Maximum depth of recursions for drawing fractals. 
        /// Larger values can cause a stack overflow.
        /// </summary>
        enum MaxDepth
        {
            FractalTree = 15,
            CantorSet = 10,
            KochCurve = 10,
            SierpinskiCarpet = 7,
            SierpinskiTriangle = 10
        }

        /// <summary>
        /// The instance of a fractal tree.
        /// </summary>
        private FractalTree _fractalTree
            = new FractalTree();

        /// <summary>
        /// The instance of a Сantor set.
        /// </summary>
        private CantorSet _cantorSet
            = new CantorSet();

        /// <summary>
        /// The instance of a Koch curve.
        /// </summary>
        private KochCurve _kochCurve
            = new KochCurve();

        /// <summary>
        /// The instance of a Sierpinski carpet.
        /// </summary>
        private SierpinskiCarpet _sierpinskiCarpet
            = new SierpinskiCarpet();

        /// <summary>
        /// The instance of a Sierpinski triangle.
        /// </summary>
        private SierpinskiTriangle _sierpinskiTriangle
            = new SierpinskiTriangle();

        /// <summary>
        /// The generalized reference to an instance of a fractal.
        /// </summary>
        private Fractal _fractal;

        /// <summary>
        /// The form constructor sets the initial settings.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            // The default fractal is the fractal tree.
            _fractal = _fractalTree;
            comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
            textBoxFirstAngleDelta.Text = _fractalTree.FirstAngleDelta.ToString();
            textBoxSecondAngleDelta.Text = _fractalTree.SecondAngleDelta.ToString();
            textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            trackBarDepth.Maximum = (int)MaxDepth.FractalTree;
            // The color that will "erase" unnecessary segments.
            _kochCurve.BackColor = BackColor;
            panelOfCantorSetSettings.Visible = false;
            int minimumHeight = Screen.PrimaryScreen.WorkingArea.Height / 2;
            int minimumWidth = Screen.PrimaryScreen.WorkingArea.Width / 2;
            /* The minimum size of the application window is half 
             * the size of the monitor. */
            MinimumSize = new Size(minimumWidth, minimumHeight);
            // Providing advanced color selection.
            colorDialog.FullOpen = true;
            // The default file format to save.
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.Title = "Save the fractal image";
            tableLayoutPanelOfMainMenu.BringToFront();
        }

        /// <summary>
        /// The universal method to update the image of the fractal.
        /// </summary>
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
            var image = new Bitmap(_fractal.Width, _fractal.Height);
            _fractal.Graphics = Graphics.FromImage(image);
            _fractal.Graphics.GetNearestColor(Color.White);
            _fractal.Draw();
            pictureBoxOfFractal.Image = image;
        }

        /// <summary>
        /// This method correctly reads the first and last 
        /// colors of the gradient.
        /// </summary>
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
                ShowErrorMessage("Invalid color set." + _endl
                    + "Input format: #FFFFFF (in hexadecimal).");
                textBoxFirstColor.Text = "#000000";
                textBoxLastColor.Text = "#FFFFFF";
                colors[0] = Color.Black;
                colors[1] = Color.White;
            }
            return colors;
        }

        /// <summary>
        /// This method calculates the gradient.
        /// </summary>
        private Color[] CalculateColors(Color firstColor, Color lastColor, 
            int numberOfColors)
        {
            // Array of gradient colors.
            var colors = new Color[numberOfColors];
            for (int i = 0; i < numberOfColors; ++i)
            {
                var rAverage = firstColor.R + (lastColor.R - firstColor.R) 
                    * i / colors.Length;
                var gAverage = firstColor.G + (lastColor.G - firstColor.G) 
                    * i / colors.Length;
                var bAverage = firstColor.B + (lastColor.B - firstColor.B) 
                    * i / colors.Length;
                colors[i] = Color.FromArgb(rAverage, gAverage, bAverage);
            }
            return colors;
        }

        /// <summary>
        /// Universal method for displaying error messages.
        /// </summary>
        private void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Error!");
        }

        /// <summary>
        /// Universal method for the conversion of angle values.
        /// </summary>
        private bool TryParseAngle(string input, out double angle)
        {
            if (double.TryParse(input, out angle)
                && angle > 0 && angle <= Math.PI / 2)
            {
                return true;
            }
            ShowErrorMessage("Invalid angle delta set." + _endl
                    + "Enter a real number in half-interval (0; PI / 2].");
            angle = Math.PI / 2;
            return false;
        }

        /// <summary>
        /// Handler for the button click event,
        /// opens the menu of generation of the fractal.
        /// </summary>
        private void ButtonGoToGenerationClick(object sender, EventArgs e)
        {
            tableLayoutPanelOfGeneration.BringToFront();
        }

        /// <summary>
        /// Handler for the button click event,
        /// opens the main menu.
        /// </summary>
        private void ButtonGoToMainMenuClick(object sender, EventArgs e)
        {
            tableLayoutPanelOfMainMenu.BringToFront();
        }

        /// <summary>
        /// The event handler changes the value of the recursion depth.
        /// </summary>
        private void TrackBarDepthScroll(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        /// <summary>
        /// The event handler changes the value of the scale.
        /// </summary>
        private void TrackBarScaleScroll(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        /// <summary>
        /// Processing the selection of the fractal type.
        /// Changes the maximum value of the trackBarDepth
        /// and visibility of additional settings.
        /// </summary>
        private void ComboBoxTypesOfFractalsSelectedIndexChanged(object sender, EventArgs e)
        {
            tableLayoutPanelOfFractalTreeSettings.Visible = false;
            panelOfCantorSetSettings.Visible = false;
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
                    ShowErrorMessage("Invalid fractal select." + _endl
                        + "Select an option from the list.");
                    comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
                    break;
            }
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes to the value of the first gradient color.
        /// </summary>
        private void TextBoxFirstColorTextChanged(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes to the value of the second gradient color.
        /// </summary>
        private void TextBoxLastColorTextChanged(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes in the tilt angle of the first segment.
        /// It is related only to the fractal tree.
        /// </summary>
        private void TextBoxFirstAngleDeltaTextChanged(object sender, EventArgs e)
        {
            if (!TryParseAngle(textBoxFirstAngleDelta.Text, out double angle))
            {
                textBoxFirstAngleDelta.Text = angle.ToString();
            }
            _fractalTree.FirstAngleDelta = angle;
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes in the tilt angle of the second segment.
        /// It is related only to the fractal tree.
        /// </summary>
        private void TextBoxSecondAngleDeltaTextChanged(object sender, EventArgs e)
        {
            if (!TryParseAngle(textBoxSecondAngleDelta.Text, out double angle))
            {
                textBoxSecondAngleDelta.Text = angle.ToString();
            }
            _fractalTree.SecondAngleDelta = angle;
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes in the ratio of the new segment to the 
        /// previous one. It is related only to the fractal tree.
        /// </summary>
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
                    + _endl + "Enter a real number in half-interval (0; 1].");
                _fractalTree.LengthRatio = 0.8f;
                textBoxLengthRatio.Text = _fractalTree.LengthRatio.ToString();
            }
        }

        /// <summary>
        /// Processing resizing of the application window.
        /// </summary>
        private void FormMainMenuResize(object sender, EventArgs e)
        {
            RedrawFractal();
        }

        /// <summary>
        /// Processing changes in the distance between iterations (layers).
        /// It is related only to the Cantor set.
        /// </summary>
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
                    + _endl + "Enter a real number in range [1; 500].");
                textBoxIterationDistance.Text = "10";
            }
        }

        /// <summary>
        /// Processing changes in the height of a single layer.
        /// It is related only to the Cantor set.
        /// </summary>
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
                    + _endl + "Enter a real number in range [5; 100].");
                textBoxLayerHeight.Text = "10";
            }
        }

        /// <summary>
        /// Display help in English.
        /// </summary>
        private void ButtonEnglishHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("   Commands and settings!" + _endl
                + " Generate - open the generation window." + _endl
                + " Menu - return to the main menu." + _endl
                + " Save image - open the window for saving the fractal image." + _endl
                + " Select type of fractal - in the drop-down list, select"
                + "the necessary fractal." + _endl
                + " Click on the text fields under \"First color\" and "
                + "\"Last color\" to set the fractal gradient. " + _endl
                + " Recursion depth - depth of the fractal drawing recursion"
                + "(left extreme position - 1, right - maximum depth)." + _endl
                + " Scale - image scale (left extreme position - 1:1, "
                + "then 2, 3, ..., 6-fold approximation)." + _endl + _endl
                + "   Special settings!" + _endl + _endl
                + " For a fractal tree:" + _endl
                + " First angle delta - the angle of inclination of the first segment." + _endl
                + " Second angle delta - the angle of inclination of the second segment." + _endl
                + " Ratio of length - coefficient of the ratio of lengths of segments to"
                + "current and subsequent iterations" + _endl + _endl
                + " In the Cantor set:" + _endl
                + " Distance between iterations - distance (vertical)"
                + "in pixels between rectangles of different iterations." + _endl
                + " Layer height - the height of each rectangle." + _endl + _endl
                + "   It is not recommended to approach more than 5 with weak parameters of the"
                + "computer (video card, RAM, etc.), the image can take a long time to draw.", "Help");
        }

        /// <summary>
        /// Display help in Russian.
        /// </summary>
        private void ButtonRussianHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("   Команды и настройки!" + _endl
                + " Generate - открыть окно генерации." + _endl
                + " Menu - вернутся в главное меню." + _endl
                + " Save image - открыть окно сохранения изображения фрактала." + _endl
                + " Select type of fractal - в выпадающем списке выберите"
                + "необходимый фрактал (Wind-blown fractal tree - обдуваемое"
                + "ветром фрактальное дерево, Koch Curve - кривая Коха,"
                + "Sierpinski Carpet - ковёр Серпинского, Sierpinski Triangle -"
                + "- треугольник Серпинского, Cantor Set - множество Кантора)." + _endl
                + " Кликните на текстовые поля под надписями \"First color\" и"
                + "\"Last color\", чтобы задать градиент фрактала." + _endl
                + " Recursion depth - глубина рекурсии отрисовки фрактала"
                + "(левое крайнее положение - 1, правое - максимальная глубина)." + _endl
                + " Scale - масштаб изображения (левое крайнее положение - 1:1, "
                + "далее 2-х, 3-х, ..., 6-и кратное приближение)." + _endl + _endl
                + "   Особые настройки!" + _endl + _endl
                + " У фрактального дерева:" + _endl
                + " First angle delta - угол наклона первого отрезка." + _endl
                + " Second angle delta - угол наклона второго отрезка." + _endl
                + " Ratio of length - коэффициент отношения длин отрезков на"
                + "текущей и последующей итерациях" + _endl + _endl
                + " У множества Кантора:" + _endl
                + " Distance between iterations - расстояние (по вертикали)"
                + "в пикселях между прямоугольниками разных итераций." + _endl
                + " Layer height - высота каждого прямоугольника." + _endl + _endl
                + "    Не рекомендуется приближение более 5 при слабых параметрах"
                + "компьютера (видеокарта, ОЗУ и т.д.), изображение может долго" 
                + "прорисовываться.", "Справка");
        }

        /// <summary>
        /// Opens the color selection menu when the text field is clicked.
        /// </summary>
        private void TextBoxFirstColorClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            textBoxFirstColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
        }

        /// <summary>
        /// Opens the color selection menu when the text field is clicked.
        /// </summary>
        private void TextBoxLastColorClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            textBoxLastColor.Text = ColorTranslator.ToHtml(colorDialog.Color);
        }

        /// <summary>
        /// This method saves the fractal image.
        /// </summary>
        private void ButtonSaveImageClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pictureBoxOfFractal.Image.Save(saveFileDialog.FileName, 
                ImageFormat.Png);
            MessageBox.Show("The image is saved.");
        }
    }
}