using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace open.winform.ui
{
    public class OpenForm: DockContent
    {
        MainPanel mp = null;
        public void ShowForm()
        {
            mp = (MainPanel)this.ParentForm;
            this.Show(mp.dp);

            this.DockTo(mp.dp, DockStyle.Left);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OpenForm
            // 
            this.ClientSize = new System.Drawing.Size(503, 464);
            this.Name = "OpenForm";
            this.ResumeLayout(false);

        }
    }
}
