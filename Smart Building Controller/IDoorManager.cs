using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Building_Controller
{
    public partial class IDoorManager : Manager
    {
        public IDoorManager()
        {
            InitializeComponent();
        }

        public virtual bool OpenDoor(int doorID)
        {
            return true;
        }

        public virtual bool LockDoor(int doorID)
        {
            return true;
        }

        public virtual bool OpenAllDoors()
        {
            return true;
        }

        public virtual bool LockAllDoors()
        {
            return true;
        }

        public virtual string GetStatus()
        {
            return "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,";
        }

        private void tgbtn_all_doors_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_all_doors.Checked)
            {
                tgbtn_door_1.Checked = true;
                tgbtn_door_2.Checked = true;
                tgbtn_door_3.Checked = true;
                tgbtn_door_4.Checked = true;
                tgbtn_door_5.Checked = true;
                tgbtn_door_6.Checked = true;
                tgbtn_door_7.Checked = true;
                tgbtn_door_8.Checked = true;
                tgbtn_door_9.Checked = true;
                tgbtn_door_10.Checked = true;
            }
            else
            {
                tgbtn_door_1.Checked = false;
                tgbtn_door_2.Checked = false;
                tgbtn_door_3.Checked = false;
                tgbtn_door_4.Checked = false;
                tgbtn_door_5.Checked = false;
                tgbtn_door_6.Checked = false;
                tgbtn_door_7.Checked = false;
                tgbtn_door_8.Checked = false;
                tgbtn_door_9.Checked = false;
                tgbtn_door_10.Checked = false;
            }
        }
    }
}
