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
    public partial class BuildingController : Form
    {
        private string buildingID;
        private string currentState;
        private string previousState;
        private IDoorManager doorManger = new IDoorManager();
        private ILightManager lightManager = new ILightManager();
        private IFireAlarmManager fireAlarmManager = new IFireAlarmManager();
        private IEmailService emailService = new IEmailService();
        private IWebService webService = new IWebService();


        public BuildingController()
        {
            InitializeComponent();
        }

        public BuildingController(string id)
        {
            buildingID = id.ToLower();
            currentState = "out of hours";
            InitializeComponent();
        }

        public BuildingController(string id, string startState)
        {
            if (startState.ToLower() == "open" || startState.ToLower() == "closed" || startState.ToLower() == "out of hours")
            {
                buildingID = id.ToLower();
                currentState = startState.ToLower();
                InitializeComponent();
            }
            else
            {
                throw new ArgumentException("Argument Exception: BuildingController can only be initialised to the following states 'open', 'closed', 'out of hours'");
            }
        }

        public BuildingController(string id, ILightManager iLightManager, IFireAlarmManager iFireAlarmManager,
            IDoorManager iDoorManager, IWebService iWebService, IEmailService iEmailService)
        {
            buildingID = id;
            lightManager = iLightManager;
            fireAlarmManager = iFireAlarmManager;
            doorManger = iDoorManager;
            webService = iWebService;
            emailService = iEmailService;
        }

        public string getCurrentState()
        {
            return currentState;
        }

        public bool setCurrentState(string state)
        {
            switch (state.ToLower())
            {
                case "open":
                    if ((currentState == "out of hours" || currentState == "open") && doorManger.openAllDoors())
                    {
                        currentState = state.ToLower();

                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "out of hours":
                    if (currentState == "open" || currentState == "closed" || currentState == "out of hours")
                    {
                        currentState = state.ToLower();
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "closed":
                    if (currentState == "out of hours" || currentState == "closed")
                    {
                        currentState = state.ToLower();
                        doorManger.lockAllDoors();
                        lightManager.setAllLights(false);
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "fire drill":
                    previousState = currentState;
                    currentState = state.ToLower();
                    break;

                case "fire alarm":
                    previousState = currentState;
                    currentState = state.ToLower();
                    fireAlarmManager.setAlarm(true);
                    doorManger.openAllDoors();
                    lightManager.setAllLights(true);
                    webService.logFireAlarm("fire alarm");
                    break;

                default:
                    return false;
            }

            return true;
        }

        public string getBuildingID()
        {
            return buildingID;
        }

        public void setBuildingID(string id)
        {
            buildingID = id.ToLower();
        }

        public string getStatusReport()
        {
            string status = lightManager.getStatus() + "," + doorManger.getStatus() + "," + fireAlarmManager.getStatus();

            return status;
        }


        public bool checkFaluts(string status)
        {
            string[] statusList = status.Split(',');

            for (int i = 1; i < statusList.Length; i++)
            {
                if (statusList[i].ToUpper() == "FAULT")
                {
                    return false;
                }
            }

            return true;
        }

        private void BuildingController_Load(object sender, EventArgs e)
        {
            if (currentState == "out of hours")
            {
                tgbtn_out_of_hours.Checked = true;
                lbl_out_of_hours.Text = "Out of Hours\nON";
            }
           
        }

        private void btn_door_controller_Click(object sender, EventArgs e)
        {
            doorManger.Show();
        }

        private void btn_light_controller_Click(object sender, EventArgs e)
        {
            lightManager.Show();
        }

        private void btn_fire_alarm_controller_Click(object sender, EventArgs e)
        {
            fireAlarmManager.Show();
        }

        private void btn_web_service_Click(object sender, EventArgs e)
        {
            webService.Show();
        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            if (currentState == "out of hours" && btn_power.BackgroundColor == Color.Brown)
            {
                btn_power.BackgroundColor = Color.ForestGreen;
                setCurrentState("open");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
            }
            else if (currentState == "out of hours" && btn_power.BackgroundColor == Color.ForestGreen)
            {
                btn_power.BackgroundColor = Color.Brown;
                setCurrentState("closed");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
            }

            
        }

        private void tgbtn_out_of_hours_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_out_of_hours.Checked == true && (currentState == "open" || currentState == "closed"))
            {
                lbl_out_of_hours.Text = "Out of Hours\nON";
                setCurrentState("out of hours");
                
            }

            
        }

        
    }
}
