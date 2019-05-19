using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Israel Torres
 * Class: Visual Frameworks - Online (MDV1830-O)
 * Term: C201905 01
 * Code Exercise: Custom Event Arguments
 * Number: CE05
 */

namespace IsraelTorres_CE05
{
    public partial class ListViewForm : Form
    {
        UserInputDialog userInputDialog;

        public EventHandler PopulateDataUserInput;

        public EventHandler ApplyBtnVisible;

        public EventHandler<ModifyObjectEventArgs> ModifyObject;

        public Spaceship ClickedObject
        {

            get
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    return listView1.SelectedItems[0].Tag as Spaceship;
                }
                else
                {
                    return new Spaceship();
                }
            }
        }

        public ListViewForm()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            toolStripStatusItemCount.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userInputDialog = new UserInputDialog();

            userInputDialog.ObjectAdded += ObjectAddedHandler;

            userInputDialog.NumberOfItems += NumberOfItemsHandler;

            PopulateDataUserInput += userInputDialog.PopulateDataUserInputHandler;

            ApplyBtnVisible += userInputDialog.ApplyBtnVisibleHandler;

            ModifyObject += userInputDialog.HandleModifyObject;

            userInputDialog.ObjectModified += ObjectModifiedHandler;



            userInputDialog.Show();
        }

        public void ObjectAddedHandler(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            Spaceship s = (sender as UserInputDialog).Data;

            lvi.Text = s.ToString();
            lvi.ImageIndex = s.ImageIndex;
            lvi.Tag = s;

            listView1.Items.Add(lvi);
        }

        public void ObjectModifiedHandler(object sender, EventArgs e)
        {
            if (ModifyObject != null && listView1.SelectedItems.Count > 0)
            {
                ModifyObject(this, new ModifyObjectEventArgs(listView1.SelectedItems[0]));
            }
        }

        public void NumberOfItemsHandler(object sender, EventArgs e)
        {
            userInputDialog = sender as UserInputDialog;

            int count = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                count++;
            }

            toolStripStatusItemCount.Text = count.ToString();
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

            largeToolStripMenuItem.Checked = true;
            smallToolStripMenuItem.Checked = false;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

            smallToolStripMenuItem.Checked = true;
            largeToolStripMenuItem.Checked = false;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            newToolStripMenuItem_Click(this, new EventArgs());

            if (PopulateDataUserInput != null)
            {
                PopulateDataUserInput(this, new EventArgs());
            }

            if(ApplyBtnVisible != null)
            {
                ApplyBtnVisible(this, new EventArgs());
            }
        }

        public class ModifyObjectEventArgs: EventArgs
        {
            ListViewItem ObjectToModify;

            public ListViewItem ObjectToModify1
            {
                get
                {
                    return ObjectToModify;
                }

                set
                {
                    ObjectToModify = value;
                }
            }

            public ModifyObjectEventArgs(ListViewItem lvi)
            {
                ObjectToModify = lvi;
            }
        }
    }
}
