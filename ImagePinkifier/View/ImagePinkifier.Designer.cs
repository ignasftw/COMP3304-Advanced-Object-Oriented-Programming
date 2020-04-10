namespace View
{
    partial class ImagePinkifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePinkifier));
            this.ScaleButton = new System.Windows.Forms.Button();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.MakePinkerButton = new System.Windows.Forms.Button();
            this.imageName = new System.Windows.Forms.Label();
            this.RotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScaleButton
            // 
            this.ScaleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScaleButton.Location = new System.Drawing.Point(75, 689);
            this.ScaleButton.Margin = new System.Windows.Forms.Padding(10);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Padding = new System.Windows.Forms.Padding(5);
            this.ScaleButton.Size = new System.Drawing.Size(114, 40);
            this.ScaleButton.TabIndex = 0;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetImageButton.Location = new System.Drawing.Point(627, 689);
            this.ResetImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Padding = new System.Windows.Forms.Padding(5);
            this.ResetImageButton.Size = new System.Drawing.Size(114, 40);
            this.ResetImageButton.TabIndex = 1;
            this.ResetImageButton.Text = "⟳ Reset Image";
            this.ResetImageButton.UseVisualStyleBackColor = true;
            this.ResetImageButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlipButton.Location = new System.Drawing.Point(343, 689);
            this.FlipButton.Margin = new System.Windows.Forms.Padding(10);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Padding = new System.Windows.Forms.Padding(5);
            this.FlipButton.Size = new System.Drawing.Size(114, 40);
            this.FlipButton.TabIndex = 2;
            this.FlipButton.Text = "Flip";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(75, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.MaximumSize = new System.Drawing.Size(800, 600);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 600);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveImageButton.AutoSize = true;
            this.SaveImageButton.Location = new System.Drawing.Point(761, 689);
            this.SaveImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Padding = new System.Windows.Forms.Padding(5);
            this.SaveImageButton.Size = new System.Drawing.Size(114, 40);
            this.SaveImageButton.TabIndex = 2;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MakePinkerButton
            // 
            this.MakePinkerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakePinkerButton.Location = new System.Drawing.Point(477, 689);
            this.MakePinkerButton.Margin = new System.Windows.Forms.Padding(10);
            this.MakePinkerButton.Name = "MakePinkerButton";
            this.MakePinkerButton.Padding = new System.Windows.Forms.Padding(5);
            this.MakePinkerButton.Size = new System.Drawing.Size(114, 40);
            this.MakePinkerButton.TabIndex = 2;
            this.MakePinkerButton.Text = "Red Tint";
            this.MakePinkerButton.UseVisualStyleBackColor = true;
            this.MakePinkerButton.Click += new System.EventHandler(this.MakePinkerButton_Click);
            // 
            // imageName
            // 
            this.imageName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageName.AutoSize = true;
            this.imageName.BackColor = System.Drawing.Color.Transparent;
            this.imageName.Location = new System.Drawing.Point(70, 14);
            this.imageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(136, 20);
            this.imageName.TabIndex = 7;
            this.imageName.Text = "No images loaded";
            this.imageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imageName.Click += new System.EventHandler(this.imageName_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RotateButton.Location = new System.Drawing.Point(209, 689);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(10);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Padding = new System.Windows.Forms.Padding(5);
            this.RotateButton.Size = new System.Drawing.Size(114, 40);
            this.RotateButton.TabIndex = 8;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            // 
            // ImagePinkifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1026, 748);
            this.ControlBox = false;
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.MakePinkerButton);
            this.Controls.Add(this.SaveImageButton);
            this.Controls.Add(this.FlipButton);
            this.Controls.Add(this.ResetImageButton);
            this.Controls.Add(this.ScaleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ImagePinkifier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "\'); DROP TABLE \"Teams\"; -- Image Pinkifier";
            this.Load += new System.EventHandler(this.ImagePinkifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScaleButton;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button MakePinkerButton;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.Button RotateButton;
    }
}

