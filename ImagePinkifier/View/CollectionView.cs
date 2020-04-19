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
        //List of images which has to be displayed
        List<Image> _displayList;

        //DECLARE a Delegate which stores a function to get all images;
        Func<List<Image>> _GetImageList;

        //DECLARE a Delegate which asks to load images into a data class
        Action _LoadImages;

        //DECLARE a Delegate which asks open an ItemDisplayer
        Action _displayView;

        //DECLARE an int which is used for putting images into View
        private int _imageid = 0;

        public int _selectedImage;

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

            ListView1.GridLines = true;
            ListView1.Sorting = SortOrder.Ascending;
            ListView1.MultiSelect = false;
        }


        //Change into a comand call which calls which adds images if there are not on the list
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            _LoadImages();
        }

        public void OnDataHasBeenChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            _displayList = _GetImageList();
            if (_displayList != null)
            {
                List<ListViewItem> items = new List<ListViewItem>();
                imageList1.Images.Clear();
                ListView1.Clear();
                _imageid = 0;

                imageList1.Images.AddRange(_displayList.ToArray());

                for (int i = 0; i < _displayList.Count; i++)
                {
                    if (imageList1.Images[i] != _displayList[i])
                    {
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = _imageid;
                        item.Tag = _imageid.ToString();
                        items.Add(item);
                        _imageid++;
                    }
                }
                ListView1.Items.AddRange(items.ToArray());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView1.SelectedItems.Count > 0)
            {
                //Turn on ImagePinkifier because image was selected
                _selectedImage = System.Convert.ToInt32(ListView1.SelectedItems[0].Tag);
                _displayView();
            }
        }
    }
}