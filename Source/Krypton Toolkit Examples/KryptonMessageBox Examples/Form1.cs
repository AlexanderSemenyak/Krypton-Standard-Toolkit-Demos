// *****************************************************************************
// 
//  © Component Factory Pty Ltd, 2006 - 2016. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace KryptonMessageBoxExamples
{
    public partial class Form1 : Form
    {
        private KryptonMessageBoxIcon _mbIcon = KryptonMessageBoxIcon.WARNING;
        private MessageBoxButtons _mbButtons = MessageBoxButtons.OKCancel;

        public Form1()
        {
            InitializeComponent();
        }

        private void palette_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOffice2010Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            }
            else if (radioButtonOffice2010Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Silver;
            }
            else if (radioButtonOffice2010Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Black;
            }
            else if (radioButtonOffice2007Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
            else if (radioButtonOffice2007Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;
            }
            else if (radioButtonOffice2007Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Black;
            }
            else if (radioButtonSparkleBlue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            }
            else if (radioButtonSparkleOrange.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
            else if (radioButtonSparklePurple.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;
            }
            else if (radioButtonOffice2003.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;
            }
            else if (radioButtonSystem.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;
            }
            else if (radioButtonOffice365Black.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365Black;
            }
            else if (radioButtonOffice365Blue.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365Blue;
            }
            else if (radioButtonOffice365Silver.Checked)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office365Silver;
            }
        }

        private void icon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.NONE;
            }
            else if (radioButtonError.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.ERROR;
            }
            else if (radioButtonQuestion.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.QUESTION;
            }
            else if (radioButtonWarning.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.WARNING;
            }
            else if (radioButtonInformation.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.INFORMATION;
            }
            else if (rbShield.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.SHIELD;
            }
            else if (rbWindowsLogo.Checked)
            {
                _mbIcon = KryptonMessageBoxIcon.WINDOWSLOGO;
            }
        }

        private void buttons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOK.Checked)
            {
                _mbButtons = MessageBoxButtons.OK;
            }
            else if (radioButtonOKCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.OKCancel;
            }
            else if (radioButtonRetryCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.RetryCancel;
            }
            else if (radioButtonAbortRetryIgnore.Checked)
            {
                _mbButtons = MessageBoxButtons.AbortRetryIgnore;
            }
            else if (radioButtonYesNo.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNo;
            }
            else if (radioButtonYesNoCancel.Checked)
            {
                _mbButtons = MessageBoxButtons.YesNoCancel;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(textBoxMessage.Text, textBoxCaption.Text, _mbButtons, _mbIcon);
        }
    }
}
