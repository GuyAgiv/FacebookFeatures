using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public sealed partial class FilteredPhotosDisplayForm : Form
    {
        private const int k_StepBack = -1;
        private const int k_StepForward = 1;
        private static FilteredPhotosDisplayForm s_FilterPhotosDisplayForm;
        private static object s_LockObj = new object();
        private List<PhotoForShow> m_PhotoList;
            
        public event Action<PictureBox> BackgroundSelected = null;

        public static FilteredPhotosDisplayForm Instance
        {
            get
            {
                if (s_FilterPhotosDisplayForm == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_FilterPhotosDisplayForm == null)
                        {
                            s_FilterPhotosDisplayForm = new FilteredPhotosDisplayForm();
                        }
                    }
                }

                return s_FilterPhotosDisplayForm;
            }
        }

        public List<PhotoForShow> PhotosList
        {
            get
            {
                return m_PhotoList;
            }

            set
            {
                m_PhotoList = value;
                refreshPhotoData();
                CurrentPicDisplayed = 0;
            }
        }

        public int CurrentPicDisplayed { get; set; }

        public int AmountOfLikes { get; set; }

        //// Private Constructor as singletone
        private FilteredPhotosDisplayForm()
        {
            InitializeComponent();
            m_PhotoList = new List<PhotoForShow>();

            BackgroundSelected += drawBackground;
        }

        private void runNumOfLikes()
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(timerTickEventHandler);
            AmountOfLikes = 0;
            timer.Interval = 20;
            timer.Enabled = true;
            timer.Start();
        }

        private void timerTickEventHandler(object sender, EventArgs e)
        {
            if (int.Parse(textBoxNumOfLikes.Text) < PhotosList[CurrentPicDisplayed].ListOfFrindsLiked.Count)
            {
                int numOfLikes = int.Parse(textBoxNumOfLikes.Text);
                numOfLikes++;
                textBoxNumOfLikes.Text = numOfLikes.ToString();
            }
        }

        private void buttonNextPic_Click(object sender, EventArgs e)
        {
            navigatePictures(k_StepForward);
        }

        private void buttonPrevPic_Click(object sender, EventArgs e)
        {
            navigatePictures(k_StepBack);
        }

        private void navigatePictures(int i_Direction)
        {
            if ((CurrentPicDisplayed == 0) && i_Direction == k_StepBack)
            {
                MessageBox.Show("This is the first photo we've found within the collection..");
            }
            else if ((CurrentPicDisplayed == PhotosList.Count - 1) && i_Direction == k_StepForward)
            {
                MessageBox.Show("This is the last photo we've found within the collection..");
            }
            else
            {
                CurrentPicDisplayed += i_Direction;
                refreshPhotoData();
            }
        }

        private void refreshPhotoData()
        {
            pictureBoxCurrentPhoto.Load(PhotosList[CurrentPicDisplayed].URL);
            pictureBoxCurrentPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            textBoxNumOfLikes.Text = "0";
            runNumOfLikes();
            populateFriendsWhoLike();
        }

        private void populateFriendsWhoLike()
        {
            listBoxFriendsWhoLike.Items.Clear();
            foreach (string name in PhotosList[CurrentPicDisplayed].ListOfFrindsLiked)
            {
                listBoxFriendsWhoLike.Items.Add(name);
            }
        }

        private void setBackgroundButton_Click(object sender, EventArgs e)
        {
            BackgroundSelected.Invoke(pictureBoxCurrentPhoto);
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            string photoName = "MyPictureFromFacebook" + CurrentPicDisplayed + 1;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.FileName = photoName;
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != string.Empty)
            {
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBoxCurrentPhoto.Image.Save(
                            fs,
                            System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBoxCurrentPhoto.Image.Save(
                            fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        pictureBoxCurrentPhoto.Image.Save(
                            fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void filteredPhotosDisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentPicDisplayed = 0;
        }

        private void drawBackground(PictureBox i_PictureBox)
        {
            FormUtils.UpdateFormBackground(i_PictureBox, BackgroundImage, BackgroundImageLayout);
        }
    }
}
