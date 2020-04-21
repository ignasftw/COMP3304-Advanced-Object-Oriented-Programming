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
        //DECLARE a Delegate which stores a function to get all images;
        Func<List<Image>> _GetImageList;

        //DECLARE a Delegate which asks to load images into a data class
        Action _LoadImages;

        //DECLARE a Delegate which asks open an ItemDisplayer
        Action _displayView;

        public int _selectedImage { get { return System.Convert.ToInt32(ListView1.SelectedItems[0]?.Tag); } }

        private void CollectionView_Load(object sender, EventArgs e)
        {

        }

        public CollectionView(Action LoadImages, Func<List<Image>> GetImages, Action displayView)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();

            _GetImageList = GetImages;
            _LoadImages = LoadImages;
            _displayView = displayView;

            //ListView1.GridLines = true;
            //ListView1.Sorting = SortOrder.Ascending;
            ListView1.MultiSelect = false;
        }


        //Change into a comand call which calls which adds images if there are not on the list
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _LoadImages();
        }

        public void SetListView(ListViewItem[] items)
        {
            ListView1.Items.Clear();
            ListView1.Items.AddRange(items);
        }

        public void SetImageList(Image[] images)
        {
            imageList1.Images.Clear();
            imageList1.Images.AddRange(images);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0)
            {
                //Turn on ImagePinkifier because image was selected
                _displayView();
            }
        }
    }
}