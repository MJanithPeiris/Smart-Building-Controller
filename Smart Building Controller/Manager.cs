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

        public string getStatus()
        {
            return "";
        }

        // public void setEngineerRequired(bool needsEngineer)
        // {
        //     engineerRequired = needsEngineer;
        // }
    }
}
