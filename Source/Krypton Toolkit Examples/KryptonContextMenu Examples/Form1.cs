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

using Krypton.Toolkit;

namespace KryptonContextMenuExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxH.SelectedIndex = 2;
            comboBoxV.SelectedIndex = 1;
        }

        private void radio2010Blue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;

        private void radioBlue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;

        private void radioSilver_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Silver;

        private void radioOffice2003_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalOffice2003;

        private void radioSystem_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;

        private void radioSparklePurple_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.SparklePurple;

        private void radioSparkleOrange_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;

        private void radioSparkleBlue_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;

        private void radioCustom_CheckedChanged(object sender, EventArgs e) => kryptonManager.GlobalPalette = kryptonPalette1;

        private void buttonShowHeadingsClick(object sender, EventArgs e) => ShowMenu(buttonShowHeadings, kcmHeadings);

        private void buttonShowSeparatorsClick(object sender, EventArgs e) => ShowMenu(buttonShowSeparators, kcmSeparators);

        private void buttonShowAlternateStyleClick(object sender, EventArgs e) => ShowMenu(buttonShowAlternateStyle, kcmAlternateStyle);

        private void buttonSubMenusClick(object sender, EventArgs e) => ShowMenu(buttonSubMenus, kcmSubMenus);

        private void buttonControls_Click(object sender, EventArgs e) => ShowMenu(buttonControls, kcmControls);

        private void buttonColors_Click(object sender, EventArgs e) => ShowMenu(buttonColors, kcmColors);

        private void buttonImageSelectClick(object sender, EventArgs e) => ShowMenu(buttonImageSelect, kcmImageSelect);

        private void buttonCalendar_Click(object sender, EventArgs e) => ShowMenu(buttonCalendar, kcmCalendar);

        private void buttonShowEverythingClick(object sender, EventArgs e) => ShowMenu(buttonImageSelect, kcmEverything);

        private void ShowMenu(Control c, KryptonContextMenu kcm) =>
            kcm.Show(c.RectangleToScreen(c.ClientRectangle),
                (KryptonContextMenuPositionH)Enum.Parse(typeof(KryptonContextMenuPositionH), (string)comboBoxH.SelectedItem),
                (KryptonContextMenuPositionV)Enum.Parse(typeof(KryptonContextMenuPositionV), (string)comboBoxV.SelectedItem));
    }
}
