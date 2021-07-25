﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
//  Version 4.5.0.0  www.ComponentFactory.com
//
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
// 
 
// *****************************************************************************

using System;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace CustomControlUsingPalettes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kryptonCheckSet_CheckedButtonChanged(object sender, EventArgs e)
        {
            // Switch to using a different global palette
            switch (kryptonCheckSet.CheckedIndex)
            {
                case 0:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
                    break;
                case 1:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
                    break;
                case 2:
                    kryptonManager.GlobalPalette = kryptonPaletteCustom;
                    break;
                case 3:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
                    break;
                case 4:
                    kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
                    break;
            }
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the enabled state of the custom control instance
            myUserControl1.Enabled = !myUserControl1.Enabled;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
