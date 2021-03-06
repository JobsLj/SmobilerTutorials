﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSwitch : Smobiler.Core.Controls.MobileForm
    {
        public demoSwitch()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switch7_CheckedChanged(object sender, EventArgs e)
        {
            Toast(switch7.Checked.ToString());
        }
    }
}