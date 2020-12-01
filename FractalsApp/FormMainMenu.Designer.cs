namespace FractalsApp
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.tableLayoutPanelOfMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGoToGeneration = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanelOfGeneration = new System.Windows.Forms.TableLayoutPanel();
            this.panelOfGenerationSettings = new System.Windows.Forms.Panel();
            this.labelTypesOfFractals = new System.Windows.Forms.Label();
            this.comboBoxTypesOfFractals = new System.Windows.Forms.ComboBox();
            this.labelFirstColor = new System.Windows.Forms.Label();
            this.textBoxFirstColor = new System.Windows.Forms.TextBox();
            this.labelLastColor = new System.Windows.Forms.Label();
            this.textBoxLastColor = new System.Windows.Forms.TextBox();
            this.labelDepth = new System.Windows.Forms.Label();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.labelScale = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelOfFractalTreeSettings = new System.Windows.Forms.TableLayoutPanel();
            this.labelFirstAngleDelta = new System.Windows.Forms.Label();
            this.textBoxFirstAngleDelta = new System.Windows.Forms.TextBox();
            this.labelSecondAngleDelta = new System.Windows.Forms.Label();
            this.labelLengthRatio = new System.Windows.Forms.Label();
            this.textBoxSecondAngleDelta = new System.Windows.Forms.TextBox();
            this.textBoxLengthRatio = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelOfButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGoToMainMenu = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.panelOfFractalImage = new System.Windows.Forms.Panel();
            this.pictureBoxOfFractal = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelOfMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelOfGeneration.SuspendLayout();
            this.panelOfGenerationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.tableLayoutPanelOfFractalTreeSettings.SuspendLayout();
            this.flowLayoutPanelOfButtons.SuspendLayout();
            this.panelOfFractalImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOfMainMenu
            // 
            this.tableLayoutPanelOfMainMenu.AutoSize = true;
            this.tableLayoutPanelOfMainMenu.ColumnCount = 1;
            this.tableLayoutPanelOfMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOfMainMenu.Controls.Add(this.buttonGoToGeneration, 0, 4);
            this.tableLayoutPanelOfMainMenu.Controls.Add(this.pictureBoxLogo, 0, 2);
            this.tableLayoutPanelOfMainMenu.Controls.Add(this.labelWelcome, 0, 0);
            this.tableLayoutPanelOfMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOfMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOfMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelOfMainMenu.MinimumSize = new System.Drawing.Size(280, 240);
            this.tableLayoutPanelOfMainMenu.Name = "tableLayoutPanelOfMainMenu";
            this.tableLayoutPanelOfMainMenu.RowCount = 5;
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelOfMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOfMainMenu.Size = new System.Drawing.Size(751, 644);
            this.tableLayoutPanelOfMainMenu.TabIndex = 4;
            // 
            // buttonGoToGeneration
            // 
            this.buttonGoToGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonGoToGeneration.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoToGeneration.Location = new System.Drawing.Point(325, 548);
            this.buttonGoToGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoToGeneration.Name = "buttonGoToGeneration";
            this.buttonGoToGeneration.Size = new System.Drawing.Size(101, 94);
            this.buttonGoToGeneration.TabIndex = 0;
            this.buttonGoToGeneration.Text = "Generate";
            this.buttonGoToGeneration.UseVisualStyleBackColor = true;
            this.buttonGoToGeneration.Click += new System.EventHandler(this.ButtonGoToGenerationClick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(2, 162);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(747, 318);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(127, 0);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(497, 96);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to the fractal auto generator!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(2, 0);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(302, 40);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Generation of a fractal";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelOfGeneration
            // 
            this.tableLayoutPanelOfGeneration.AutoSize = true;
            this.tableLayoutPanelOfGeneration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelOfGeneration.ColumnCount = 2;
            this.tableLayoutPanelOfGeneration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfGeneration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOfGeneration.Controls.Add(this.panelOfGenerationSettings, 0, 1);
            this.tableLayoutPanelOfGeneration.Controls.Add(this.labelDescription, 0, 0);
            this.tableLayoutPanelOfGeneration.Controls.Add(this.panelOfFractalImage, 1, 1);
            this.tableLayoutPanelOfGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOfGeneration.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOfGeneration.Name = "tableLayoutPanelOfGeneration";
            this.tableLayoutPanelOfGeneration.RowCount = 2;
            this.tableLayoutPanelOfGeneration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelOfGeneration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelOfGeneration.Size = new System.Drawing.Size(751, 644);
            this.tableLayoutPanelOfGeneration.TabIndex = 0;
            // 
            // panelOfGenerationSettings
            // 
            this.panelOfGenerationSettings.AutoScroll = true;
            this.panelOfGenerationSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOfGenerationSettings.Controls.Add(this.labelTypesOfFractals);
            this.panelOfGenerationSettings.Controls.Add(this.comboBoxTypesOfFractals);
            this.panelOfGenerationSettings.Controls.Add(this.labelFirstColor);
            this.panelOfGenerationSettings.Controls.Add(this.textBoxFirstColor);
            this.panelOfGenerationSettings.Controls.Add(this.labelLastColor);
            this.panelOfGenerationSettings.Controls.Add(this.textBoxLastColor);
            this.panelOfGenerationSettings.Controls.Add(this.labelDepth);
            this.panelOfGenerationSettings.Controls.Add(this.trackBarDepth);
            this.panelOfGenerationSettings.Controls.Add(this.labelScale);
            this.panelOfGenerationSettings.Controls.Add(this.trackBarScale);
            this.panelOfGenerationSettings.Controls.Add(this.tableLayoutPanelOfFractalTreeSettings);
            this.panelOfGenerationSettings.Controls.Add(this.flowLayoutPanelOfButtons);
            this.panelOfGenerationSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfGenerationSettings.Location = new System.Drawing.Point(2, 66);
            this.panelOfGenerationSettings.Margin = new System.Windows.Forms.Padding(2);
            this.panelOfGenerationSettings.Name = "panelOfGenerationSettings";
            this.panelOfGenerationSettings.Size = new System.Drawing.Size(302, 576);
            this.panelOfGenerationSettings.TabIndex = 0;
            // 
            // labelTypesOfFractals
            // 
            this.labelTypesOfFractals.AutoSize = true;
            this.labelTypesOfFractals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTypesOfFractals.Location = new System.Drawing.Point(3, -5);
            this.labelTypesOfFractals.Name = "labelTypesOfFractals";
            this.labelTypesOfFractals.Size = new System.Drawing.Size(207, 25);
            this.labelTypesOfFractals.TabIndex = 7;
            this.labelTypesOfFractals.Text = "Select the type of fractal.";
            // 
            // comboBoxTypesOfFractals
            // 
            this.comboBoxTypesOfFractals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTypesOfFractals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTypesOfFractals.FormattingEnabled = true;
            this.comboBoxTypesOfFractals.Items.AddRange(new object[] {
            "Wind-blown fractal tree",
            "Koch Curve",
            "Sierpinski Carpet",
            "Sierpinski Triangle",
            "Cantor Set"});
            this.comboBoxTypesOfFractals.Location = new System.Drawing.Point(2, 22);
            this.comboBoxTypesOfFractals.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTypesOfFractals.Name = "comboBoxTypesOfFractals";
            this.comboBoxTypesOfFractals.Size = new System.Drawing.Size(255, 33);
            this.comboBoxTypesOfFractals.TabIndex = 0;
            this.comboBoxTypesOfFractals.Text = "Wind-blown fractal tree";
            this.comboBoxTypesOfFractals.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypesOfFractalsSelectedIndexChanged);
            // 
            // labelFirstColor
            // 
            this.labelFirstColor.AutoSize = true;
            this.labelFirstColor.Location = new System.Drawing.Point(0, 57);
            this.labelFirstColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstColor.Name = "labelFirstColor";
            this.labelFirstColor.Size = new System.Drawing.Size(90, 25);
            this.labelFirstColor.TabIndex = 1;
            this.labelFirstColor.Text = "First color";
            // 
            // textBoxFirstColor
            // 
            this.textBoxFirstColor.Location = new System.Drawing.Point(2, 84);
            this.textBoxFirstColor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstColor.Name = "textBoxFirstColor";
            this.textBoxFirstColor.Size = new System.Drawing.Size(255, 31);
            this.textBoxFirstColor.TabIndex = 2;
            this.textBoxFirstColor.Text = "#000000";
            this.textBoxFirstColor.TextChanged += new System.EventHandler(this.TextBoxFirstColorTextChanged);
            // 
            // labelLastColor
            // 
            this.labelLastColor.AutoSize = true;
            this.labelLastColor.Location = new System.Drawing.Point(3, 117);
            this.labelLastColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastColor.Name = "labelLastColor";
            this.labelLastColor.Size = new System.Drawing.Size(88, 25);
            this.labelLastColor.TabIndex = 3;
            this.labelLastColor.Text = "Last color";
            // 
            // textBoxLastColor
            // 
            this.textBoxLastColor.Location = new System.Drawing.Point(2, 144);
            this.textBoxLastColor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastColor.Name = "textBoxLastColor";
            this.textBoxLastColor.Size = new System.Drawing.Size(255, 31);
            this.textBoxLastColor.TabIndex = 4;
            this.textBoxLastColor.Text = "#FFFFFF";
            this.textBoxLastColor.TextChanged += new System.EventHandler(this.TextBoxLastColorTextChanged);
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(2, 177);
            this.labelDepth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(140, 25);
            this.labelDepth.TabIndex = 5;
            this.labelDepth.Text = "Recursion depth";
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.Location = new System.Drawing.Point(2, 204);
            this.trackBarDepth.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarDepth.Minimum = 1;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(255, 69);
            this.trackBarDepth.TabIndex = 6;
            this.trackBarDepth.Value = 1;
            this.trackBarDepth.Scroll += new System.EventHandler(this.TrackBarDepthScroll);
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(3, 275);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(52, 25);
            this.labelScale.TabIndex = 8;
            this.labelScale.Text = "Scale";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(2, 302);
            this.trackBarScale.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarScale.Maximum = 5;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(255, 69);
            this.trackBarScale.TabIndex = 6;
            this.trackBarScale.Value = 1;
            this.trackBarScale.Scroll += new System.EventHandler(this.TrackBarScaleScroll);
            // 
            // tableLayoutPanelOfFractalTreeSettings
            // 
            this.tableLayoutPanelOfFractalTreeSettings.ColumnCount = 3;
            this.tableLayoutPanelOfFractalTreeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOfFractalTreeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOfFractalTreeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.labelFirstAngleDelta, 0, 0);
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.textBoxFirstAngleDelta, 0, 1);
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.labelSecondAngleDelta, 1, 0);
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.labelLengthRatio, 2, 0);
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.textBoxSecondAngleDelta, 1, 1);
            this.tableLayoutPanelOfFractalTreeSettings.Controls.Add(this.textBoxLengthRatio, 2, 1);
            this.tableLayoutPanelOfFractalTreeSettings.Location = new System.Drawing.Point(3, 376);
            this.tableLayoutPanelOfFractalTreeSettings.Name = "tableLayoutPanelOfFractalTreeSettings";
            this.tableLayoutPanelOfFractalTreeSettings.RowCount = 2;
            this.tableLayoutPanelOfFractalTreeSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfFractalTreeSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOfFractalTreeSettings.Size = new System.Drawing.Size(253, 100);
            this.tableLayoutPanelOfFractalTreeSettings.TabIndex = 13;
            // 
            // labelFirstAngleDelta
            // 
            this.labelFirstAngleDelta.AutoSize = true;
            this.labelFirstAngleDelta.Location = new System.Drawing.Point(3, 0);
            this.labelFirstAngleDelta.Name = "labelFirstAngleDelta";
            this.labelFirstAngleDelta.Size = new System.Drawing.Size(60, 50);
            this.labelFirstAngleDelta.TabIndex = 10;
            this.labelFirstAngleDelta.Text = "First angle delta";
            // 
            // textBoxFirstAngleDelta
            // 
            this.textBoxFirstAngleDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstAngleDelta.Location = new System.Drawing.Point(3, 59);
            this.textBoxFirstAngleDelta.Name = "textBoxFirstAngleDelta";
            this.textBoxFirstAngleDelta.Size = new System.Drawing.Size(78, 31);
            this.textBoxFirstAngleDelta.TabIndex = 11;
            this.textBoxFirstAngleDelta.TextChanged += new System.EventHandler(this.TextBoxFirstAngleDeltaTextChanged);
            // 
            // labelSecondAngleDelta
            // 
            this.labelSecondAngleDelta.AutoSize = true;
            this.labelSecondAngleDelta.Location = new System.Drawing.Point(87, 0);
            this.labelSecondAngleDelta.Name = "labelSecondAngleDelta";
            this.labelSecondAngleDelta.Size = new System.Drawing.Size(76, 50);
            this.labelSecondAngleDelta.TabIndex = 12;
            this.labelSecondAngleDelta.Text = "Second angle delta";
            // 
            // labelLengthRatio
            // 
            this.labelLengthRatio.AutoSize = true;
            this.labelLengthRatio.Location = new System.Drawing.Point(171, 0);
            this.labelLengthRatio.Name = "labelLengthRatio";
            this.labelLengthRatio.Size = new System.Drawing.Size(75, 50);
            this.labelLengthRatio.TabIndex = 13;
            this.labelLengthRatio.Text = "Ratio of length";
            // 
            // textBoxSecondAngleDelta
            // 
            this.textBoxSecondAngleDelta.AcceptsTab = true;
            this.textBoxSecondAngleDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecondAngleDelta.Location = new System.Drawing.Point(87, 59);
            this.textBoxSecondAngleDelta.Name = "textBoxSecondAngleDelta";
            this.textBoxSecondAngleDelta.Size = new System.Drawing.Size(78, 31);
            this.textBoxSecondAngleDelta.TabIndex = 14;
            this.textBoxSecondAngleDelta.TextChanged += new System.EventHandler(this.TextBoxSecondAngleDeltaTextChanged);
            // 
            // textBoxLengthRatio
            // 
            this.textBoxLengthRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLengthRatio.Location = new System.Drawing.Point(171, 59);
            this.textBoxLengthRatio.Name = "textBoxLengthRatio";
            this.textBoxLengthRatio.Size = new System.Drawing.Size(79, 31);
            this.textBoxLengthRatio.TabIndex = 15;
            this.textBoxLengthRatio.TextChanged += new System.EventHandler(this.TextBoxLengthRatioTextChanged);
            // 
            // flowLayoutPanelOfButtons
            // 
            this.flowLayoutPanelOfButtons.AutoSize = true;
            this.flowLayoutPanelOfButtons.Controls.Add(this.buttonGoToMainMenu);
            this.flowLayoutPanelOfButtons.Controls.Add(this.buttonSaveImage);
            this.flowLayoutPanelOfButtons.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanelOfButtons.Name = "flowLayoutPanelOfButtons";
            this.flowLayoutPanelOfButtons.Size = new System.Drawing.Size(200, 42);
            this.flowLayoutPanelOfButtons.TabIndex = 12;
            // 
            // buttonGoToMainMenu
            // 
            this.buttonGoToMainMenu.AutoSize = true;
            this.buttonGoToMainMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonGoToMainMenu.Name = "buttonGoToMainMenu";
            this.buttonGoToMainMenu.Size = new System.Drawing.Size(75, 35);
            this.buttonGoToMainMenu.TabIndex = 9;
            this.buttonGoToMainMenu.Text = "Menu";
            this.buttonGoToMainMenu.UseVisualStyleBackColor = true;
            this.buttonGoToMainMenu.Click += new System.EventHandler(this.ButtonGoToMainMenuClick);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.AutoSize = true;
            this.buttonSaveImage.Location = new System.Drawing.Point(84, 3);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(113, 35);
            this.buttonSaveImage.TabIndex = 10;
            this.buttonSaveImage.Text = "Save image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            // 
            // panelOfFractalImage
            // 
            this.panelOfFractalImage.AutoScroll = true;
            this.panelOfFractalImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelOfFractalImage.Controls.Add(this.pictureBoxOfFractal);
            this.panelOfFractalImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOfFractalImage.Location = new System.Drawing.Point(309, 67);
            this.panelOfFractalImage.Name = "panelOfFractalImage";
            this.panelOfFractalImage.Size = new System.Drawing.Size(459, 574);
            this.panelOfFractalImage.TabIndex = 1;
            this.panelOfFractalImage.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOfFractalImagePaint);
            // 
            // pictureBoxOfFractal
            // 
            this.pictureBoxOfFractal.Location = new System.Drawing.Point(0, -742);
            this.pictureBoxOfFractal.Name = "pictureBoxOfFractal";
            this.pictureBoxOfFractal.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxOfFractal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOfFractal.TabIndex = 1;
            this.pictureBoxOfFractal.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(751, 644);
            this.Controls.Add(this.tableLayoutPanelOfGeneration);
            this.Controls.Add(this.tableLayoutPanelOfMainMenu);
            this.MinimumSize = new System.Drawing.Size(600, 410);
            this.Name = "FormMainMenu";
            this.Resize += new System.EventHandler(this.FormMainMenuResize);
            this.tableLayoutPanelOfMainMenu.ResumeLayout(false);
            this.tableLayoutPanelOfMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelOfGeneration.ResumeLayout(false);
            this.tableLayoutPanelOfGeneration.PerformLayout();
            this.panelOfGenerationSettings.ResumeLayout(false);
            this.panelOfGenerationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.tableLayoutPanelOfFractalTreeSettings.ResumeLayout(false);
            this.tableLayoutPanelOfFractalTreeSettings.PerformLayout();
            this.flowLayoutPanelOfButtons.ResumeLayout(false);
            this.flowLayoutPanelOfButtons.PerformLayout();
            this.panelOfFractalImage.ResumeLayout(false);
            this.panelOfFractalImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfFractal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfMainMenu;
        private System.Windows.Forms.Button buttonGoToGeneration;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfGeneration;
        private System.Windows.Forms.Panel panelOfGenerationSettings;
        private System.Windows.Forms.Label labelTypesOfFractals;
        private System.Windows.Forms.ComboBox comboBoxTypesOfFractals;
        private System.Windows.Forms.Label labelFirstColor;
        private System.Windows.Forms.TextBox textBoxFirstColor;
        private System.Windows.Forms.Label labelLastColor;
        private System.Windows.Forms.TextBox textBoxLastColor;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Button buttonGoToMainMenu;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.Label labelFirstAngleDelta;
        private System.Windows.Forms.TextBox textBoxFirstAngleDelta;
        private System.Windows.Forms.Panel panelOfFractalImage;
        private System.Windows.Forms.PictureBox pictureBoxOfFractal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOfButtons;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOfFractalTreeSettings;
        private System.Windows.Forms.Label labelSecondAngleDelta;
        private System.Windows.Forms.Label labelLengthRatio;
        private System.Windows.Forms.TextBox textBoxSecondAngleDelta;
        private System.Windows.Forms.TextBox textBoxLengthRatio;
    }
}

