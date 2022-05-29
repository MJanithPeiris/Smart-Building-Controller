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
        private string historyState;
        private IDoorManager doorManger = new IDoorManager();
        private ILightManager lightManager = new ILightManager();
        private IFireAlarmManager fireAlarmManager = new IFireAlarmManager();
        private IEmailService emailService = new IEmailService();
        private IWebService webService = new IWebService();


        public BuildingController()
        {
            InitializeComponent();
        }

        public BuildingController(string id) // overloaded constructor with single string parameter
        {
            buildingID = id.ToLower();
            currentState = "out of hours";
            InitializeComponent();
        }

        public BuildingController(string id, string startState) // overloaded constructor with 2 string parameter
        {
            if (startState.ToLower() == "open" || startState.ToLower() == "closed" || startState.ToLower() == "out of hours")
            {
                // convert to lower case and assign the values
                buildingID = id.ToLower();
                currentState = startState.ToLower();
            }
            else
            {
                // exception message
                throw new ArgumentException("Argument Exception: BuildingController can only be initialised to the following states 'open', 'closed', 'out of hours'");
            }
            InitializeComponent();
        }

        public BuildingController(string id, ILightManager iLightManager, IFireAlarmManager iFireAlarmManager,
            IDoorManager iDoorManager, IWebService iWebService, IEmailService iEmailService)
        {
            buildingID = id.ToLower();
            currentState = "out of hours";
            lightManager = iLightManager;
            fireAlarmManager = iFireAlarmManager;
            doorManger = iDoorManager;
            webService = iWebService;
            emailService = iEmailService;
            InitializeComponent();
        }

        public string GetCurrentState() // returns the current state of the building controller
        {
            return currentState;
        }

        public bool SetCurrentState(string state) // set the status of the building controller
        {
            switch (state.ToLower())
            {
                case "open":
                    // set the new state according to the current state 
                    if ((currentState == "out of hours" || currentState == "open") && doorManger.OpenAllDoors())
                    {
                        currentState = state.ToLower();
                    }
                    // go to the history state if the current state is fire alarm or fire drill
                    else if (currentState == "fire alarm" || currentState == "fire drill")
                    {
                        currentState = historyState;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "out of hours":
                    // set the new state according to the current state 
                    if (currentState == "open" || currentState == "closed" || currentState == "out of hours")
                    {
                        currentState = state.ToLower();
                    }
                    // go to the history state if the current state is fire alarm or fire drill
                    else if (currentState == "fire alarm" || currentState == "fire drill")
                    {
                        currentState = historyState;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "closed":
                    // set the new state according to the current state 
                    if (currentState == "out of hours" || currentState == "closed")
                    {
                        currentState = state.ToLower();
                        doorManger.LockAllDoors();
                        lightManager.SetAllLights(false);
                    }
                    // go to the history state if the current state is fire alarm or fire drill
                    else if (currentState == "fire alarm" || currentState == "fire drill")
                    {
                        currentState = historyState;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "fire drill":
                    if (currentState != "fire alarm")
                    {
                        historyState = currentState; // save the current state to history state
                        currentState = state.ToLower();
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case "fire alarm":
                    if (currentState != "fire drill")
                    {
                        historyState = currentState; // save the current state to history state
                        currentState = state.ToLower();
                        fireAlarmManager.SetAlarm(true);
                        doorManger.OpenAllDoors();
                        lightManager.SetAllLights(true);
                        try
                        {
                            webService.LogFireAlarm("fire alarm");
                        }
                        catch (Exception ex)
                        {
                            // send the email
                            emailService.SendMail("smartbuilding@uclan.ac.uk", "failed to log alarm", ex.ToString());
                        }
                    }
                    else
                    {
                        return false;
                    }
                    break;

                default:
                    return false;
            }

            return true;
        }

        public string GetBuildingID() // return the building id
        {
            return buildingID;
        }

        public void SetBuildingID(string id) // set the building id
        {
            buildingID = id.ToLower(); // convert to lowercase
        }

        public string GetStatusReport() // get the full status about all classes
        {
            string logString = "";
            // if a fault is in the status, then it will assign the name of the object to log string
            if (HaveFault(lightManager.GetStatus()))
            {
                logString += "Lights,";
            }

            if (HaveFault(doorManger.GetStatus()))
            {
                logString += "Doors,";
            }

            if (HaveFault(fireAlarmManager.GetStatus()))
            {
                logString += "FireAlarm,";
            }

            if (logString != "")
            {
                webService.LogEngineerRequired(logString);
            }

            // create a one string for all status
            string status = lightManager.GetStatus() + doorManger.GetStatus() + fireAlarmManager.GetStatus();

            return status;
        }

        public bool HaveFault(string status) // check whether the status contains fault
        {
            string[] statusList = status.Split(',');

            for (int i = 1; i < statusList.Length; i++)
            {
                if (statusList[i].ToUpper() == "FAULT") // check the fault is there
                {
                    return true;
                }
            }
            return false;
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
                SetCurrentState("open");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
            }
            else if (currentState == "out of hours" && btn_power.BackgroundColor == Color.ForestGreen)
            {
                btn_power.BackgroundColor = Color.Brown;
                SetCurrentState("closed");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
            }

            
        }

        private void tgbtn_out_of_hours_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbtn_out_of_hours.Checked == true && (currentState == "open" || currentState == "closed"))
            {
                lbl_out_of_hours.Text = "Out of Hours\nON";
                SetCurrentState("out of hours");
                
            }

            
        }

        
    }
}
