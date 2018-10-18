namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class FilterOptionsForm
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
            this.radioButtonByTaggedFriends = new System.Windows.Forms.RadioButton();
            this.radioButtonByLocation = new System.Windows.Forms.RadioButton();
            this.textBoxFilterVal = new System.Windows.Forms.TextBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.buttonPostStatus = new RibbonStyle.RibbonMenuButton();
            this.SuspendLayout();
            // 
            // radioButtonByTaggedFriends
            // 
            this.radioButtonByTaggedFriends.AutoSize = true;
            this.radioButtonByTaggedFriends.Location = new System.Drawing.Point(206, 101);
            this.radioButtonByTaggedFriends.Name = "radioButtonByTaggedFriends";
            this.radioButtonByTaggedFriends.Size = new System.Drawing.Size(149, 21);
            this.radioButtonByTaggedFriends.TabIndex = 2;
            this.radioButtonByTaggedFriends.TabStop = true;
            this.radioButtonByTaggedFriends.Text = "By Tagged Friends";
            this.radioButtonByTaggedFriends.UseVisualStyleBackColor = true;
            // 
            // radioButtonByLocation
            // 
            this.radioButtonByLocation.AutoSize = true;
            this.radioButtonByLocation.Location = new System.Drawing.Point(60, 101);
            this.radioButtonByLocation.Name = "radioButtonByLocation";
            this.radioButtonByLocation.Size = new System.Drawing.Size(107, 21);
            this.radioButtonByLocation.TabIndex = 3;
            this.radioButtonByLocation.TabStop = true;
            this.radioButtonByLocation.Text = "By Location:";
            this.radioButtonByLocation.UseVisualStyleBackColor = true;
            // 
            // textBoxFilterVal
            // 
            this.textBoxFilterVal.Location = new System.Drawing.Point(60, 142);
            this.textBoxFilterVal.Name = "textBoxFilterVal";
            this.textBoxFilterVal.Size = new System.Drawing.Size(295, 22);
            this.textBoxFilterVal.TabIndex = 4;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(57, 47);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(281, 17);
            this.labelInstruction.TabIndex = 5;
            this.labelInstruction.Text = "Please choose one of the following options:";
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
            this.buttonPostStatus.Image = global::A18_Ex03_Guy_203507926_Ben_302823927.Properties.Resources.scanIcon;
            this.buttonPostStatus.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonPostStatus.ImageOffset = 5;
            this.buttonPostStatus.IsPressed = false;
            this.buttonPostStatus.KeepPress = false;
            this.buttonPostStatus.Location = new System.Drawing.Point(94, 192);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonPostStatus.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Radius = 8;
            this.buttonPostStatus.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonPostStatus.Size = new System.Drawing.Size(211, 82);
            this.buttonPostStatus.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonPostStatus.SplitDistance = 0;
            this.buttonPostStatus.TabIndex = 73;
            this.buttonPostStatus.TabStop = false;
            this.buttonPostStatus.Text = "Scan";
            this.buttonPostStatus.Title = "";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonStartFilter_Click);
            // 
            // FilterOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(412, 340);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.textBoxFilterVal);
            this.Controls.Add(this.radioButtonByLocation);
            this.Controls.Add(this.radioButtonByTaggedFriends);
            this.Name = "FilterOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartPicFilter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterOptionsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonByTaggedFriends;
        private System.Windows.Forms.RadioButton radioButtonByLocation;
        private System.Windows.Forms.TextBox textBoxFilterVal;
        private System.Windows.Forms.Label labelInstruction;
        public RibbonStyle.RibbonMenuButton buttonPostStatus;
    }
}