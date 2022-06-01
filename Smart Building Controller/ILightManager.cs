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
    public partial class ILightManager : Manager
    {
        public ILightManager()
        {
            InitializeComponent();
        }

        public virtual void SetLight(bool isOn, int lightID)
        {
            
        }

        public virtual void SetAllLights(bool isOn)
        {
            
        }

        public virtual string GetStatus()
        {
            return "Lights,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,";
        }

        private void tgbtn_all_lights_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_all_lights.Checked)
            {
                tgbtn_light_1.Checked = true;
                tgbtn_light_2.Checked = true;
                tgbtn_light_3.Checked = true;
                tgbtn_light_4.Checked = true;
                tgbtn_light_5.Checked = true;
                tgbtn_light_6.Checked = true;
                tgbtn_light_7.Checked = true;
                tgbtn_light_8.Checked = true;
                tgbtn_light_9.Checked = true;
                tgbtn_light_10.Checked = true;
            }
            else
            {
                tgbtn_light_1.Checked = false;
                tgbtn_light_2.Checked = false;
                tgbtn_light_3.Checked = false;
                tgbtn_light_4.Checked = false;
                tgbtn_light_5.Checked = false;
                tgbtn_light_6.Checked = false;
                tgbtn_light_7.Checked = false;
                tgbtn_light_8.Checked = false;
                tgbtn_light_9.Checked = false;
                tgbtn_light_10.Checked = false;
            }
        }
    }
}
