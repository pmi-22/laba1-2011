namespace Kiri11
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.FuncCheckBox = new System.Windows.Forms.CheckBox();
            this.DerivativeCheckBox = new System.Windows.Forms.CheckBox();
            this.x0Label = new System.Windows.Forms.Label();
            this.RootTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ScaleIncreaseButton = new System.Windows.Forms.Button();
            this.ScaleDecreaseButton = new System.Windows.Forms.Button();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.FuncPictureBox = new System.Windows.Forms.PictureBox();
            this.DerivativePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerivativePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(27, 40);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 394);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            // 
            // FuncCheckBox
            // 
            this.FuncCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FuncCheckBox.AutoSize = true;
            this.FuncCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FuncCheckBox.ForeColor = System.Drawing.Color.Blue;
            this.FuncCheckBox.Location = new System.Drawing.Point(286, 40);
            this.FuncCheckBox.Name = "FuncCheckBox";
            this.FuncCheckBox.Size = new System.Drawing.Size(88, 23);
            this.FuncCheckBox.TabIndex = 1;
            this.FuncCheckBox.Text = "Функция";
            this.FuncCheckBox.UseVisualStyleBackColor = true;
            this.FuncCheckBox.CheckedChanged += new System.EventHandler(this.GraphCheckBox_CheckedChanged);
            // 
            // DerivativeCheckBox
            // 
            this.DerivativeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DerivativeCheckBox.AutoSize = true;
            this.DerivativeCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DerivativeCheckBox.ForeColor = System.Drawing.Color.Red;
            this.DerivativeCheckBox.Location = new System.Drawing.Point(286, 137);
            this.DerivativeCheckBox.Name = "DerivativeCheckBox";
            this.DerivativeCheckBox.Size = new System.Drawing.Size(120, 23);
            this.DerivativeCheckBox.TabIndex = 2;
            this.DerivativeCheckBox.Text = "Производная";
            this.DerivativeCheckBox.UseVisualStyleBackColor = true;
            this.DerivativeCheckBox.CheckedChanged += new System.EventHandler(this.DerivativeCheckBox_CheckedChanged);
            // 
            // x0Label
            // 
            this.x0Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.x0Label.AutoSize = true;
            this.x0Label.Font = new System.Drawing.Font("Calibri", 14F);
            this.x0Label.Location = new System.Drawing.Point(282, 250);
            this.x0Label.Name = "x0Label";
            this.x0Label.Size = new System.Drawing.Size(38, 23);
            this.x0Label.TabIndex = 3;
            this.x0Label.Text = "x₀ =";
            // 
            // RootTextBox
            // 
            this.RootTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RootTextBox.Location = new System.Drawing.Point(326, 253);
            this.RootTextBox.Name = "RootTextBox";
            this.RootTextBox.ReadOnly = true;
            this.RootTextBox.Size = new System.Drawing.Size(126, 20);
            this.RootTextBox.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(391, 442);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(89, 30);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ScaleIncreaseButton
            // 
            this.ScaleIncreaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleIncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleIncreaseButton.Location = new System.Drawing.Point(318, 352);
            this.ScaleIncreaseButton.Name = "ScaleIncreaseButton";
            this.ScaleIncreaseButton.Size = new System.Drawing.Size(61, 37);
            this.ScaleIncreaseButton.TabIndex = 8;
            this.ScaleIncreaseButton.Text = "+";
            this.ScaleIncreaseButton.UseVisualStyleBackColor = true;
            this.ScaleIncreaseButton.Click += new System.EventHandler(this.ScaleIncreaseButton_Click);
            // 
            // ScaleDecreaseButton
            // 
            this.ScaleDecreaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleDecreaseButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleDecreaseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScaleDecreaseButton.Location = new System.Drawing.Point(391, 352);
            this.ScaleDecreaseButton.Name = "ScaleDecreaseButton";
            this.ScaleDecreaseButton.Size = new System.Drawing.Size(61, 37);
            this.ScaleDecreaseButton.TabIndex = 9;
            this.ScaleDecreaseButton.Text = "-";
            this.ScaleDecreaseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScaleDecreaseButton.UseVisualStyleBackColor = true;
            this.ScaleDecreaseButton.Click += new System.EventHandler(this.ScaleDecreaseButton_Click);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScaleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ScaleLabel.Location = new System.Drawing.Point(334, 324);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(104, 25);
            this.ScaleLabel.TabIndex = 10;
            this.ScaleLabel.Text = "Масштаб";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Cambria", 9F);
            this.NoteLabel.Location = new System.Drawing.Point(326, 276);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(58, 14);
            this.NoteLabel.TabIndex = 11;
            this.NoteLabel.Text = "x ∈ [0;2π]";
            // 
            // FuncPictureBox
            // 
            this.FuncPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FuncPictureBox.Image")));
            this.FuncPictureBox.Location = new System.Drawing.Point(286, 70);
            this.FuncPictureBox.Name = "FuncPictureBox";
            this.FuncPictureBox.Size = new System.Drawing.Size(120, 22);
            this.FuncPictureBox.TabIndex = 12;
            this.FuncPictureBox.TabStop = false;
            // 
            // DerivativePictureBox
            // 
            this.DerivativePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DerivativePictureBox.Image")));
            this.DerivativePictureBox.Location = new System.Drawing.Point(286, 167);
            this.DerivativePictureBox.Name = "DerivativePictureBox";
            this.DerivativePictureBox.Size = new System.Drawing.Size(120, 29);
            this.DerivativePictureBox.TabIndex = 13;
            this.DerivativePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 484);
            this.ControlBox = false;
            this.Controls.Add(this.DerivativePictureBox);
            this.Controls.Add(this.FuncPictureBox);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.ScaleDecreaseButton);
            this.Controls.Add(this.ScaleIncreaseButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RootTextBox);
            this.Controls.Add(this.x0Label);
            this.Controls.Add(this.DerivativeCheckBox);
            this.Controls.Add(this.FuncCheckBox);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.Text = "Первая лабораторная Кирилла Игнатьева";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuncPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DerivativePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox FuncCheckBox;
        private System.Windows.Forms.CheckBox DerivativeCheckBox;
        private System.Windows.Forms.Label x0Label;
        private System.Windows.Forms.TextBox RootTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ScaleIncreaseButton;
        private System.Windows.Forms.Button ScaleDecreaseButton;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.PictureBox FuncPictureBox;
        private System.Windows.Forms.PictureBox DerivativePictureBox;
    }
}

