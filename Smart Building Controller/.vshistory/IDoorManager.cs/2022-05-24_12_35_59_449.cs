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
        private bool[] doors = { false, false, false, false, false, false, false, false, false, false };
        public IDoorManager()
        {
            InitializeComponent();
        }

        public bool openDoor(int doorID)
        {
            return doors[doorID];
        }

        public bool lockDoor(int doorID)
        {
            return doors[doorID];
        }

        public bool openAllDoors()
        {
            for (int i = 0; i < doors.Length; i++)
            {
                //doors[i] = true;
                if (!doors[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool lockAllDoors()
        {
            for (int i = 0; i < doors.Length; i++)
            {
                //doors[i] = false;
                if (!doors[i])
                {
                    return false;
                }
            }

            return true;
        }

        public string getStatus()
        {
            return "";
        }

    }
}
