﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace open.winform.ui
{
    public partial class MainPanel : Form
    {
        public DockPanel dp = new DockPanel();
        public MainPanel()
        {
            InitializeComponent();
        }
    }
}