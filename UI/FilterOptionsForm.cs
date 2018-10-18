using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class FilterOptionsForm : Form
    {
        public string FilterText { get; set; }

        public FilterOptionsForm()
        {
            InitializeComponent();
            FilteredPhotosDisplayForm.Instance.BackgroundSelected += drawBackground;
        }

        private void buttonStartFilter_Click(object sender, EventArgs e)
        {
            checkAndNavigateChosenFilterOption();
        }

        private void checkAndNavigateChosenFilterOption()
        {
            eFilterStyler filterStyler = eFilterStyler.ByLocation;
            bool createFilter = true;

            if (textBoxFilterVal.TextLength == 0)
            {
                MessageBox.Show("Filter box cannot be empty", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Photo> photoList = new List<Photo>();

                FilterText = textBoxFilterVal.Text;

                if (radioButtonByTaggedFriends.Checked)
                {
                    if (isFriendExist())
                    {
                        filterStyler = eFilterStyler.ByTaggedFriends;
                    }
                    else
                    {
                        MessageBox.Show("Friend name doesnt exist!");
                        createFilter = false;
                    }
                }

                if (createFilter)
                {                    
                    PhotoFilterStyler theFilter = PhotoFilterStyler.Create(filterStyler, FilterText);
                    photoList = theFilter.FetchPhotos();

                    if (photoList == null || photoList.Count == 0)
                    {
                        string failedMsg = string.Format("Couldnt Find a picture of {0}", FilterText);
                        MessageBox.Show(failedMsg);
                    }
                    else
                    {
                        FilteredPhotosDisplayForm.Instance.PhotosList = convertPhotosToPhotoForShow(photoList);
                        FilteredPhotosDisplayForm.Instance.ShowDialog();
                    }
                }
            }
        }

        private bool isFriendExist()
        {
            bool isFound = false;

            foreach (User friend in FBAuthenticator.Instance.LoggedInUser.Friends)
            {
                if (friend.Name == FilterText)
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }

        private List<PhotoForShow> convertPhotosToPhotoForShow(List<Photo> i_PhotosToConvert)
        {
            List<PhotoForShow> photoList = new List<PhotoForShow>();

            foreach (Photo photo in i_PhotosToConvert)
            {
                photoList.Add(new PhotoForShow(photo));
            }

            return photoList;
        }

        private void drawBackground(PictureBox i_PictureBox)
        {
            FormUtils.UpdateFormBackground(i_PictureBox, BackgroundImage, BackgroundImageLayout);
        }

        private void FilterOptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FilteredPhotosDisplayForm.Instance.BackgroundSelected -= drawBackground;
        }
    }
}