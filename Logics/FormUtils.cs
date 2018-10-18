using System.Windows.Forms;
using System.Drawing;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public static class FormUtils
    {
        public static void UpdateFormBackground(PictureBox i_PictureBox, Image i_BackgroundImage, ImageLayout i_Layout)
        {
            i_BackgroundImage = i_PictureBox.Image;
            i_Layout = ImageLayout.Stretch;
        }
    }
}
