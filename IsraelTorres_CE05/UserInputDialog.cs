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
    public partial class UserInputDialog : Form
    {
        ListViewForm lvf;

        public EventHandler ObjectAdded;
        public EventHandler NumberOfItems;
        public EventHandler ObjectModified;

        public Spaceship Data
        {
            get
            {
                Spaceship s = new Spaceship();
                s.Name = textBoxName.Text;
                s.CrewSize = numericUpDownCrewSize.Value;
                s.ActiveDuty = checkBoxActiveDuty.Checked;
                s.Cruiser = radioButtonCruiser.Checked;
                s.Destroyer = radioButtonDestryer.Checked;
                s.Freighter = radioButtonFreighter.Checked;

                if (radioButtonCruiser.Checked == true && radioButtonDestryer.Checked == false && radioButtonFreighter.Checked == false)
                {
                    s.ImageIndex = radioButtonCruiser.TabIndex;
                    s.TypeOfShip = "Cruiser";
                }
                else if (radioButtonCruiser.Checked == false && radioButtonDestryer.Checked == true && radioButtonFreighter.Checked == false)
                {
                    s.ImageIndex = radioButtonDestryer.TabIndex;
                    s.TypeOfShip = "Destroyer";
                }
                else if (radioButtonCruiser.Checked == false && radioButtonDestryer.Checked == false && radioButtonFreighter.Checked == true)
                {
                    s.ImageIndex = radioButtonFreighter.TabIndex;
                    s.TypeOfShip = "Freighter";
                }

                return s;
            }
            set
            {
                textBoxName.Text = value.Name;
                numericUpDownCrewSize.Value = value.CrewSize;
                checkBoxActiveDuty.Checked = value.ActiveDuty;
                radioButtonCruiser.Checked = value.Cruiser;
                radioButtonDestryer.Checked = value.Destroyer;
                radioButtonFreighter.Checked = value.Freighter;
            }
        }

        public UserInputDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (ObjectAdded != null)
            {
                ObjectAdded(this, new EventArgs());
            }
            
            if (NumberOfItems != null)
            {
                NumberOfItems(this, new EventArgs());
            }

            
            Close();
        }

        public void PopulateDataUserInputHandler(object sender, EventArgs e)
        {
            lvf = sender as ListViewForm;

            Data = lvf.ClickedObject;
        }

        public void ApplyBtnVisibleHandler(object sender, EventArgs e)
        {
            buttonApply.Visible = true;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(ObjectModified != null)
            {
                ObjectModified(this, new EventArgs());
            }

            Close();
        }

        public void HandleModifyObject(object sender, ListViewForm.ModifyObjectEventArgs e)
        {
            Spaceship s = e.ObjectToModify1.Tag as Spaceship;
            s.Name = textBoxName.Text;
            s.CrewSize = numericUpDownCrewSize.Value;
            s.ActiveDuty = checkBoxActiveDuty.Checked;
            s.Cruiser = radioButtonCruiser.Checked;
            s.Destroyer = radioButtonDestryer.Checked;
            s.Freighter = radioButtonFreighter.Checked;

            if (radioButtonCruiser.Checked == true && radioButtonDestryer.Checked == false && radioButtonFreighter.Checked == false)
            {
                s.ImageIndex = radioButtonCruiser.TabIndex;
                s.TypeOfShip = "Cruiser";
            }
            else if (radioButtonCruiser.Checked == false && radioButtonDestryer.Checked == true && radioButtonFreighter.Checked == false)
            {
                s.ImageIndex = radioButtonDestryer.TabIndex;
                s.TypeOfShip = "Destroyer";
            }
            else if (radioButtonCruiser.Checked == false && radioButtonDestryer.Checked == false && radioButtonFreighter.Checked == true)
            {
                s.ImageIndex = radioButtonFreighter.TabIndex;
                s.TypeOfShip = "Freighter";
            }

            e.ObjectToModify1.Text = s.ToString();
            e.ObjectToModify1.ImageIndex = s.ImageIndex;
        }
    }
}
