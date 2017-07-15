using open.winform.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Winform_app
{
    public partial class MainWindow :Form

    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void toolboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolbox tb = new Winform_app.toolbox();
            
           
        }
    }
}
