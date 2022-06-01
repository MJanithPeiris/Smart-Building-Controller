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
        public IFireAlarmManager()
        {
            InitializeComponent();
        }

        public virtual void SetAlarm(bool isActive)
        {
           
        }

        public virtual string GetStatus()
        {
            return "FireAlarm,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,";
        }

        private void tgbtn_all_alarms_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_all_alarms.Checked)
            {
                tgbtn_alarm_1.Checked = true;
                tgbtn_alarm_2.Checked = true;
                tgbtn_alarm_3.Checked = true;
                tgbtn_alarm_4.Checked = true;
                tgbtn_alarm_5.Checked = true;
                tgbtn_alarm_6.Checked = true;
                tgbtn_alarm_7.Checked = true;
                tgbtn_alarm_8.Checked = true;
                tgbtn_alarm_9.Checked = true;
                tgbtn_alarm_10.Checked = true;
            }
            else
            {
                tgbtn_alarm_1.Checked = false;
                tgbtn_alarm_2.Checked = false;
                tgbtn_alarm_3.Checked = false;
                tgbtn_alarm_4.Checked = false;
                tgbtn_alarm_5.Checked = false;
                tgbtn_alarm_6.Checked = false;
                tgbtn_alarm_7.Checked = false;
                tgbtn_alarm_8.Checked = false;
                tgbtn_alarm_9.Checked = false;
                tgbtn_alarm_10.Checked = false;
            }
        }
    }
}
