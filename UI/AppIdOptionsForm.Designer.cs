namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class AppIdOptionsForm
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
            this.comboBoxAppId = new System.Windows.Forms.ComboBox();
            this.labelAppIdDescription = new System.Windows.Forms.Label();
            this.buttonLogin2 = new RibbonStyle.RibbonMenuButton();
            this.SuspendLayout();
            // 
            // comboBoxAppId
            // 
            this.comboBoxAppId.FormattingEnabled = true;
            this.comboBoxAppId.Items.AddRange(new object[] {
            "1450160541956417",
            "1688557107882768"});
            this.comboBoxAppId.Location = new System.Drawing.Point(15, 66);
            this.comboBoxAppId.Name = "comboBoxAppId";
            this.comboBoxAppId.Size = new System.Drawing.Size(166, 24);
            this.comboBoxAppId.TabIndex = 0;
            this.comboBoxAppId.Text = "1688557107882768";
            // 
            // labelAppIdDescription
            // 
            this.labelAppIdDescription.AutoSize = true;
            this.labelAppIdDescription.Location = new System.Drawing.Point(12, 22);
            this.labelAppIdDescription.Name = "labelAppIdDescription";
            this.labelAppIdDescription.Size = new System.Drawing.Size(120, 17);
            this.labelAppIdDescription.TabIndex = 1;
            this.labelAppIdDescription.Text = "Choose an AppId:";
            // 
            // buttonLogin2
            // 
            this.buttonLogin2.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.buttonLogin2.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin2.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.buttonLogin2.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.buttonLogin2.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.buttonLogin2.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.buttonLogin2.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogin2.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonLogin2.FadingSpeed = 0;
            this.buttonLogin2.FlatAppearance.BorderSize = 0;
            this.buttonLogin2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin2.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonLogin2.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.buttonLogin2.Image = global::A18_Ex03_Guy_203507926_Ben_302823927.Properties.Resources.if_key_login_71003;
            this.buttonLogin2.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Top;
            this.buttonLogin2.ImageOffset = 5;
            this.buttonLogin2.IsPressed = false;
            this.buttonLogin2.KeepPress = false;
            this.buttonLogin2.Location = new System.Drawing.Point(15, 112);
            this.buttonLogin2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin2.MaxImageSize = new System.Drawing.Point(38, 0);
            this.buttonLogin2.MenuPos = new System.Drawing.Point(0, 0);
            this.buttonLogin2.Name = "buttonLogin2";
            this.buttonLogin2.Radius = 8;
            this.buttonLogin2.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.buttonLogin2.Size = new System.Drawing.Size(166, 72);
            this.buttonLogin2.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.buttonLogin2.SplitDistance = 0;
            this.buttonLogin2.TabIndex = 72;
            this.buttonLogin2.TabStop = false;
            this.buttonLogin2.Text = "Login";
            this.buttonLogin2.Title = "";
            this.buttonLogin2.UseVisualStyleBackColor = true;
            this.buttonLogin2.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // AppIdOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(194, 197);
            this.Controls.Add(this.buttonLogin2);
            this.Controls.Add(this.labelAppIdDescription);
            this.Controls.Add(this.comboBoxAppId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppIdOptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppIdOptionsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.appIdOptionsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAppId;
        private System.Windows.Forms.Label labelAppIdDescription;
        public RibbonStyle.RibbonMenuButton buttonLogin2;
    }
}