namespace WindowsFormsApp1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(50, 450);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "⏴";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(560, 450);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "⏵";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadImageButton.Location = new System.Drawing.Point(300, 450);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 23);
            this.loadImageButton.TabIndex = 2;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(50, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(575, 375);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(650, 25);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(20, 20);
            this.zoomInButton.TabIndex = 4;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomAutoButton
            // 
            this.zoomAutoButton.Location = new System.Drawing.Point(650, 50);
            this.zoomAutoButton.Name = "zoomAutoButton";
            this.zoomAutoButton.Size = new System.Drawing.Size(20, 20);
            this.zoomAutoButton.TabIndex = 4;
            this.zoomAutoButton.Text = "A";
            this.zoomAutoButton.UseVisualStyleBackColor = true;
            this.zoomAutoButton.Click += new System.EventHandler(this.zoomAutoButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(650, 75);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(20, 20);
            this.zoomOutButton.TabIndex = 4;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveImageButton.Location = new System.Drawing.Point(175, 420);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(75, 23);
            this.saveImageButton.TabIndex = 2;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // makePinkerButton
            // 
            this.makePinkerButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.makePinkerButton.Location = new System.Drawing.Point(425, 420);
            this.makePinkerButton.Name = "makePinkerButton";
            this.makePinkerButton.Size = new System.Drawing.Size(75, 23);
            this.makePinkerButton.TabIndex = 2;
            this.makePinkerButton.Text = "Make Pinker";
            this.makePinkerButton.UseVisualStyleBackColor = true;
            // 
            // ImagePinkifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 486);
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
            this.Name = "ImagePinkifier";
            this.Text = "\'); DROP TABLE \"Teams\"; -- Image Pinkifier";
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
    }
}

