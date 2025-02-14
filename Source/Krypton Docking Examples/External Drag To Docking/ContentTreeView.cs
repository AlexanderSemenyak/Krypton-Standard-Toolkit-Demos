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

using Krypton.Docking;
using Krypton.Navigator;

namespace ExternalDragToDocking
{
    public partial class ContentTreeView : UserControl
    {
        public ContentTreeView(Form1 form1)
        {
            InitializeComponent();
            treeView1.Form1 = form1;
        }
    }

    public class DraggableTreeView : TreeView
    {
        private bool _dragging;
        private TreeNode _dragNode;
        private Rectangle _dragRect;
        private Form1 _form1;

        public Form1 Form1
        {
            get { return _form1; }
            set { _form1 = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Find the tree node under the mouse point
            Point pt = new Point(e.X, e.Y);
            TreeNode nodeDown = GetNodeAt(pt);

            // If there is a node under the mouse
            if (nodeDown != null)
            {
                // Ensure the node is selected
                if (SelectedNode != nodeDown)
                {
                    SelectedNode = nodeDown;
                }

                // Left mouse down means we might be starting a drag operation
                if (e.Button == MouseButtons.Left)
                {
                    _dragNode = nodeDown;
                    _dragRect = new Rectangle(pt, Size.Empty);
                    _dragRect.Inflate(SystemInformation.DragSize);
                }
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _dragNode = null;
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);

            // Do we need to check for a drag operation?
            if ((_dragNode != null) && !_dragging)
            {
                KryptonPage dragPage = null;

                // Create the correct type of krypton page for the selected node
                switch(_dragNode.Name)
                {
                    case "Document":
                        dragPage = Form1.NewDocument();
                        break;
                    case "Property Grid":
                        dragPage = Form1.NewPropertyGrid();
                        break;
                    case "Input Form":
                        dragPage = Form1.NewInput();
                        break;
                }

                // If we managed to create a page for dragging...
                if (dragPage != null)
                {
                    _dragging = true;

                    // Add a floating window to the docking manager which contains the new drag page
                    KryptonDockingFloatingWindow fw = Form1.DockingManager.AddFloatingWindow("Floating", 
                                                                                             new KryptonPage[] { dragPage }, 
                                                                                             new Point(MousePosition.X - pt.X, MousePosition.Y - pt.Y));

                    // DoEvents spins the message loop so that the window gets fully created and shown
                    Application.DoEvents();

                    // We want to know when the drag drop operating is finished
                    Form1.DockingManager.DoDragDropEnd += kryptonDockingManager_DoDragDropFinished;
                    Form1.DockingManager.DoDragDropQuit += kryptonDockingManager_DoDragDropFinished;

                    // Drag the new floating window around
                    Form1.DockingManager.DoDragDrop(MousePosition, pt, dragPage, fw);
                }
            }

            base.OnMouseMove(e);
        }

        private void kryptonDockingManager_DoDragDropFinished(object sender, EventArgs e)
        {
            // Remember to unhook from no longer needed events
            Form1.DockingManager.DoDragDropEnd -= kryptonDockingManager_DoDragDropFinished;
            Form1.DockingManager.DoDragDropQuit -= kryptonDockingManager_DoDragDropFinished;

            // Drag has finished so set drag node back to null
            _dragNode = null;
            _dragging = false;
        }
    }
}
