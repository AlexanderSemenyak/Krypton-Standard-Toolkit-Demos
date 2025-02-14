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

namespace KryptonNumericUpDownExamples
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e) =>
            // Setup the property grid to edit this numeric up-down control
            propertyGrid.SelectedObject = new KryptonNumericUpDownProxy(nud1);

        private void nud_Enter(object sender, EventArgs e) =>
            // Setup the property grid to edit this numeric up-down control
            propertyGrid.SelectedObject = new KryptonNumericUpDownProxy(sender as KryptonNumericUpDown);

        private void buttonOffice2010Blue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2010Blue;

        private void buttonOffice2007Blue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteModeManager.Office2007Blue;

        private void buttonSystem_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteModeManager.ProfessionalSystem;

        private void buttonSparkleBlue_Click(object sender, EventArgs e) => kryptonManager1.GlobalPaletteMode = PaletteModeManager.SparkleBlue;

        private void buttonSpecAny1_Click(object sender, EventArgs e) => nud5.Value = nud5.Minimum;

        private void buttonSpecAny2_Click(object sender, EventArgs e) => nud6.Value = nud6.Minimum;

        private void buttonSpecAny6_Click(object sender, EventArgs e) => nud11.Value = nud11.Minimum;

        private void buttonSpecAny4_Click(object sender, EventArgs e) => nud12.Value = nud12.Minimum;

        private void kryptonContextMenuItem1_Click(object sender, EventArgs e)
        {
            nud6.Value = 10m;
            nud12.Value = 10m;
        }

        private void kryptonContextMenuItem2_Click(object sender, EventArgs e)
        {
            nud6.Value = 20m;
            nud12.Value = 20m;
        }

        private void kryptonContextMenuItem3_Click(object sender, EventArgs e)
        {
            nud6.Value = 40m;
            nud12.Value = 40m;
        }

        private void kryptonContextMenuItem4_Click(object sender, EventArgs e)
        {
            nud6.Value = nud6.Minimum;
            nud12.Value = nud12.Minimum;
        }

        private void kryptonContextMenuItem5_Click(object sender, EventArgs e)
        {
            nud6.Value = nud6.Maximum;
            nud12.Value = nud12.Maximum;
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }

    public class KryptonNumericUpDownProxy
    {
        private KryptonNumericUpDown _numericUpDown;

        public KryptonNumericUpDownProxy(KryptonNumericUpDown numericUpDown) => _numericUpDown = numericUpDown;

        [Category("Visuals")]
        [Description("Determines if the control is always active or only when the mouse is over the control or has focus.")]
        public bool AlwaysActive
        {
            get => _numericUpDown.AlwaysActive;
            set => _numericUpDown.AlwaysActive = value;
        }

        [Category("Appearance")]
        [Description("Indicates how the text should be aligned for edit controls.")]
        public HorizontalAlignment TextAlign
        {
            get => _numericUpDown.TextAlign;
            set => _numericUpDown.TextAlign = value;
        }


        [Category("Behavior")]
        [Description("Controls whether the text in the edit control can be changed or not.")]
        public bool ReadOnly
        {
            get => _numericUpDown.ReadOnly;
            set => _numericUpDown.ReadOnly = value;
        }

        [Category("Visuals")]
        [Description("Input control style.")]
        public InputControlStyle InputControlStyle
        {
            get => _numericUpDown.InputControlStyle;
            set => _numericUpDown.InputControlStyle = value;
        }

        [Category("Visuals")]
        [Description("Should tooltips be displayed for button specs.")]
        public bool AllowButtonSpecToolTips
        {
            get => _numericUpDown.AllowButtonSpecToolTips;
            set => _numericUpDown.AllowButtonSpecToolTips = value;
        }

        [Category("Visuals")]
        [Description("Collection of button specifications.")]
        public KryptonNumericUpDown.NumericUpDownButtonSpecCollection ButtonSpecs => _numericUpDown.ButtonSpecs;

        [Category("Visuals")]
        [Description("Overrides for defining common textbox appearance that other states can override.")]
        public PaletteInputControlTripleRedirect StateCommon => _numericUpDown.StateCommon;

        [Category("Visuals")]
        [Description("Overrides for defining disabled textbox appearance.")]
        public PaletteInputControlTripleStates StateDisabled => _numericUpDown.StateDisabled;

        [Category("Visuals")]
        [Description("Overrides for defining normal textbox appearance.")]
        public PaletteInputControlTripleStates StateNormal => _numericUpDown.StateNormal;

        [Category("Visuals")]
        [Description("Overrides for defining active textbox appearance.")]
        public PaletteInputControlTripleStates StateActive => _numericUpDown.StateActive;

        [Category("Layout")]
        [Description("The size of the control is pixels.")]
        public Size Size
        {
            get => _numericUpDown.Size;
            set => _numericUpDown.Size = value;
        }

        [Category("Layout")]
        [Description("The location of the control in pixels.")]
        public Point Location
        {
            get => _numericUpDown.Location;
            set => _numericUpDown.Location = value;
        }

        /// <summary>
        /// Gets or sets the number of decimal places to display.
        /// </summary>
        [Category("Data")]
        [Description("Indicates the number of decimal places to display.")]
        public int DecimalPlaces
        {
            get => _numericUpDown.DecimalPlaces;
            set => _numericUpDown.DecimalPlaces = value;
        }

        /// <summary>
        /// Gets or sets the amount to increment or decrement one each button click.
        /// </summary>
        [Category("Data")]
        [Description("Indicates the amount to increment or decrement one each button click.")]
        public decimal Increment
        {
            get => _numericUpDown.Increment;
            set => _numericUpDown.Increment = value;
        }

        /// <summary>
        /// Gets or sets the maximum value for the numeric up-down control.
        /// </summary>
        [Category("Data")]
        [Description("Indicates the maximum value for the numeric up-down control.")]
        [RefreshProperties(RefreshProperties.All)]
        public decimal Maximum
        {
            get => _numericUpDown.Maximum;
            set => _numericUpDown.Maximum = value;
        }

        /// <summary>
        /// Gets or sets the minimum value for the numeric up-down control.
        /// </summary>
        [Category("Data")]
        [Description("Indicates the minimum value for the numeric up-down control.")]
        [RefreshProperties(RefreshProperties.All)]
        public decimal Minimum
        {
            get => _numericUpDown.Minimum;
            set => _numericUpDown.Minimum = value;
        }

        /// <summary>
        /// Gets or sets whether the thousands separator wil be inserted between each three decimal digits.
        /// </summary>
        [Category("Data")]
        [Description("Indicates whether the thousands separator wil be inserted between each three decimal digits.")]
        public bool ThousandsSeparator
        {
            get => _numericUpDown.ThousandsSeparator;
            set => _numericUpDown.ThousandsSeparator = value;
        }

        /// <summary>
        /// Gets or sets the current value of the numeric up-down control.
        /// </summary>
        [Category("Appearance")]
        [Description("The current value of the numeric up-down control.")]
        public decimal Value
        {
            get => _numericUpDown.Value;
            set => _numericUpDown.Value = value;
        }

        /// <summary>
        /// Gets or sets whether the numeric up-down should display its value in hexadecimal.
        /// </summary>
        [Category("Appearance")]
        [Description("Indicates wheather the numeric up-down should display its value in hexadecimal.")]
        public bool Hexadecimal
        {
            get => _numericUpDown.Hexadecimal;
            set => _numericUpDown.Hexadecimal = value;
        }

        /// <summary>
        /// Gets or sets whether the control accepts decimal values.
        /// </summary>
        [Category("Behavior")]
        [Description("Indicates whether the control can accept decimal values, rather than integer values only.")]
        public bool AllowDecimals
        {
            get => _numericUpDown.AllowDecimals;
            set => _numericUpDown.AllowDecimals = value;
        }

        /// <summary>
        /// Gets or sets whether the control displays trailing zeroes.
        /// </summary>
        [Category("Behavior")]
        [Description("Indicates whether the control will display traling zeroes.")]
        public bool TrailingZeroes
        {
            get => _numericUpDown.TrailingZeroes;
            set => _numericUpDown.TrailingZeroes = value;
        }


        /// <summary>
        /// Gets or sets how the up-down control will position the up down buttons relative to its text box.
        /// </summary>
        [Category("Appearance")]
        [Description("Indicates how the up-down control will position the up down buttons relative to its text box.")]
        public LeftRightAlignment UpDownAlign
        {
            get => _numericUpDown.UpDownAlign;
            set => _numericUpDown.UpDownAlign = value;
        }

        /// <summary>
        /// Gets or sets whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.
        /// </summary>
        [Category("Behavior")]
        [Description("Indicates whether the up-down control will increment and decrement the value when the UP ARROW and DOWN ARROW are used.")]
        public bool InterceptArrowKeys
        {
            get => _numericUpDown.InterceptArrowKeys;
            set => _numericUpDown.InterceptArrowKeys = value;
        }

        /// <summary>
        /// Gets and sets the up and down buttons style.
        /// </summary>
        [Category("Visuals")]
        [Description("Up and down buttons style.")]
        public ButtonStyle UpDownButtonStyle
        {
            get => _numericUpDown.UpDownButtonStyle;
            set => _numericUpDown.UpDownButtonStyle = value;
        }
    }
}
