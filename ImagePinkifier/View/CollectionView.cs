using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class CollectionView : Form
    {
        //Declare an IImageFactoryLocal which would be responsible for returning modified version of an image, call it '_imfac'
        //private IImageFactoryLocal _imfac;

        //Declare an ILoader which would be responsible for loading images into the galery, call it '_loading'
        //private ILoader _loading;

        //Declare a factory which will be creating and returning components, call it'_factory'
        //private Factory.IComponentFactory _factory = new Factory.ComponentFactory();

        //Declare an IImageGallery which will store Image Galery, call it '_imageGallery'
        //private IImageGallery _imageGallery;

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

            //_imagePinkifier = new ImagePinkifier();
            //Initialising ImageFactory Component
            //_imfac = (IImageFactoryLocal)_factory.Get<ImageFactoryLocal>();
            //Initialising Image Loader Component
            //_loading = (ILoader)_factory.Get<ImageLoader>();
            //Creating through factory doesn't allow to pass any variables
            //_imageGallery = new ImageGallery(imageCounter, imageName, _imagePinkifier.PictureBox);

            //listView1.Columns.Add("Item");
            //listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            imageName.Text = "";
            listView1.View = System.Windows.Forms.View.Details;

            listView1.LabelEdit = true;

            listView1.GridLines = true;

            listView1.Sorting = SortOrder.Ascending;

            AddImageElement();

        }


        //Change into a comand call which calls which adds images if there are not on the list
        private void loadImageButton_Click(object sender, EventArgs e)
        {

            //Setup how the list looks like
            imageList1.ImageSize = new Size(96, 96);
            //listView1.View = View.LargeIcon;
            listView1.LargeImageList = this.imageList1;

        }

        void UpdateUI()
        {

        }

        void AddImageElement()
        {
            ListViewItem item = new ListViewItem("item1", 0);
            item.Text = "Image";
            

            imageList1.Images.Add(Bitmap.FromFile("C:/Users/Viktorija/Documents/GitHub/COMP3304-Advanced-Object-Oriented-Programming/ImagePinkifier/FishAssets/AnglerFish_Lit.png"));
            imageList1.Images.Add(new Bitmap(100,100));

            
            //listView1.Items.Add(Image.FromFile("C:/Users/Viktorija/Documents/GitHub/COMP3304-Advanced-Object-Oriented-Programming/ImagePinkifier/ImagePinkifier/ExampleImages/FishAssets/AnglerFish_Lit.png"));
            //listView1.Items.Add(Image.FromFile());

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

