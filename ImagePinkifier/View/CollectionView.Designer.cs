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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionView));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.loadImageButton = new System.Windows.Forms.Button();
            this.imageCounter = new System.Windows.Forms.Label();
            this.imageName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AquariumBackground.png");
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImageButton.AutoSize = true;
            this.loadImageButton.Location = new System.Drawing.Point(793, 20);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(100, 30);
            this.loadImageButton.TabIndex = 1;
            this.loadImageButton.Text = "LoadImage";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // imageCounter
            // 
            this.imageCounter.Location = new System.Drawing.Point(0, 0);
            this.imageCounter.Name = "imageCounter";
            this.imageCounter.Size = new System.Drawing.Size(100, 23);
            this.imageCounter.TabIndex = 4;
            // 
            // imageName
            // 
            this.imageName.AutoSize = true;
            this.imageName.Location = new System.Drawing.Point(16, 439);
            this.imageName.Name = "imageName";
            this.imageName.Size = new System.Drawing.Size(96, 20);
            this.imageName.TabIndex = 3;
            this.imageName.Text = "ImageName";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(20, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 416);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 498);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.imageName);
            this.Controls.Add(this.imageCounter);
            this.Controls.Add(this.loadImageButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CollectionView";
            this.Text = "CollectionView";
            this.Load += new System.EventHandler(this.CollectionView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Label imageCounter;
        private System.Windows.Forms.Label imageName;
        private System.Windows.Forms.ListView listView1;
    }
}