﻿namespace WindowsFormsApp1
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
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomAutoButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.makePinkerButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.imageCounter = new System.Windows.Forms.Label();
            this.imageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(75, 692);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(112, 35);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "⏴";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(840, 692);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(112, 35);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "⏵";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadImageButton.Location = new System.Drawing.Point(450, 692);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(112, 35);
            this.loadImageButton.TabIndex = 2;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(75, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(862, 575);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(975, 38);
            this.zoomInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(30, 31);
            this.zoomInButton.TabIndex = 4;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.ZoomInButton_Click);
            // 
            // zoomAutoButton
            // 
            this.zoomAutoButton.Location = new System.Drawing.Point(975, 77);
            this.zoomAutoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomAutoButton.Name = "zoomAutoButton";
            this.zoomAutoButton.Size = new System.Drawing.Size(30, 31);
            this.zoomAutoButton.TabIndex = 4;
            this.zoomAutoButton.Text = "A";
            this.zoomAutoButton.UseVisualStyleBackColor = true;
            this.zoomAutoButton.Click += new System.EventHandler(this.ZoomAutoButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(975, 115);
            this.zoomOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(30, 31);
            this.zoomOutButton.TabIndex = 4;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.ZoomOutButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveImageButton.Location = new System.Drawing.Point(262, 646);
            this.saveImageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(112, 35);
            this.saveImageButton.TabIndex = 2;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // makePinkerButton
            // 
            this.makePinkerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.makePinkerButton.Location = new System.Drawing.Point(638, 646);
            this.makePinkerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makePinkerButton.Name = "makePinkerButton";
            this.makePinkerButton.Size = new System.Drawing.Size(112, 35);
            this.makePinkerButton.TabIndex = 2;
            this.makePinkerButton.Text = "Make Pinker";
            this.makePinkerButton.UseVisualStyleBackColor = true;
            this.makePinkerButton.Click += new System.EventHandler(this.MakePinkerButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(572, 694);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(32, 32);
            this.reloadButton.TabIndex = 5;
            this.reloadButton.Text = "⟳";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // imageCounter
            // 
            this.imageCounter.Location = new System.Drawing.Point(384, 646);
            this.imageCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageCounter.Name = "imageCounter";
            this.imageCounter.Size = new System.Drawing.Size(244, 35);
            this.imageCounter.TabIndex = 6;
            this.imageCounter.Text = "No images loaded";
            this.imageCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageName
            // 
            this.imageName.BackColor = System.Drawing.Color.Transparent;
            this.imageName.Location = new System.Drawing.Point(70, 14);
            this.imageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(867, 43);
            this.imageName.TabIndex = 7;
            this.imageName.Text = "No images loaded";
            this.imageName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImagePinkifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1026, 748);
            this.ControlBox = false;
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.imageCounter);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomAutoButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.makePinkerButton);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ImagePinkifier";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "\'); DROP TABLE \"Teams\"; -- Image Pinkifier";
            this.Load += new System.EventHandler(this.ImagePinkifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomAutoButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.Button makePinkerButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Label imageCounter;
        private System.Windows.Forms.Label imageName;
    }
}

