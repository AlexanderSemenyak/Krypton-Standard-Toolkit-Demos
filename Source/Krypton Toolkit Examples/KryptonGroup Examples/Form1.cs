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
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using Krypton.Toolkit;

namespace KryptonGroupExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this group
            propertyGrid.SelectedObject = new KryptonGroupProxy(group1Office);

        private void group_MouseDown(object sender, MouseEventArgs e) =>
            // Setup the property grid to edit this group
            propertyGrid.SelectedObject = new KryptonGroupProxy(sender as KryptonGroup);

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;

            // Setup the property grid to edit this panel parent group
            propertyGrid.SelectedObject = new KryptonGroupProxy(c.Parent as KryptonGroup);
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonGroupProxy
    {
        private KryptonGroup _group;

        public KryptonGroupProxy(KryptonGroup group) => _group = group;

        [Category("Visuals")]
        [Description("Border style.")]
        [DefaultValue(typeof(PaletteBorderStyle), "Control - Client")]
        public PaletteBorderStyle GroupBorderStyle
        {
            get => _group.GroupBorderStyle;
            set => _group.GroupBorderStyle = value;
        }

        [Category("Visuals")]
        [Description("Background style.")]
        [DefaultValue(typeof(PaletteBackStyle), "Control - Client")]
        public PaletteBackStyle GroupBackStyle
        {
            get => _group.GroupBackStyle;
            set => _group.GroupBackStyle = value;
        }

        [Category("Visuals")]
        [Description("Overrides for defining common group appearance that other states can override.")]
        public PaletteDoubleRedirect StateCommon => _group.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled group appearance.")]
        public PaletteDouble StateDisabled => _group.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal group appearance.")]
        public PaletteDouble StateNormal => _group.StateNormal;

        [Category("Visuals")]
        [Description("Palette applied to drawing.")]
        [DefaultValue(typeof(PaletteMode), "Global")]
        public PaletteMode PaletteMode
        {
            get => _group.PaletteMode;
            set => _group.PaletteMode = value;
        }

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _group.Size;
            set => _group.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _group.Location;
            set => _group.Location = value;
        }
    }
}
