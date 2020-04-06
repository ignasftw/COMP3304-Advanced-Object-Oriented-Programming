using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CollectionView : Form
    {
        //Declare an IImageFactoryLocal which would be responsible for returning modified version of an image, call it '_imfac'
        private IImageFactoryLocal _imfac;

        //Declare an ILoader which would be responsible for loading images into the galery, call it '_loading'
        private ILoader _loading;

        //Declare a factory which will be creating and returning components, call it'_factory'
        private Factory.IComponentFactory _factory = new Factory.ComponentFactory();

        //Declare an IImageGallery which will store Image Galery, call it '_imageGallery'
        private IImageGallery _imageGallery;

        //Single Image display window
        private ImagePinkifier _imagePinkifier;

        //List of images which has to be displayed
        List<Image> _displayList;

        private void CollectionView_Load(object sender, EventArgs e)
        {

        }

        public CollectionView()
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            _imagePinkifier = new ImagePinkifier();
            //Initialising ImageFactory Component
            _imfac = (IImageFactoryLocal)_factory.Get<ImageFactoryLocal>();
            //Initialising Image Loader Component
            _loading = (ILoader)_factory.Get<ImageLoader>();
            //Creating through factory doesn't allow to pass any variables
            _imageGallery = new ImageGallery(imageCounter, imageName, _imagePinkifier.PictureBox);

            //listView1.Columns.Add("Item");
            //listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _loading.Load(_imageGallery, _imagePinkifier.PictureBox, _imfac);

            //Show Image Display Window
            _imagePinkifier.Show();

            //Locally loaded images
            _displayList = _imageGallery.GetAllImages();

            if (_displayList != null)
            {
                listView1.View = View.LargeIcon;
                imageList1.ImageSize = new Size(64, 64);
                listView1.LargeImageList = this.imageList1;

                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = 50;
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;


                listView1.View = View.LargeIcon;
                imageList1.ImageSize = new Size(32, 32);
                listView1.LargeImageList = this.imageList1;

                for (int i = 0; i < imageList1.Images.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    this.listView1.Items.Add(item);

                }
            }
        }
    }
}

