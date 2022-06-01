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
    public partial class Manager : Form
    {
        private bool engineerRequired;

        public Manager()
        {
            InitializeComponent();
        }

        public string GetStatus()
        {
            return "";
        }

        public bool SetEngineerRequired(bool needsEngineer)
        {
             engineerRequired = needsEngineer;
             return engineerRequired;
        }
    }
}
