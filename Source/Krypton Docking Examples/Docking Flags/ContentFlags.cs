﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion
using System;
using System.Windows.Forms;

using Krypton.Navigator;

namespace DockingFlags
{
    public partial class ContentFlags : UserControl
    {
        private KryptonPage _page;

        public ContentFlags()
            : this(null)
        {
        }

        public ContentFlags(KryptonPage page)
        {
            _page = page;
            InitializeComponent();
        }

        private void kryptonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Only interested in left mouse down
            if (e.Button == MouseButtons.Left)
            {
                // If the content does not have the focus then give it focus now
                if (!ContainsFocus)
                {
                    kryptonPanel.SelectNextControl(this, true, true, true, false);
                }
            }
        }

        private void ContentFlags_Load(object sender, EventArgs e)
        {
            // Set checkbox controls to reflect current page flag settings
            cbDocked.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowDocked);
            cbAutoHidden.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowAutoHidden);
            cbFloating.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowFloating);
            cbWorkspace.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowWorkspace);
            cbNavigator.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowNavigator);
            cbDropDown.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowDropDown);
            cbClose.Checked = _page.AreFlagsSet(KryptonPageFlags.DockingAllowClose);
        }

        private void cbDocked_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDocked.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowDocked);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowDocked);
            }
        }

        private void cbAutoHidden_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoHidden.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowAutoHidden);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowAutoHidden);
            }
        }

        private void cbFloating_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFloating.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowFloating);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowFloating);
            }
        }

        private void cbWorkspace_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWorkspace.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowWorkspace);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowWorkspace);
            }
        }

        private void cbNavigator_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNavigator.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowNavigator);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowNavigator);
            }
        }

        private void cbDropDown_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDropDown.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowDropDown);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowDropDown);
            }
        }

        private void cbClose_CheckedChanged(object sender, EventArgs e)
        {
            if (cbClose.Checked)
            {
                _page.SetFlags(KryptonPageFlags.DockingAllowClose);
            }
            else
            {
                _page.ClearFlags(KryptonPageFlags.DockingAllowClose);
            }
        }
    }
}
