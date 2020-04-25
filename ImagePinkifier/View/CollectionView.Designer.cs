namespace View
{
    partial class CollectionView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.imageCounter = new System.Windows.Forms.Label();
            this.ImageName = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(96, 96);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadImageButton.AutoSize = true;
            this.LoadImageButton.Location = new System.Drawing.Point(793, 20);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(100, 30);
            this.LoadImageButton.TabIndex = 1;
            this.LoadImageButton.Text = "LoadImage";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // imageCounter
            // 
            this.imageCounter.Location = new System.Drawing.Point(0, 0);
            this.imageCounter.Name = "imageCounter";
            this.imageCounter.Size = new System.Drawing.Size(100, 23);
            this.imageCounter.TabIndex = 4;
            // 
            // ImageName
            // 
            this.ImageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageName.AutoSize = true;
            this.ImageName.Location = new System.Drawing.Point(16, 439);
            this.ImageName.Name = "ImageName";
            this.ImageName.Size = new System.Drawing.Size(351, 20);
            this.ImageName.TabIndex = 3;
            this.ImageName.Text = "Press \'Load\' button to load Files and then select.";
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.HideSelection = false;
            this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ListView1.LargeImageList = this.imageList1;
            this.ListView1.Location = new System.Drawing.Point(20, 20);
            this.ListView1.Margin = new System.Windows.Forms.Padding(0);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(767, 416);
            this.ListView1.SmallImageList = this.imageList1;
            this.ListView1.StateImageList = this.imageList1;
            this.ListView1.TabIndex = 5;
            this.ListView1.TileSize = new System.Drawing.Size(96, 96);
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // CollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 498);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.ImageName);
            this.Controls.Add(this.imageCounter);
            this.Controls.Add(this.LoadImageButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CollectionView";
            this.Text = "CollectionView";
            this.Load += new System.EventHandler(this.CollectionView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Label imageCounter;
        private System.Windows.Forms.Label ImageName;
        private System.Windows.Forms.ListView ListView1;
    }
}