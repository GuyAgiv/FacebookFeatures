using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class MainForm : Form
    {
        ////Our Transparent Facade
        private PopulaterFacade m_PopulaterFacade;

        public MainForm()
        {
            InitializeComponent();
            m_PopulaterFacade = new PopulaterFacade();

            FilteredPhotosDisplayForm.Instance.BackgroundSelected += drawBackground;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_PopulaterFacade.PrepareApp();
            generateInfoForUser();
            populateMenu();
        }
        
        private void getHoroscope()
        {
            try
            {
                DateTime userBDay;

                DateTime.TryParse(m_PopulaterFacade.Authenticator.LoggedInUser.Birthday, out userBDay);
                ZodiacFetcher horoscopeFetcher = new ZodiacFetcher();
                string result = horoscopeFetcher.GetHoroscope(userBDay);

                if (result.Length == 0 || result == "[]")
                {
                    result = "Could not fetch your horoscope, please try again later";
                }

                MessageBox.Show(result);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not fetch your horoscope, please try again later");
            }
        }

        private TSItemCommand createWeatherMenu()
        {
            TSItemCommand weathrMenu = new TSItemCommand();
            
            int eventsCount = m_PopulaterFacade.WeatherFetcher.FetchFutureEvents();            
            weathrMenu.Text = "Display my upcoming events";
            weathrMenu.Command = getEvents;
            if (eventsCount > 0)
            {
                weathrMenu.ToolTipText = "Display my events";                
                weathrMenu.Enabled = true;
            }
            else
            {
                weathrMenu.ToolTipText = "No events registered in the next 4 days";
                weathrMenu.Enabled = false;
            }

            return weathrMenu;
        }

        private void displayEventsAndWeatherInfo()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => panelEventList.Visible = true));
                Invoke(new Action(() => panelEventDetails.Visible = true));
            }
            else
            {
                panelEventList.Visible = true;
                panelEventDetails.Visible = true;
            }
        }

        private void populateMenu()
        {
            ////Op1 Command
            FBFunctionsToolStripMenuItem.DropDownItems.Add(createWeatherMenu());
            ////Op2 Command
            FBFunctionsToolStripMenuItem.DropDownItems.Add(new TSItemCommand() { Command = getHoroscope, Text = "Check my horoscope", ToolTipText = "Get horoscope from remote API" });
            ////Op3 Command
            FBFunctionsToolStripMenuItem.DropDownItems.Add(new TSItemCommand() { Command = logOut, Text = "Logout", ToolTipText = "Logout from the app" });
        }

        private void buttonPicFilter_Click(object sender, EventArgs e)
        {
            FilterOptionsForm form2 = new FilterOptionsForm();
            form2.ShowDialog();
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status postedStatus;

            if (!string.IsNullOrEmpty(richTextBoxPostStatus.Text))
            {
                try
                {
                    postedStatus = m_PopulaterFacade.Authenticator.LoggedInUser.PostStatus(richTextBoxPostStatus.Text);
                    MessageBox.Show("Your post status has succeeded");
                    richTextBoxPostStatus.ResetText();
                }
                catch (Facebook.FacebookOAuthException ex)
                {
                    ////Note that the new app(the one that starts with 16) has permission for posting,if needed please use it.
                    MessageBox.Show("Missing permissions for posting status\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cannot post an empty status!");
            }
        }

        private void generateInfoForUser()
        {
            getUserProfileAndCoverPictures();
            fetchFriendsList();
        }

        private void fetchFriendsList()
        {
            listBoxFriendsList.Items.Clear();

            foreach (User friend in m_PopulaterFacade.Authenticator.LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend.Name);
            }
        }

        private void getUserProfileAndCoverPictures()
        {
            if (m_PopulaterFacade.Authenticator != null && m_PopulaterFacade.Authenticator.LoggedInUser != null)
            {
                pictureBoxCover.Load(m_PopulaterFacade.Authenticator.LoggedInUser.Cover.SourceURL);
                pictureBoxProfile.Load(m_PopulaterFacade.Authenticator.LoggedInUser.PictureSqaureURL);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_PopulaterFacade.Authenticator.Logout();
            MessageBox.Show("Logged out! Please relogin if you wish to continue using the app.");
            try
            {
                m_PopulaterFacade.ResetApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void logOut()
        {
            m_PopulaterFacade.Authenticator.Logout();
            MessageBox.Show("Logged out! Please relogin if you wish to continue using the app.");
            try
            {
                m_PopulaterFacade.ResetApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void appendText(RichTextBox i_Box, string i_Text, string i_Heat)
        {
            Color color = Color.Green;

            if (i_Heat == m_PopulaterFacade.WeatherFetcher.ColdWeather)
            {
                color = Color.Blue;
            }
            else if (i_Heat == m_PopulaterFacade.WeatherFetcher.HotWeather)
            {
                color = Color.Red;
            }

            i_Box.SelectionStart = i_Box.TextLength;
            i_Box.SelectionLength = 0;
            i_Box.SelectionColor = color;
            i_Box.AppendText(i_Text);
            i_Box.SelectionColor = i_Box.ForeColor;
        }

        private void populateControllers(Dictionary<string, string> i_ValuesToPopulate)
        {
            pictureBoxWeatherIcon.Load(i_ValuesToPopulate["WeatherCode"]);
            panelEventDetails.Visible = true;

            richTextBoxWeatheStats.Clear();
            appendText(richTextBoxWeatheStats, i_ValuesToPopulate["TemperatureDescription"], i_ValuesToPopulate["Heat"]);
            richTextBoxWeatheStats.AppendText(i_ValuesToPopulate["WeatherDescription"]);
        }

        private void setBindingSourceDataSource(object i_NewDataSource)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object>(setBindingSourceDataSource), i_NewDataSource);
            }
            else
            {
                eventBindingSource.DataSource = i_NewDataSource;
            }
        }

        private void getEvents()
        {
            new Thread(populateWeatherEvents).Start();
        }

        private void populateWeatherEvents()
        {
            m_PopulaterFacade.WeatherFetcher.FetchFutureEvents();
            if (m_PopulaterFacade.WeatherFetcher.UserEvents.EventList.Values.Count > 0)
            {
                setBindingSourceDataSource(m_PopulaterFacade.WeatherFetcher.UserEvents.EventList.Values);
                displayEventsAndWeatherInfo();
            }
        }

        private void listBoxEventsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventBindingSource.Current is Event)
            {
                Dictionary<string, string> weatherDetails;
                Event selectedEvent = eventBindingSource.Current as Event;

                try
                {
                    weatherDetails = m_PopulaterFacade.WeatherFetcher.GetWeatherForEvent(selectedEvent, false);
                }
                catch (WeatherException ex)
                {
                    MessageBox.Show(ex.Message);
                    weatherDetails = m_PopulaterFacade.WeatherFetcher.GetWeatherForEvent(selectedEvent, true);
                }

                populateControllers(weatherDetails);
            }
        }

        private void drawBackground(PictureBox i_PictureBox)
        {
            FormUtils.UpdateFormBackground(i_PictureBox, BackgroundImage, BackgroundImageLayout);    
        }
    }
}
