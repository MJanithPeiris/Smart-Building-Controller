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
    public partial class IWebService : Form
    {
        public IWebService()
        {
            InitializeComponent();
        }


        public virtual void LogStateChange(string logDetails)
        {

        }


        public virtual void LogEngineerRequired(string logDetails)
        {

        }


        public virtual void LogFireAlarm(string logDetails)
        {

        }

    }
}
