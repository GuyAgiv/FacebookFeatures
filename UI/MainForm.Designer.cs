namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class MainForm
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
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.listBoxEventsList = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBoxPostStatus = new System.Windows.Forms.RichTextBox();
            this.richTextBoxWeatheStats = new System.Windows.Forms.RichTextBox();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.labelEventDetails = new System.Windows.Forms.Label();
            this.pictureBoxWeatherIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPicFilter = new RibbonStyle.RibbonMenuButton();
            this.buttonPostStatus = new RibbonStyle.RibbonMenuButton();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelUpcomingEvents = new System.Windows.Forms.Label();
            this.menuStripFBFuncs = new System.Windows.Forms.MenuStrip();
            this.FBFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEventList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.menuStripFBFuncs.SuspendLayout();
            this.panelEventList.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 16;
            this.listBoxFriendsList.Location = new System.Drawing.Point(3, 25);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(133, 276);
            this.listBoxFriendsList.TabIndex = 0;
            // 
            // listBoxEventsList
            // 
            this.listBoxEventsList.DataSource = this.eventBindingSource;
            this.listBoxEventsList.DisplayMember = "Name";
            this.listBoxEventsList.FormattingEnabled = true;
            this.listBoxEventsList.ItemHeight = 16;
            this.listBoxEventsList.Location = new System.Drawing.Point(9, 27);
            this.listBoxEventsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEventsList.Name = "listBoxEventsList";
            this.listBoxEventsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxEventsList.Size = new System.Drawing.Size(864, 132);
            this.listBoxEventsList.TabIndex = 1;
            this.listBoxEventsList.SelectedIndexChanged += new System.EventHandler(this.listBoxEventsList_SelectedIndexChanged);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // richTextBoxPostStatus
            // 
            this.richTextBoxPostStatus.Location = new System.Drawing.Point(105, 14);
            this.richTextBoxPostStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxPostStatus.Name = "richTextBoxPostStatus";
            this.richTextBoxPostStatus.Size = new System.Drawing.Size(433, 101);
            this.richTextBoxPostStatus.TabIndex = 4;
            this.richTextBoxPostStatus.Text = "";
            // 
            // richTextBoxWeatheStats
            // 
            this.richTextBoxWeatheStats.Enabled = false;
            this.richTextBoxWeatheStats.Location = new System.Drawing.Point(103, 46);
            this.richTextBoxWeatheStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxWeatheStats.Name = "richTextBoxWeatheStats";
            this.richTextBoxWeatheStats.ReadOnly = true;
            this.richTextBoxWeatheStats.Size = new System.Drawing.Size(357, 80);
            this.richTextBoxWeatheStats.TabIndex = 11;
            this.richTextBoxWeatheStats.Text = "";
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.BackColor = System.Drawing.Color.Linen;
            this.panelEventDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEventDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelEventDetails.Controls.Add(this.descriptionRichTextBox);
            this.panelEventDetails.Controls.Add(this.labelEventDetails);
            this.panelEventDetails.Controls.Add(this.richTextBoxWeatheStats);
            this.panelEventDetails.Controls.Add(this.pictureBoxWeatherIcon);
            this.panelEventDetails.Location = new System.Drawing.Point(916, 64);
            this.panelEventDetails.Margin = new System.Windows.Forms.Padding(4);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(497, 600);
            this.panelEventDetails.TabIndex = 69;
            this.panelEventDetails.Visible = false;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(17, 260);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(457, 137);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 76;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionRichTextBox.Location = new System.Drawing.Point(4, 444);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(455, 117);
            this.descriptionRichTextBox.TabIndex = 75;
            this.descriptionRichTextBox.Text = "";
            // 
            // labelEventDetails
            // 
            this.labelEventDetails.AutoSize = true;
            this.labelEventDetails.BackColor = System.Drawing.Color.Khaki;
            this.labelEventDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelEventDetails.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelEventDetails.Location = new System.Drawing.Point(195, 10);
            this.labelEventDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventDetails.Name = "labelEventDetails";
            this.labelEventDetails.Size = new System.Drawing.Size(100, 20);
            this.labelEventDetails.TabIndex = 14;
            this.labelEventDetails.Text = "Event Details";
            // 
            // pictureBoxWeatherIcon
            // 
            this.pictureBoxWeatherIcon.Location = new System.Drawing.Point(3, 57);
            this.pictureBoxWeatherIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            this.pictureBoxWeatherIcon.Size = new System.Drawing.Size(95, 53);
            this.pictureBoxWeatherIcon.TabIndex = 10;
            this.pictureBoxWeatherIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.pictureBoxCover);
            this.panel1.Location = new System.Drawing.Point(16, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 398);
            this.panel1.TabIndex = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.listBoxFriendsList);
            this.panel3.Controls.Add(this.labelFriendsList);
            this.panel3.Location = new System.Drawing.Point(7, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 267);
            this.panel3.TabIndex = 74;
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.BackColor = System.Drawing.Color.Gold;
            this.labelFriendsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelFriendsList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelFriendsList.Location = new System.Drawing.Point(4, 4);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(89, 20);
            this.labelFriendsList.TabIndex = 16;
            this.labelFriendsList.Text = "Friends List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonPicFilter);
            this.panel2.Controls.Add(this.buttonPostStatus);
            this.panel2.Controls.Add(this.richTextBoxPostStatus);
            this.panel2.Location = new System.Drawing.Point(156, 134);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 238);
            this.panel2.TabIndex = 73;
            // 
            // buttonPicFilter
            // 
            this.buttonPicFilter.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonPicFilter.BackColor = System.Drawing.Color.Transparent;
            this.buttonPicFilter.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonPicFilter.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonPicFilter.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonPicFilter.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonPicFilter.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPicFilter.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPicFilter.FadingSpeed = 0;
            this.buttonPicFilter.FlatAppearance.BorderSize = 0;
            this.buttonPicFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPicFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPicFilter.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonPicFilter.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonPicFilter.Image = global::A18_Ex03_Guy_203507926_Ben_302823927.Properties.Resources.if_Presentation_27867;
            this.buttonPicFilter.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPicFilter.ImageOffset = 5;
            this.buttonPicFilter.IsPressed = false;
            this.buttonPicFilter.KeepPress = false;
            this.buttonPicFilter.Location = new System.Drawing.Point(324, 143);
            this.buttonPicFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPicFilter.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPicFilter.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPicFilter.Name = "buttonPicFilter";
            this.buttonPicFilter.Radius = 8;
            this.buttonPicFilter.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPicFilter.Size = new System.Drawing.Size(216, 82);
            this.buttonPicFilter.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPicFilter.SplitDistance = 0;
            this.buttonPicFilter.TabIndex = 72;
            this.buttonPicFilter.TabStop = false;
            this.buttonPicFilter.Text = "Get Filtered Pics";
            this.buttonPicFilter.Title = "";
            this.buttonPicFilter.UseVisualStyleBackColor = true;
            this.buttonPicFilter.Click += new System.EventHandler(this.buttonPicFilter_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonPostStatus.BackColor = System.Drawing.Color.Transparent;
            this.buttonPostStatus.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonPostStatus.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonPostStatus.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonPostStatus.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonPostStatus.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonPostStatus.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPostStatus.FadingSpeed = 0;
            this.buttonPostStatus.FlatAppearance.BorderSize = 0;
            this.buttonPostStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonPostStatus.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonPostStatus.Image = global::A18_Ex03_Guy_203507926_Ben_302823927.Properties.Resources.if_Text_Document_27884;
            this.buttonPostStatus.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPostStatus.ImageOffset = 5;
            this.buttonPostStatus.IsPressed = false;
            this.buttonPostStatus.KeepPress = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(105, 143);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPostStatus.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Radius = 8;
            this.buttonPostStatus.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPostStatus.Size = new System.Drawing.Size(211, 82);
            this.buttonPostStatus.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPostStatus.SplitDistance = 0;
            this.buttonPostStatus.TabIndex = 71;
            this.buttonPostStatus.TabStop = false;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.Title = "";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(7, 12);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(135, 87);
            this.pictureBoxProfile.TabIndex = 7;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(156, 12);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(709, 118);
            this.pictureBoxCover.TabIndex = 2;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelUpcomingEvents
            // 
            this.labelUpcomingEvents.AutoSize = true;
            this.labelUpcomingEvents.BackColor = System.Drawing.Color.SpringGreen;
            this.labelUpcomingEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelUpcomingEvents.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelUpcomingEvents.Location = new System.Drawing.Point(336, 6);
            this.labelUpcomingEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpcomingEvents.Name = "labelUpcomingEvents";
            this.labelUpcomingEvents.Size = new System.Drawing.Size(182, 20);
            this.labelUpcomingEvents.TabIndex = 17;
            this.labelUpcomingEvents.Text = "Upcoming Evens(5 days)";
            // 
            // menuStripFBFuncs
            // 
            this.menuStripFBFuncs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFBFuncs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FBFunctionsToolStripMenuItem});
            this.menuStripFBFuncs.Location = new System.Drawing.Point(0, 0);
            this.menuStripFBFuncs.Name = "menuStripFBFuncs";
            this.menuStripFBFuncs.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripFBFuncs.ShowItemToolTips = true;
            this.menuStripFBFuncs.Size = new System.Drawing.Size(1425, 28);
            this.menuStripFBFuncs.TabIndex = 71;
            this.menuStripFBFuncs.Text = "menuStrip1";
            // 
            // FBFunctionsToolStripMenuItem
            // 
            this.FBFunctionsToolStripMenuItem.Name = "FBFunctionsToolStripMenuItem";
            this.FBFunctionsToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.FBFunctionsToolStripMenuItem.Text = "FBFunctions";
            // 
            // panelEventList
            // 
            this.panelEventList.Controls.Add(this.labelUpcomingEvents);
            this.panelEventList.Controls.Add(this.listBoxEventsList);
            this.panelEventList.Location = new System.Drawing.Point(16, 484);
            this.panelEventList.Margin = new System.Windows.Forms.Padding(4);
            this.panelEventList.Name = "panelEventList";
            this.panelEventList.Size = new System.Drawing.Size(892, 181);
            this.panelEventList.TabIndex = 75;
            this.panelEventList.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1425, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelEventDetails);
            this.Controls.Add(this.menuStripFBFuncs);
            this.Controls.Add(this.panelEventList);
            this.MainMenuStrip = this.menuStripFBFuncs;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.menuStripFBFuncs.ResumeLayout(false);
            this.menuStripFBFuncs.PerformLayout();
            this.panelEventList.ResumeLayout(false);
            this.panelEventList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.ListBox listBoxEventsList;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.RichTextBox richTextBoxPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxWeatherIcon;
        private System.Windows.Forms.RichTextBox richTextBoxWeatheStats;
        private System.Windows.Forms.Panel panelEventDetails;
        private System.Windows.Forms.Label labelEventDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUpcomingEvents;
        private System.Windows.Forms.Label labelFriendsList;
        public RibbonStyle.RibbonMenuButton buttonPostStatus;
        public RibbonStyle.RibbonMenuButton buttonPicFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.MenuStrip menuStripFBFuncs;
        private System.Windows.Forms.ToolStripMenuItem FBFunctionsToolStripMenuItem;
        private System.Windows.Forms.Panel panelEventList;
    }
}
