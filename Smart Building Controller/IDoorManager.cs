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

        public bool OpenDoor(int doorID)
        {
            return doors[doorID];
        }

        public bool LockDoor(int doorID)
        {
            return doors[doorID];
        }

        public bool OpenAllDoors()
        {
            // for (int i = 0; i < doors.Length; i++)
            // {
            //     //doors[i] = true;
            //     if (!doors[i])
            //     {
            //         return false;
            //     }
            // }

            return true;
        }

        public bool LockAllDoors()
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

        public string GetStatus()
        {
            return "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,";
        }

    }
}
