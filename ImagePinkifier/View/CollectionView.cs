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

        //DECLARE a Delegate which stores a function to get all images;
        Func<List<Image>> _ImageList;

        private int _imageid = 0;

        private void CollectionView_Load(object sender, EventArgs e)
        {

        }

        public CollectionView(Func<List<Image>> ImageList)
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
            _ImageList = ImageList;

            //listView1.View = System.Windows.Forms.View.Details;

            listView1.LabelEdit = true;

            listView1.GridLines = true;

            listView1.Sorting = SortOrder.Ascending;

            

        }


        //Change into a comand call which calls which adds images if there are not on the list
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            UpdateUI();
        }

        void UpdateUI()
        {
            listView1.Controls.Clear();
            List<Image> templist = _ImageList();

            imageList1.Images.AddRange(templist.ToArray());


            for (int i = 0; i < templist.Count; i++)
            {
                ListViewItem tempItem = new ListViewItem();
                tempItem.Name = _imageid.ToString();
                Console.WriteLine(listView1.Items.Count.ToString());
                tempItem.ImageIndex = _imageid;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

