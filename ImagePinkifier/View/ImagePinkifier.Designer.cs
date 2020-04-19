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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagePinkifier));
            this.ScaleButton = new System.Windows.Forms.Button();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.FlipButton = new System.Windows.Forms.Button();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.MakePinkerButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScaleButton
            // 
            this.ScaleButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScaleButton.Location = new System.Drawing.Point(475, 22);
            this.ScaleButton.Margin = new System.Windows.Forms.Padding(10);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Padding = new System.Windows.Forms.Padding(5);
            this.ScaleButton.Size = new System.Drawing.Size(160, 52);
            this.ScaleButton.TabIndex = 0;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.Click += new System.EventHandler(this.ScaleButton_Click);
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.BackColor = System.Drawing.Color.Firebrick;
            this.ResetImageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResetImageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetImageButton.Location = new System.Drawing.Point(20, 22);
            this.ResetImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Padding = new System.Windows.Forms.Padding(5);
            this.ResetImageButton.Size = new System.Drawing.Size(135, 52);
            this.ResetImageButton.TabIndex = 1;
            this.ResetImageButton.Text = "⟳ Reset Image";
            this.ResetImageButton.UseVisualStyleBackColor = false;
            this.ResetImageButton.Click += new System.EventHandler(this.ResetImageButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FlipButton.Location = new System.Drawing.Point(635, 22);
            this.FlipButton.Margin = new System.Windows.Forms.Padding(10);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.Padding = new System.Windows.Forms.Padding(5);
            this.FlipButton.Size = new System.Drawing.Size(160, 52);
            this.FlipButton.TabIndex = 2;
            this.FlipButton.Text = "Flip";
            this.FlipButton.UseVisualStyleBackColor = true;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.AutoSize = true;
            this.SaveImageButton.BackColor = System.Drawing.Color.YellowGreen;
            this.SaveImageButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveImageButton.Location = new System.Drawing.Point(795, 22);
            this.SaveImageButton.Margin = new System.Windows.Forms.Padding(10);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Padding = new System.Windows.Forms.Padding(5);
            this.SaveImageButton.Size = new System.Drawing.Size(178, 52);
            this.SaveImageButton.TabIndex = 2;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = false;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MakePinkerButton
            // 
            this.MakePinkerButton.BackColor = System.Drawing.Color.Transparent;
            this.MakePinkerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MakePinkerButton.Enabled = false;
            this.MakePinkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakePinkerButton.Location = new System.Drawing.Point(155, 22);
            this.MakePinkerButton.Margin = new System.Windows.Forms.Padding(10);
            this.MakePinkerButton.Name = "MakePinkerButton";
            this.MakePinkerButton.Padding = new System.Windows.Forms.Padding(5);
            this.MakePinkerButton.Size = new System.Drawing.Size(160, 52);
            this.MakePinkerButton.TabIndex = 2;
            this.MakePinkerButton.Text = "Red Tint";
            this.MakePinkerButton.UseVisualStyleBackColor = false;
            this.MakePinkerButton.Click += new System.EventHandler(this.MakePinkerButton_Click);
            // 
            // RotateButton
            // 
            this.RotateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.RotateButton.Location = new System.Drawing.Point(315, 22);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(10);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Padding = new System.Windows.Forms.Padding(5);
            this.RotateButton.Size = new System.Drawing.Size(160, 52);
            this.RotateButton.TabIndex = 8;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ResetImageButton);
            this.groupBox2.Controls.Add(this.MakePinkerButton);
            this.groupBox2.Controls.Add(this.RotateButton);
            this.groupBox2.Controls.Add(this.ScaleButton);
            this.groupBox2.Controls.Add(this.FlipButton);
            this.groupBox2.Controls.Add(this.SaveImageButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 77);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functionalities";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(976, 494);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // ImagePinkifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 571);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ImagePinkifier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "\'); DROP TABLE \"Teams\"; -- Image Pinkifier";
            this.Load += new System.EventHandler(this.ImagePinkifier_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScaleButton;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.Button FlipButton;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button MakePinkerButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

