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
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using Krypton.Toolkit;
using Krypton.Navigator;

namespace NavigatorContextMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonNavigator1_ShowContextMenu(object sender, ShowContextMenuArgs e)
        {
            // Yes we want to show a context menu
            e.Cancel = false;

            // Provide the navigator specific menu
            e.KryptonContextMenu = kcmNavigator;

            // Only enable the appropriate options
            kcmFirst.Enabled = (kryptonNavigator1.SelectedIndex > 0);
            kcmPrevious.Enabled = (kryptonNavigator1.SelectedIndex > 0);
            kcmNext.Enabled = (kryptonNavigator1.SelectedIndex < (kryptonNavigator1.Pages.Count - 1));
            kcmLast.Enabled = (kryptonNavigator1.SelectedIndex < (kryptonNavigator1.Pages.Count - 1));
        }

        private void kcmFirst_Click(object sender, EventArgs e)
        {
            // Move the selected page to the start of the page list
            KryptonPage kp = kryptonNavigator1.SelectedPage;
            kryptonNavigator1.Pages.Remove(kp);
            kryptonNavigator1.Pages.Insert(0, kp);
            kryptonNavigator1.SelectedPage = kp;
        }

        private void kcmPrevious_Click(object sender, EventArgs e)
        {
            // Move the selected page to the previous place in the page list
            KryptonPage kp = kryptonNavigator1.SelectedPage;
            int index = kryptonNavigator1.SelectedIndex;
            kryptonNavigator1.Pages.Remove(kp);
            kryptonNavigator1.Pages.Insert(index - 1, kp);
            kryptonNavigator1.SelectedPage = kp;
        }

        private void kcmNext_Click(object sender, EventArgs e)
        {
            // Move the selected page to the next place in the list
            KryptonPage kp = kryptonNavigator1.SelectedPage;
            int index = kryptonNavigator1.SelectedIndex;
            kryptonNavigator1.Pages.Remove(kp);
            kryptonNavigator1.Pages.Insert(index + 1, kp);
            kryptonNavigator1.SelectedPage = kp;
        }

        private void kcmLast_Click(object sender, EventArgs e)
        {
            // Move the selected page to the end of the page list
            KryptonPage kp = kryptonNavigator1.SelectedPage;
            int index = kryptonNavigator1.SelectedIndex;
            kryptonNavigator1.Pages.Remove(kp);
            kryptonNavigator1.Pages.Add(kp);
            kryptonNavigator1.SelectedPage = kp;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
