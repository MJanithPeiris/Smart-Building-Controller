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
    public partial class SplashScreen : Form
    {
        public int progress;

        public SplashScreen()
        {
            progress = 0;
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 100;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            increaseProgress();
        }

        public void increaseProgress()
        {
            progressBar.Value = progress;
            if (progress == 100)
            {
                timer.Enabled = false;
                BuildingController form = new BuildingController("152");
                form.Show();
                this.Hide();
            }
            progress += 1;
        }
    }
}
