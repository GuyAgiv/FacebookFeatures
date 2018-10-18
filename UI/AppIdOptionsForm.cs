using System.Windows.Forms;
using System;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public partial class AppIdOptionsForm : Form
    {
        public string AppId { get; set; }

        public AppIdOptionsForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            AppId = comboBoxAppId.Text;
            Hide();
        }

        private void appIdOptionsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}