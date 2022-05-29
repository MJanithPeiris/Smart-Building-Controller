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
    public partial class IFireAlarmManager : Manager
    {
        private bool isFireAlarmOn;
        public IFireAlarmManager()
        {
            InitializeComponent();
        }

        public void setAlarm(bool isActive)
        {
            isFireAlarmOn = isActive;
        }

        public string getStatus()
        {
            return "";
        }

    }
}
