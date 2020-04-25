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
        //DECLARE a Delegate which asks to load images into a data class
        ICommand _LoadImages;

        //DECLARE a Delegate which asks open an ItemDisplayer
        ICommand _displayView;

        //DECLARE a Delegate which asks to load images into a data class
        Action<ICommand> _executorCommand;

        /// <summary>
        /// PROPERTY which tell outside classes which image is currently selected
        /// </summary>
        public int _selectedImage { get { return System.Convert.ToInt32(ListView1.SelectedItems[0]?.Tag); } }

        private void CollectionView_Load(object sender, EventArgs e)
        {

        }
        //CONSTRUCTOR of CollectionView which sets given commands
        public CollectionView(Action LoadImages, Action displayView, Action<ICommand> executor)
        {
            //Initialises all the buttons and other GUI
            InitializeComponent();
            //Set _LoadImages command 
            _LoadImages = new Command(LoadImages);
            //Set _displayView command 
            _displayView = new Command(displayView);
            //Set _executorCommand command which will execute commands
            _executorCommand = executor;
            //Allow selecting one image at the time
            ListView1.MultiSelect = false;
        }

        /// <summary>
        /// Clears what is loaded in ImageList and Loads new array of Images that are in Data
        /// </summary>
        /// <param name="items"></param>
        public void SetListView(ListViewItem[] items)
        {
            //Clear has to be called here because ListView1 is private
            ListView1.Items.Clear();
            //Adding items to the list because the ListView1 is private
            ListView1.Items.AddRange(items);
        }

        public void SetImageList(Image[] images)
        {
            //Clear has to be called here because imageList1 is private
            imageList1.Images.Clear();
            //Adding items to the list because the imageList1 is private
            imageList1.Images.AddRange(images);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //It must check if there is a selected item, if not it will return null and throw exception
            if (ListView1.SelectedItems.Count > 0)
            {
                //Turn on ImagePinkifier because image was selected
                _executorCommand(_displayView);
            }
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            _executorCommand(_LoadImages);
        }
    }
}