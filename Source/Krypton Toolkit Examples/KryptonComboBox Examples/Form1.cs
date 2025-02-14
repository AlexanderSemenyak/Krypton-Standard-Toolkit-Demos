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

namespace KryptonComboBoxExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this combo box
            propertyGrid.SelectedObject = new KryptonComboBoxProxy(kryptonComboBox1Blue);

        private void kryptonComboBox1Blue_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this combo box
            propertyGrid.SelectedObject = new KryptonComboBoxProxy(sender as KryptonComboBox);

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            kryptonComboBox2Blue.Text = string.Empty;
            kryptonComboBox2Blue.ComboBox.Focus();
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            kryptonComboBox5System.Text = string.Empty;
            kryptonComboBox5System.ComboBox.Focus();
        }

        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            if (kryptonComboBox8Custom.SelectedIndex > 0)
            {
                kryptonComboBox8Custom.SelectedIndex -= 1;
                kryptonComboBox8Custom.ComboBox.Focus();
            }
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            if (kryptonComboBox8Custom.SelectedIndex < (kryptonComboBox8Custom.Items.Count - 1))
            {
                kryptonComboBox8Custom.SelectedIndex += 1;
                kryptonComboBox8Custom.ComboBox.Focus();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonComboBoxProxy
    {
        private KryptonComboBox _comboBox;

        public KryptonComboBoxProxy(KryptonComboBox comboBox) => _comboBox = comboBox;

        [Category("Appearance")]
        [Description("Text for display inside the control.")]
        public string Text
        {
            get => _comboBox.Text;
            set => _comboBox.Text = value;
        }

        [Category("Visuals")]
        [Description("Determines if the control is always active or only when the mouse is over the control or has focus.")]
        public bool AlwaysActive
        {
            get => _comboBox.AlwaysActive;
            set => _comboBox.AlwaysActive = value;
        }

        [Category("Appearance")]
        [Description("Controls the appearance and functionality of the KryptonComboBox.")]
        public ComboBoxStyle DropDownStyle
        {
            get => _comboBox.DropDownStyle;
            set => _comboBox.DropDownStyle = value;
        }

        [Category("Behavior")]
        [Description("The height, in pixels, of the drop down box in a KryptonComboBox.")]
        public int DropDownHeight
        {
            get => _comboBox.DropDownHeight;
            set => _comboBox.DropDownHeight = value;
        }

        [Category("Behavior")]
        [Description("The width, in pixels, of the drop down box in a KryptonComboBox.")]
        public int DropDownWidth
        {
            get => _comboBox.DropDownWidth;
            set => _comboBox.DropDownWidth = value;
        }

        [Category("Behavior")]
        [Description("The height, in pixels, of items in an owner-draw KryptomComboBox.")]
        public int ItemHeight
        {
            get => _comboBox.ItemHeight;
            set => _comboBox.ItemHeight = value;
        }

        [Category("Behavior")]
        [Description("The maximum number of entries to display in the drop-down list.")]
        public int MaxDropDownItems
        {
            get => _comboBox.MaxDropDownItems;
            set => _comboBox.MaxDropDownItems = value;
        }

        [Category("Behavior")]
        [Description("Specifies the maximum number of characters that can be entered into the edit control.")]
        public int MaxLength
        {
            get => _comboBox.MaxLength;
            set => _comboBox.MaxLength = value;
        }

        [Category("Behavior")]
        [Description("Specifies whether the items in the list portion of the KryptonComboBox are sorted.")]
        public bool Sorted
        {
            get => _comboBox.Sorted;
            set => _comboBox.Sorted = value;
        }

        [Category("Data")]
        [Description("The items in the KryptonComboBox.")]
        public ComboBox.ObjectCollection Items => _comboBox.Items;

        [Category("Visuals")]
        [Description("Input control style.")]
        public InputControlStyle InputControlStyle
        {
            get => _comboBox.InputControlStyle;
            set => _comboBox.InputControlStyle = value;
        }

        [Category("Visuals")]
        [Description("DropButton style.")]
        public ButtonStyle DropButtonStyle
        {
            get => _comboBox.DropButtonStyle;
            set => _comboBox.DropButtonStyle = value;
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        public bool AllowButtonSpecToolTips
        {
            get => _comboBox.AllowButtonSpecToolTips;
            set => _comboBox.AllowButtonSpecToolTips = value;
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonComboBox.ComboBoxButtonSpecCollection ButtonSpecs => _comboBox.ButtonSpecs;

        [Category("Visuals")]
        [Description("Overrides for defining common combobox appearance that other states can override.")]
        public PaletteComboBoxRedirect StateCommon => _comboBox.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled combobox appearance.")]
        public PaletteComboBoxStates StateDisabled => _comboBox.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal combobox appearance.")]
        public PaletteComboBoxStates StateNormal => _comboBox.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining active combobox appearance.")]
        public PaletteComboBoxJustComboStates StateActive => _comboBox.StateActive;

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _comboBox.Size;
            set => _comboBox.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _comboBox.Location;
            set => _comboBox.Location = value;
        }
    }
}
