namespace Mesh_Loader_Task
{
    partial class MeshLoaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeshLoaderForm));
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.SimpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.DataComboBox = new System.Windows.Forms.ComboBox();
            this.DataNameLabel = new System.Windows.Forms.Label();
            this.EdgeColoringBox = new System.Windows.Forms.RadioButton();
            this.FaceColoringBox = new System.Windows.Forms.RadioButton();
            this.ColoringGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearMeshBtn = new System.Windows.Forms.Button();
            this.DisplayValuesButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.colorMapping1 = new WindowsFormsControlLibrary1.ColorMapping();
            this.ContoursWithNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateContoursWithNumberBtn = new System.Windows.Forms.Button();
            this.ContoursToggleDisplayWithNumberBtn = new System.Windows.Forms.Button();
            this.NumberOfContoursTxtBox = new System.Windows.Forms.TextBox();
            this.ContoursNumberLabel = new System.Windows.Forms.Label();
            this.ContoursGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearContours = new System.Windows.Forms.Button();
            this.ContoursOverIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.ContoursWithNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.ContoursOverIntervalGroupBox = new System.Windows.Forms.GroupBox();
            this.ContourIntervalStepTxtBox = new System.Windows.Forms.TextBox();
            this.ContourIntervalStepLabel = new System.Windows.Forms.Label();
            this.ContourIntervalEndTxtBox = new System.Windows.Forms.TextBox();
            this.ContourIntervalEndLabel = new System.Windows.Forms.Label();
            this.ContourIntervalStartTxtBox = new System.Windows.Forms.TextBox();
            this.ContourIntervalStartLabel = new System.Windows.Forms.Label();
            this.CalculateContoursOverIntervalBtn = new System.Windows.Forms.Button();
            this.ContoursToggleDisplayOverIntervalBtn = new System.Windows.Forms.Button();
            this.ColoringGroupBox.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
            this.ContoursWithNumberGroupBox.SuspendLayout();
            this.ContoursGroupBox.SuspendLayout();
            this.ContoursOverIntervalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.BackColor = System.Drawing.SystemColors.Control;
            this.LoadFileButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LoadFileButton.FlatAppearance.BorderSize = 5;
            this.LoadFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadFileButton.Location = new System.Drawing.Point(1181, 21);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(121, 49);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Load File";
            this.LoadFileButton.UseVisualStyleBackColor = false;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // SimpleOpenGlControl
            // 
            this.SimpleOpenGlControl.AccumBits = ((byte)(0));
            this.SimpleOpenGlControl.AutoCheckErrors = false;
            this.SimpleOpenGlControl.AutoFinish = false;
            this.SimpleOpenGlControl.AutoMakeCurrent = true;
            this.SimpleOpenGlControl.AutoSwapBuffers = true;
            this.SimpleOpenGlControl.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.SimpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this.SimpleOpenGlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleOpenGlControl.ColorBits = ((byte)(32));
            this.SimpleOpenGlControl.DepthBits = ((byte)(16));
            this.SimpleOpenGlControl.Location = new System.Drawing.Point(21, 21);
            this.SimpleOpenGlControl.Name = "SimpleOpenGlControl";
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(922, 657);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 3;
            this.SimpleOpenGlControl.Load += new System.EventHandler(this.SimpleOpenGlControl_Load);
            this.SimpleOpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.SimpleOpenGlControl_Paint);
            // 
            // DataComboBox
            // 
            this.DataComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataComboBox.FormattingEnabled = true;
            this.DataComboBox.Location = new System.Drawing.Point(19, 45);
            this.DataComboBox.Name = "DataComboBox";
            this.DataComboBox.Size = new System.Drawing.Size(129, 27);
            this.DataComboBox.TabIndex = 1;
            this.DataComboBox.SelectedIndexChanged += new System.EventHandler(this.DataComboBox_SelectedIndexChanged);
            // 
            // DataNameLabel
            // 
            this.DataNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataNameLabel.AutoSize = true;
            this.DataNameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNameLabel.Location = new System.Drawing.Point(16, 30);
            this.DataNameLabel.Name = "DataNameLabel";
            this.DataNameLabel.Size = new System.Drawing.Size(37, 14);
            this.DataNameLabel.TabIndex = 5;
            this.DataNameLabel.Text = "Name";
            // 
            // EdgeColoringBox
            // 
            this.EdgeColoringBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EdgeColoringBox.AutoSize = true;
            this.EdgeColoringBox.Location = new System.Drawing.Point(19, 25);
            this.EdgeColoringBox.Name = "EdgeColoringBox";
            this.EdgeColoringBox.Size = new System.Drawing.Size(121, 23);
            this.EdgeColoringBox.TabIndex = 2;
            this.EdgeColoringBox.TabStop = true;
            this.EdgeColoringBox.Text = "Edge Coloring";
            this.EdgeColoringBox.UseVisualStyleBackColor = true;
            this.EdgeColoringBox.CheckedChanged += new System.EventHandler(this.EdgeColoringBox_CheckedChanged);
            // 
            // FaceColoringBox
            // 
            this.FaceColoringBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FaceColoringBox.AutoSize = true;
            this.FaceColoringBox.Location = new System.Drawing.Point(19, 50);
            this.FaceColoringBox.Name = "FaceColoringBox";
            this.FaceColoringBox.Size = new System.Drawing.Size(118, 23);
            this.FaceColoringBox.TabIndex = 3;
            this.FaceColoringBox.TabStop = true;
            this.FaceColoringBox.Text = "Face Coloring";
            this.FaceColoringBox.UseVisualStyleBackColor = true;
            this.FaceColoringBox.CheckedChanged += new System.EventHandler(this.FaceColoringBox_CheckedChanged);
            // 
            // ColoringGroupBox
            // 
            this.ColoringGroupBox.Controls.Add(this.ClearMeshBtn);
            this.ColoringGroupBox.Controls.Add(this.EdgeColoringBox);
            this.ColoringGroupBox.Controls.Add(this.FaceColoringBox);
            this.ColoringGroupBox.Controls.Add(this.DisplayValuesButton);
            this.ColoringGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoringGroupBox.ForeColor = System.Drawing.Color.White;
            this.ColoringGroupBox.Location = new System.Drawing.Point(1162, 217);
            this.ColoringGroupBox.Name = "ColoringGroupBox";
            this.ColoringGroupBox.Size = new System.Drawing.Size(171, 155);
            this.ColoringGroupBox.TabIndex = 10;
            this.ColoringGroupBox.TabStop = false;
            this.ColoringGroupBox.Text = "Coloring";
            // 
            // ClearMeshBtn
            // 
            this.ClearMeshBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearMeshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ClearMeshBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearMeshBtn.Location = new System.Drawing.Point(18, 116);
            this.ClearMeshBtn.Name = "ClearMeshBtn";
            this.ClearMeshBtn.Size = new System.Drawing.Size(130, 31);
            this.ClearMeshBtn.TabIndex = 5;
            this.ClearMeshBtn.Text = "Clear";
            this.ClearMeshBtn.UseVisualStyleBackColor = false;
            this.ClearMeshBtn.Click += new System.EventHandler(this.ClearMeshBtn_Click);
            // 
            // DisplayValuesButton
            // 
            this.DisplayValuesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayValuesButton.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayValuesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisplayValuesButton.Location = new System.Drawing.Point(18, 79);
            this.DisplayValuesButton.Name = "DisplayValuesButton";
            this.DisplayValuesButton.Size = new System.Drawing.Size(130, 31);
            this.DisplayValuesButton.TabIndex = 4;
            this.DisplayValuesButton.Text = "Toggle Display";
            this.DisplayValuesButton.UseVisualStyleBackColor = false;
            this.DisplayValuesButton.Click += new System.EventHandler(this.DisplayValuesButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.Transparent;
            this.InstructionsLabel.Location = new System.Drawing.Point(1162, 384);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(171, 259);
            this.InstructionsLabel.TabIndex = 11;
            this.InstructionsLabel.Text = resources.GetString("InstructionsLabel.Text");
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.DataGroupBox.Controls.Add(this.MinLabel);
            this.DataGroupBox.Controls.Add(this.MaxLabel);
            this.DataGroupBox.Controls.Add(this.MinValueLabel);
            this.DataGroupBox.Controls.Add(this.MaxValueLabel);
            this.DataGroupBox.Controls.Add(this.DataNameLabel);
            this.DataGroupBox.Controls.Add(this.DataComboBox);
            this.DataGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGroupBox.ForeColor = System.Drawing.Color.White;
            this.DataGroupBox.Location = new System.Drawing.Point(1162, 76);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(171, 135);
            this.DataGroupBox.TabIndex = 12;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Data";
            // 
            // MinLabel
            // 
            this.MinLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(90, 83);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(36, 19);
            this.MinLabel.TabIndex = 9;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(15, 83);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(38, 19);
            this.MaxLabel.TabIndex = 8;
            this.MaxLabel.Text = "Max";
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(87, 102);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(0, 19);
            this.MinValueLabel.TabIndex = 7;
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(15, 102);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(0, 19);
            this.MaxValueLabel.TabIndex = 6;
            // 
            // colorMapping1
            // 
            this.colorMapping1.Location = new System.Drawing.Point(1126, 646);
            this.colorMapping1.Name = "colorMapping1";
            this.colorMapping1.Size = new System.Drawing.Size(216, 32);
            this.colorMapping1.TabIndex = 13;
            // 
            // ContoursWithNumberGroupBox
            // 
            this.ContoursWithNumberGroupBox.Controls.Add(this.CalculateContoursWithNumberBtn);
            this.ContoursWithNumberGroupBox.Controls.Add(this.ContoursToggleDisplayWithNumberBtn);
            this.ContoursWithNumberGroupBox.Controls.Add(this.NumberOfContoursTxtBox);
            this.ContoursWithNumberGroupBox.Controls.Add(this.ContoursNumberLabel);
            this.ContoursWithNumberGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ContoursWithNumberGroupBox.ForeColor = System.Drawing.Color.White;
            this.ContoursWithNumberGroupBox.Location = new System.Drawing.Point(6, 76);
            this.ContoursWithNumberGroupBox.Name = "ContoursWithNumberGroupBox";
            this.ContoursWithNumberGroupBox.Size = new System.Drawing.Size(171, 138);
            this.ContoursWithNumberGroupBox.TabIndex = 14;
            this.ContoursWithNumberGroupBox.TabStop = false;
            this.ContoursWithNumberGroupBox.Text = "With Number";
            // 
            // CalculateContoursWithNumberBtn
            // 
            this.CalculateContoursWithNumberBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CalculateContoursWithNumberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateContoursWithNumberBtn.Location = new System.Drawing.Point(18, 53);
            this.CalculateContoursWithNumberBtn.Name = "CalculateContoursWithNumberBtn";
            this.CalculateContoursWithNumberBtn.Size = new System.Drawing.Size(139, 31);
            this.CalculateContoursWithNumberBtn.TabIndex = 9;
            this.CalculateContoursWithNumberBtn.Text = "Calculate";
            this.CalculateContoursWithNumberBtn.UseVisualStyleBackColor = false;
            this.CalculateContoursWithNumberBtn.Click += new System.EventHandler(this.CalculateContoursWithNumberBtn_Click);
            // 
            // ContoursToggleDisplayWithNumberBtn
            // 
            this.ContoursToggleDisplayWithNumberBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ContoursToggleDisplayWithNumberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContoursToggleDisplayWithNumberBtn.Location = new System.Drawing.Point(18, 90);
            this.ContoursToggleDisplayWithNumberBtn.Name = "ContoursToggleDisplayWithNumberBtn";
            this.ContoursToggleDisplayWithNumberBtn.Size = new System.Drawing.Size(139, 31);
            this.ContoursToggleDisplayWithNumberBtn.TabIndex = 10;
            this.ContoursToggleDisplayWithNumberBtn.Text = "Toggle Display";
            this.ContoursToggleDisplayWithNumberBtn.UseVisualStyleBackColor = false;
            this.ContoursToggleDisplayWithNumberBtn.Click += new System.EventHandler(this.ContoursToggleDisplayBtn_Click);
            // 
            // NumberOfContoursTxtBox
            // 
            this.NumberOfContoursTxtBox.Location = new System.Drawing.Point(103, 20);
            this.NumberOfContoursTxtBox.MaxLength = 3;
            this.NumberOfContoursTxtBox.Name = "NumberOfContoursTxtBox";
            this.NumberOfContoursTxtBox.Size = new System.Drawing.Size(24, 27);
            this.NumberOfContoursTxtBox.TabIndex = 8;
            this.NumberOfContoursTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfContoursTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleContourEnterKey);
            // 
            // ContoursNumberLabel
            // 
            this.ContoursNumberLabel.AutoSize = true;
            this.ContoursNumberLabel.Location = new System.Drawing.Point(6, 23);
            this.ContoursNumberLabel.Name = "ContoursNumberLabel";
            this.ContoursNumberLabel.Size = new System.Drawing.Size(91, 19);
            this.ContoursNumberLabel.TabIndex = 0;
            this.ContoursNumberLabel.Text = "# Contours: ";
            // 
            // ContoursGroupBox
            // 
            this.ContoursGroupBox.Controls.Add(this.ClearContours);
            this.ContoursGroupBox.Controls.Add(this.ContoursOverIntervalRadioButton);
            this.ContoursGroupBox.Controls.Add(this.ContoursWithNumberRadioButton);
            this.ContoursGroupBox.Controls.Add(this.ContoursOverIntervalGroupBox);
            this.ContoursGroupBox.Controls.Add(this.ContoursWithNumberGroupBox);
            this.ContoursGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ContoursGroupBox.ForeColor = System.Drawing.Color.White;
            this.ContoursGroupBox.Location = new System.Drawing.Point(960, 159);
            this.ContoursGroupBox.Name = "ContoursGroupBox";
            this.ContoursGroupBox.Size = new System.Drawing.Size(186, 470);
            this.ContoursGroupBox.TabIndex = 15;
            this.ContoursGroupBox.TabStop = false;
            this.ContoursGroupBox.Text = "Contours";
            // 
            // ClearContours
            // 
            this.ClearContours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearContours.BackColor = System.Drawing.SystemColors.Control;
            this.ClearContours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearContours.Location = new System.Drawing.Point(24, 425);
            this.ClearContours.Name = "ClearContours";
            this.ClearContours.Size = new System.Drawing.Size(130, 36);
            this.ClearContours.TabIndex = 16;
            this.ClearContours.Text = "Clear";
            this.ClearContours.UseVisualStyleBackColor = false;
            this.ClearContours.Click += new System.EventHandler(this.ClearContours_Click);
            // 
            // ContoursOverIntervalRadioButton
            // 
            this.ContoursOverIntervalRadioButton.AutoSize = true;
            this.ContoursOverIntervalRadioButton.Location = new System.Drawing.Point(15, 45);
            this.ContoursOverIntervalRadioButton.Name = "ContoursOverIntervalRadioButton";
            this.ContoursOverIntervalRadioButton.Size = new System.Drawing.Size(117, 23);
            this.ContoursOverIntervalRadioButton.TabIndex = 7;
            this.ContoursOverIntervalRadioButton.TabStop = true;
            this.ContoursOverIntervalRadioButton.Text = "Over Interval";
            this.ContoursOverIntervalRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContoursWithNumberRadioButton
            // 
            this.ContoursWithNumberRadioButton.AutoSize = true;
            this.ContoursWithNumberRadioButton.Location = new System.Drawing.Point(15, 23);
            this.ContoursWithNumberRadioButton.Name = "ContoursWithNumberRadioButton";
            this.ContoursWithNumberRadioButton.Size = new System.Drawing.Size(121, 23);
            this.ContoursWithNumberRadioButton.TabIndex = 6;
            this.ContoursWithNumberRadioButton.TabStop = true;
            this.ContoursWithNumberRadioButton.Text = "With Number";
            this.ContoursWithNumberRadioButton.UseVisualStyleBackColor = true;
            this.ContoursWithNumberRadioButton.CheckedChanged += new System.EventHandler(this.ContoursWithNumberRadioButton_CheckedChanged);
            // 
            // ContoursOverIntervalGroupBox
            // 
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalStepTxtBox);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalStepLabel);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalEndTxtBox);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalEndLabel);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalStartTxtBox);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContourIntervalStartLabel);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.CalculateContoursOverIntervalBtn);
            this.ContoursOverIntervalGroupBox.Controls.Add(this.ContoursToggleDisplayOverIntervalBtn);
            this.ContoursOverIntervalGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ContoursOverIntervalGroupBox.ForeColor = System.Drawing.Color.White;
            this.ContoursOverIntervalGroupBox.Location = new System.Drawing.Point(6, 220);
            this.ContoursOverIntervalGroupBox.Name = "ContoursOverIntervalGroupBox";
            this.ContoursOverIntervalGroupBox.Size = new System.Drawing.Size(171, 199);
            this.ContoursOverIntervalGroupBox.TabIndex = 15;
            this.ContoursOverIntervalGroupBox.TabStop = false;
            this.ContoursOverIntervalGroupBox.Text = "Over Interval";
            // 
            // ContourIntervalStepTxtBox
            // 
            this.ContourIntervalStepTxtBox.Location = new System.Drawing.Point(88, 64);
            this.ContourIntervalStepTxtBox.MaxLength = 5;
            this.ContourIntervalStepTxtBox.Name = "ContourIntervalStepTxtBox";
            this.ContourIntervalStepTxtBox.Size = new System.Drawing.Size(29, 27);
            this.ContourIntervalStepTxtBox.TabIndex = 13;
            this.ContourIntervalStepTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContourIntervalStepTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleContourEnterKey);
            // 
            // ContourIntervalStepLabel
            // 
            this.ContourIntervalStepLabel.AutoSize = true;
            this.ContourIntervalStepLabel.Location = new System.Drawing.Point(38, 67);
            this.ContourIntervalStepLabel.Name = "ContourIntervalStepLabel";
            this.ContourIntervalStepLabel.Size = new System.Drawing.Size(44, 19);
            this.ContourIntervalStepLabel.TabIndex = 17;
            this.ContourIntervalStepLabel.Text = "Step:";
            // 
            // ContourIntervalEndTxtBox
            // 
            this.ContourIntervalEndTxtBox.Location = new System.Drawing.Point(135, 27);
            this.ContourIntervalEndTxtBox.MaxLength = 5;
            this.ContourIntervalEndTxtBox.Name = "ContourIntervalEndTxtBox";
            this.ContourIntervalEndTxtBox.Size = new System.Drawing.Size(29, 27);
            this.ContourIntervalEndTxtBox.TabIndex = 12;
            this.ContourIntervalEndTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContourIntervalEndTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleContourEnterKey);
            // 
            // ContourIntervalEndLabel
            // 
            this.ContourIntervalEndLabel.AutoSize = true;
            this.ContourIntervalEndLabel.Location = new System.Drawing.Point(91, 30);
            this.ContourIntervalEndLabel.Name = "ContourIntervalEndLabel";
            this.ContourIntervalEndLabel.Size = new System.Drawing.Size(39, 19);
            this.ContourIntervalEndLabel.TabIndex = 15;
            this.ContourIntervalEndLabel.Text = "End:";
            // 
            // ContourIntervalStartTxtBox
            // 
            this.ContourIntervalStartTxtBox.Location = new System.Drawing.Point(56, 27);
            this.ContourIntervalStartTxtBox.MaxLength = 5;
            this.ContourIntervalStartTxtBox.Name = "ContourIntervalStartTxtBox";
            this.ContourIntervalStartTxtBox.Size = new System.Drawing.Size(29, 27);
            this.ContourIntervalStartTxtBox.TabIndex = 11;
            this.ContourIntervalStartTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContourIntervalStartTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleContourEnterKey);
            // 
            // ContourIntervalStartLabel
            // 
            this.ContourIntervalStartLabel.AutoSize = true;
            this.ContourIntervalStartLabel.Location = new System.Drawing.Point(6, 30);
            this.ContourIntervalStartLabel.Name = "ContourIntervalStartLabel";
            this.ContourIntervalStartLabel.Size = new System.Drawing.Size(47, 19);
            this.ContourIntervalStartLabel.TabIndex = 13;
            this.ContourIntervalStartLabel.Text = "Start:";
            // 
            // CalculateContoursOverIntervalBtn
            // 
            this.CalculateContoursOverIntervalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CalculateContoursOverIntervalBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateContoursOverIntervalBtn.Location = new System.Drawing.Point(18, 112);
            this.CalculateContoursOverIntervalBtn.Name = "CalculateContoursOverIntervalBtn";
            this.CalculateContoursOverIntervalBtn.Size = new System.Drawing.Size(132, 31);
            this.CalculateContoursOverIntervalBtn.TabIndex = 14;
            this.CalculateContoursOverIntervalBtn.Text = "Calculate";
            this.CalculateContoursOverIntervalBtn.UseVisualStyleBackColor = false;
            this.CalculateContoursOverIntervalBtn.Click += new System.EventHandler(this.CalculateContoursOverIntervalBtn_Click);
            // 
            // ContoursToggleDisplayOverIntervalBtn
            // 
            this.ContoursToggleDisplayOverIntervalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ContoursToggleDisplayOverIntervalBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContoursToggleDisplayOverIntervalBtn.Location = new System.Drawing.Point(18, 149);
            this.ContoursToggleDisplayOverIntervalBtn.Name = "ContoursToggleDisplayOverIntervalBtn";
            this.ContoursToggleDisplayOverIntervalBtn.Size = new System.Drawing.Size(132, 31);
            this.ContoursToggleDisplayOverIntervalBtn.TabIndex = 15;
            this.ContoursToggleDisplayOverIntervalBtn.Text = "Toggle Display";
            this.ContoursToggleDisplayOverIntervalBtn.UseVisualStyleBackColor = false;
            this.ContoursToggleDisplayOverIntervalBtn.Click += new System.EventHandler(this.ContoursToggleDisplayOverIntervalBtn_Click);
            // 
            // MeshLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 737);
            this.Controls.Add(this.ContoursGroupBox);
            this.Controls.Add(this.colorMapping1);
            this.Controls.Add(this.DataGroupBox);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.ColoringGroupBox);
            this.Controls.Add(this.SimpleOpenGlControl);
            this.Controls.Add(this.LoadFileButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MeshLoaderForm";
            this.Text = "Mesh Loader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ColoringGroupBox.ResumeLayout(false);
            this.ColoringGroupBox.PerformLayout();
            this.DataGroupBox.ResumeLayout(false);
            this.DataGroupBox.PerformLayout();
            this.ContoursWithNumberGroupBox.ResumeLayout(false);
            this.ContoursWithNumberGroupBox.PerformLayout();
            this.ContoursGroupBox.ResumeLayout(false);
            this.ContoursGroupBox.PerformLayout();
            this.ContoursOverIntervalGroupBox.ResumeLayout(false);
            this.ContoursOverIntervalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadFileButton;
        private Tao.Platform.Windows.SimpleOpenGlControl SimpleOpenGlControl;
        private System.Windows.Forms.ComboBox DataComboBox;
        private System.Windows.Forms.Label DataNameLabel;
        private System.Windows.Forms.RadioButton EdgeColoringBox;
        private System.Windows.Forms.RadioButton FaceColoringBox;
        private System.Windows.Forms.GroupBox ColoringGroupBox;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.GroupBox DataGroupBox;
        private WindowsFormsControlLibrary1.ColorMapping colorMapping1;
        private System.Windows.Forms.Button DisplayValuesButton;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MinValueLabel;
        private System.Windows.Forms.Label MaxValueLabel;
        private System.Windows.Forms.Button ClearMeshBtn;
        private System.Windows.Forms.GroupBox ContoursWithNumberGroupBox;
        private System.Windows.Forms.Button CalculateContoursWithNumberBtn;
        private System.Windows.Forms.Button ContoursToggleDisplayWithNumberBtn;
        private System.Windows.Forms.TextBox NumberOfContoursTxtBox;
        private System.Windows.Forms.Label ContoursNumberLabel;
        private System.Windows.Forms.GroupBox ContoursGroupBox;
        private System.Windows.Forms.GroupBox ContoursOverIntervalGroupBox;
        private System.Windows.Forms.Button CalculateContoursOverIntervalBtn;
        private System.Windows.Forms.Button ContoursToggleDisplayOverIntervalBtn;
        private System.Windows.Forms.TextBox ContourIntervalStartTxtBox;
        private System.Windows.Forms.Label ContourIntervalStartLabel;
        private System.Windows.Forms.TextBox ContourIntervalEndTxtBox;
        private System.Windows.Forms.Label ContourIntervalEndLabel;
        private System.Windows.Forms.TextBox ContourIntervalStepTxtBox;
        private System.Windows.Forms.Label ContourIntervalStepLabel;
        private System.Windows.Forms.RadioButton ContoursOverIntervalRadioButton;
        private System.Windows.Forms.RadioButton ContoursWithNumberRadioButton;
        private System.Windows.Forms.Button ClearContours;
    }
}

