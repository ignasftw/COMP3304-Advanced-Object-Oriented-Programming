namespace View.RequestForms
{
    partial class ScaleRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleRequestForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WidthTextbox = new System.Windows.Forms.NumericUpDown();
            this.HeightTextbox = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OkButton.ForeColor = System.Drawing.SystemColors.Window;
            this.OkButton.Location = new System.Drawing.Point(26, 12);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(144, 48);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CancelButton.Location = new System.Drawing.Point(238, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(144, 48);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 71);
            this.panel1.TabIndex = 3;
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Width.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Width.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Width.Location = new System.Drawing.Point(19, 41);
            this.Width.Multiline = true;
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.Size = new System.Drawing.Size(87, 34);
            this.Width.TabIndex = 3;
            this.Width.Text = "Width:";
            this.Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Height
            // 
            this.Height.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Height.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Height.Location = new System.Drawing.Point(19, 81);
            this.Height.Multiline = true;
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Size = new System.Drawing.Size(87, 34);
            this.Height.TabIndex = 5;
            this.Height.Text = "Height:";
            this.Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(266, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(36, 34);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "px";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(266, 81);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(36, 34);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "px";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HeightTextbox);
            this.groupBox1.Controls.Add(this.WidthTextbox);
            this.groupBox1.Controls.Add(this.Width);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Height);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Size";
            // 
            // WidthTextbox
            // 
            this.WidthTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WidthTextbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.WidthTextbox.Location = new System.Drawing.Point(112, 43);
            this.WidthTextbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthTextbox.Name = "WidthTextbox";
            this.WidthTextbox.Size = new System.Drawing.Size(148, 26);
            this.WidthTextbox.TabIndex = 9;
            this.WidthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HeightTextbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.HeightTextbox.Location = new System.Drawing.Point(112, 83);
            this.HeightTextbox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(148, 26);
            this.HeightTextbox.TabIndex = 10;
            this.HeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScaleRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 287);
            this.Name = "ScaleRequestForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Image Size";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown HeightTextbox;
        private System.Windows.Forms.NumericUpDown WidthTextbox;
    }
}