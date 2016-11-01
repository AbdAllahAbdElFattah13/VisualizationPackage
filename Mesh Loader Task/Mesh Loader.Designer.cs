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
            this.DisplayValuesButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.DataGroupBox = new System.Windows.Forms.GroupBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinValueLabel = new System.Windows.Forms.Label();
            this.MaxValueLabel = new System.Windows.Forms.Label();
            this.colorMapping1 = new WindowsFormsControlLibrary1.ColorMapping();
            this.ColoringGroupBox.SuspendLayout();
            this.DataGroupBox.SuspendLayout();
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
            this.LoadFileButton.Location = new System.Drawing.Point(1198, 21);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(112, 31);
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
            this.SimpleOpenGlControl.Size = new System.Drawing.Size(1095, 651);
            this.SimpleOpenGlControl.StencilBits = ((byte)(0));
            this.SimpleOpenGlControl.TabIndex = 3;
            this.SimpleOpenGlControl.Load += new System.EventHandler(this.SimpleOpenGlControl_Load);
            this.SimpleOpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.SimpleOpenGlControl_Paint);
            // 
            // DataComboBox
            // 
            this.DataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataComboBox.FormattingEnabled = true;
            this.DataComboBox.Location = new System.Drawing.Point(21, 39);
            this.DataComboBox.Name = "DataComboBox";
            this.DataComboBox.Size = new System.Drawing.Size(129, 27);
            this.DataComboBox.TabIndex = 4;
            this.DataComboBox.SelectedIndexChanged += new System.EventHandler(this.DataComboBox_SelectedIndexChanged);
            // 
            // DataNameLabel
            // 
            this.DataNameLabel.AutoSize = true;
            this.DataNameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataNameLabel.Location = new System.Drawing.Point(18, 24);
            this.DataNameLabel.Name = "DataNameLabel";
            this.DataNameLabel.Size = new System.Drawing.Size(37, 14);
            this.DataNameLabel.TabIndex = 5;
            this.DataNameLabel.Text = "Name";
            // 
            // EdgeColoringBox
            // 
            this.EdgeColoringBox.AutoSize = true;
            this.EdgeColoringBox.Location = new System.Drawing.Point(21, 36);
            this.EdgeColoringBox.Name = "EdgeColoringBox";
            this.EdgeColoringBox.Size = new System.Drawing.Size(121, 23);
            this.EdgeColoringBox.TabIndex = 8;
            this.EdgeColoringBox.TabStop = true;
            this.EdgeColoringBox.Text = "Edge Coloring";
            this.EdgeColoringBox.UseVisualStyleBackColor = true;
            this.EdgeColoringBox.CheckedChanged += new System.EventHandler(this.EdgeColoringBox_CheckedChanged);
            // 
            // FaceColoringBox
            // 
            this.FaceColoringBox.AutoSize = true;
            this.FaceColoringBox.Location = new System.Drawing.Point(21, 61);
            this.FaceColoringBox.Name = "FaceColoringBox";
            this.FaceColoringBox.Size = new System.Drawing.Size(118, 23);
            this.FaceColoringBox.TabIndex = 9;
            this.FaceColoringBox.TabStop = true;
            this.FaceColoringBox.Text = "Face Coloring";
            this.FaceColoringBox.UseVisualStyleBackColor = true;
            this.FaceColoringBox.CheckedChanged += new System.EventHandler(this.FaceColoringBox_CheckedChanged);
            // 
            // ColoringGroupBox
            // 
            this.ColoringGroupBox.Controls.Add(this.DisplayValuesButton);
            this.ColoringGroupBox.Controls.Add(this.FaceColoringBox);
            this.ColoringGroupBox.Controls.Add(this.EdgeColoringBox);
            this.ColoringGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColoringGroupBox.ForeColor = System.Drawing.Color.White;
            this.ColoringGroupBox.Location = new System.Drawing.Point(1162, 231);
            this.ColoringGroupBox.Name = "ColoringGroupBox";
            this.ColoringGroupBox.Size = new System.Drawing.Size(171, 131);
            this.ColoringGroupBox.TabIndex = 10;
            this.ColoringGroupBox.TabStop = false;
            this.ColoringGroupBox.Text = "Coloring";
            // 
            // DisplayValuesButton
            // 
            this.DisplayValuesButton.BackColor = System.Drawing.SystemColors.Control;
            this.DisplayValuesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisplayValuesButton.Location = new System.Drawing.Point(20, 90);
            this.DisplayValuesButton.Name = "DisplayValuesButton";
            this.DisplayValuesButton.Size = new System.Drawing.Size(130, 31);
            this.DisplayValuesButton.TabIndex = 10;
            this.DisplayValuesButton.Text = "Toggle Display Values";
            this.DisplayValuesButton.UseVisualStyleBackColor = false;
            this.DisplayValuesButton.Click += new System.EventHandler(this.DisplayValuesButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.BackColor = System.Drawing.Color.Black;
            this.InstructionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InstructionsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.White;
            this.InstructionsLabel.Location = new System.Drawing.Point(1139, 480);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(203, 192);
            this.InstructionsLabel.TabIndex = 11;
            this.InstructionsLabel.Text = resources.GetString("InstructionsLabel.Text");
            // 
            // DataGroupBox
            // 
            this.DataGroupBox.BackColor = System.Drawing.Color.Black;
            this.DataGroupBox.Controls.Add(this.MinLabel);
            this.DataGroupBox.Controls.Add(this.MaxLabel);
            this.DataGroupBox.Controls.Add(this.MinValueLabel);
            this.DataGroupBox.Controls.Add(this.MaxValueLabel);
            this.DataGroupBox.Controls.Add(this.DataNameLabel);
            this.DataGroupBox.Controls.Add(this.DataComboBox);
            this.DataGroupBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGroupBox.ForeColor = System.Drawing.Color.White;
            this.DataGroupBox.Location = new System.Drawing.Point(1162, 68);
            this.DataGroupBox.Name = "DataGroupBox";
            this.DataGroupBox.Size = new System.Drawing.Size(171, 135);
            this.DataGroupBox.TabIndex = 12;
            this.DataGroupBox.TabStop = false;
            this.DataGroupBox.Text = "Data";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(92, 77);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(36, 19);
            this.MinLabel.TabIndex = 9;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(17, 77);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(38, 19);
            this.MaxLabel.TabIndex = 8;
            this.MaxLabel.Text = "Max";
            // 
            // MinValueLabel
            // 
            this.MinValueLabel.AutoSize = true;
            this.MinValueLabel.Location = new System.Drawing.Point(89, 96);
            this.MinValueLabel.Name = "MinValueLabel";
            this.MinValueLabel.Size = new System.Drawing.Size(0, 19);
            this.MinValueLabel.TabIndex = 7;
            // 
            // MaxValueLabel
            // 
            this.MaxValueLabel.AutoSize = true;
            this.MaxValueLabel.Location = new System.Drawing.Point(17, 96);
            this.MaxValueLabel.Name = "MaxValueLabel";
            this.MaxValueLabel.Size = new System.Drawing.Size(0, 19);
            this.MaxValueLabel.TabIndex = 6;
            // 
            // colorMapping1
            // 
            this.colorMapping1.Location = new System.Drawing.Point(1139, 378);
            this.colorMapping1.Name = "colorMapping1";
            this.colorMapping1.Size = new System.Drawing.Size(216, 32);
            this.colorMapping1.TabIndex = 13;
            // 
            // MeshLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 737);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

