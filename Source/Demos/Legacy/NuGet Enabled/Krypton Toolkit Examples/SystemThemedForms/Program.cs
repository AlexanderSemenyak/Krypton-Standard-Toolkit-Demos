﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2020, All rights reserved.
//  By Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2021. All rights reserved. (https://github.com/Krypton-Suite/Standard-Toolkit)
//  Version 5.550.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;

namespace SystemThemedForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
