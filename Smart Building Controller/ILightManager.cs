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
        private bool[] lights = { false, false, false, false, false, false, false, false, false, false };
        public ILightManager()
        {
            InitializeComponent();
        }
        public void setLight(bool isOn, int lightID)
        {
            lights[lightID] = isOn;
        }

        public void setAllLights(bool isOn)
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i] = isOn;
            }
        }

        public string getStatus()
        {
            return "";
        }
    }
}
