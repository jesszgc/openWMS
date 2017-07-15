using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace open.winform.ui
{
   public  class maindock
    {
        public static DockPanel dp = null;
        public static void ShowForm(OpenForm of)
        {
            if (null != dp)
            {
                of.Show(dp);
            }
        }
    }
}
