using System;
using System.Windows.Forms;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class TSItemCommand : ToolStripMenuItem
    {        
        public Action Command { get; set; }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Command.Invoke();
        }
    }
}
