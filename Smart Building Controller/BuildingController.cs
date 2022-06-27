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
        public IDoorManager doorManger = new IDoorManager();
        public ILightManager lightManager = new ILightManager();
        public IFireAlarmManager fireAlarmManager = new IFireAlarmManager();
        public IEmailService emailService = new IEmailService();
        public IWebService webService = new IWebService();
        

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
                    // moves to the history state if the current state is fire alarm or fire drill
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
                    // moves to the history state if the current state is fire alarm or fire drill
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
                    // moves to the history state if the current state is fire alarm or fire drill
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
                        if (currentState != "fire drill")
                        {
                            historyState = currentState; // save the current state to history state
                        }
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
                        if (currentState != "fire alarm")
                        {
                            historyState = currentState; // save the current state to history state
                        }

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
                            // sends the email
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

        private string logString;
        public string GetStatusReport() // get the full status about all classes
        {
            logString = "";
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

            // creates a single string of all statuses of the three manager classes
            string status = lightManager.GetStatus() + doorManger.GetStatus() + fireAlarmManager.GetStatus();

            return status;
        }

        public bool HaveFault(string status) // check whether the status contains a fault
        {
            string[] statusList = status.Split(',');

            for (int i = 1; i < statusList.Length; i++)
            {
                if (statusList[i].ToUpper() == "FAULT") // checks whether the fault is present
                {
                    return true;
                }
            }
            return false;
        }


        // UI Mapping
        private void BuildingController_Load(object sender, EventArgs e)
        {
            if (currentState == "out of hours")
            {
                tgbtn_out_of_hours.Checked = true;
                lbl_out_of_hours.Text = "Out of Hours\nON";
            }else if (currentState == "open")
            {
                btn_power.BackgroundColor = Color.ForestGreen;
            }
            else if(currentState == "closed")
            {
                btn_power.BackgroundColor = Color.Brown;
            }

            lbl_system_state.Text = "System State :\n" + currentState;
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

        private string previousState ="";

        private void btn_power_Click(object sender, EventArgs e)
        {
            if (currentState == "out of hours" && previousState == "closed" || previousState == "")

        {
                btn_power.BackgroundColor = Color.ForestGreen;
                SetCurrentState("open");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
                previousState = "open";
            }
            else if (currentState == "out of hours" && previousState == "open")
            {
                btn_power.BackgroundColor = Color.Brown;
                SetCurrentState("closed");
                lbl_out_of_hours.Text = "Out of Hours\nOFF";
                tgbtn_out_of_hours.Checked = false;
                previousState = "closed";
            }
            lbl_system_state.Text = "System State :\n" + currentState;
        }

        
        private void tgbtn_out_of_hours_CheckedChanged(object sender, EventArgs e)
        {
            if (currentState == "fire alarm" || currentState == "fire drill")
            {
                tgbtn_out_of_hours.Checked = false;
            }

            if (tgbtn_out_of_hours.Checked == true && SetCurrentState("out of hours"))
            {
                lbl_out_of_hours.Text = "Out of Hours\nON";
                btn_power.BackgroundColor = Color.Orange;

            }

            if (currentState == "out of hours" && !tgbtn_out_of_hours.Checked)
            {
                if (previousState == "open")
                {
                    SetCurrentState("open");
                    btn_power.BackgroundColor = Color.ForestGreen;
                    lbl_out_of_hours.Text = "Out of Hours\nOFF";
                }
                else if (previousState == "closed")
                {
                    SetCurrentState("closed");
                    btn_power.BackgroundColor = Color.Brown;
                    lbl_out_of_hours.Text = "Out of Hours\nOFF";
                }
                else
                {
                    tgbtn_out_of_hours.Checked = true;
                }
                
            }
            lbl_system_state.Text = "System State :\n" + currentState;

        }

        private void tgbtn_fire_drill_CheckedChanged(object sender, EventArgs e)
        {
            if (currentState == "fire alarm")
            {
                tgbtn_fire_drill.Checked = false;
                MessageBox.Show("Currently you are in 'Fire Alarm'. Can't shift to 'Fire Drill'","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (tgbtn_fire_drill.Checked == false)
                {
                    currentState = historyState;
                    if (historyState == "out of hours")
                    {
                        tgbtn_out_of_hours.Checked = true;
                        lbl_out_of_hours.Text = "Out of Hours\nON";
                    }
                }
                else
                {
                    if (SetCurrentState("fire drill"))
                    {
                        tgbtn_out_of_hours.Checked = false;
                        lbl_out_of_hours.Text = "Out of Hours\nOFF";
                    }
                }
            }
            lbl_system_state.Text = "System State :\n" + currentState;
        }

        private void tgbtn_fire_alarm_CheckedChanged(object sender, EventArgs e)
        {
            if (currentState == "fire drill")
            {
                tgbtn_fire_alarm.Checked = false;
                MessageBox.Show("Currently you are in 'Fire Drill'. Can't shift to 'Fire Alarm'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tgbtn_fire_alarm.Checked == false)
                {
                    currentState = historyState;
                    if (historyState == "out of hours")
                    {
                        tgbtn_out_of_hours.Checked = true;
                        lbl_out_of_hours.Text = "Out of Hours\nON";
                    }
                }
                else
                {
                    if (SetCurrentState("fire alarm"))
                    {
                        tgbtn_out_of_hours.Checked = false;
                        lbl_out_of_hours.Text = "Out of Hours\nOFF";
                    }
                }
            }
            lbl_system_state.Text = "System State :\n" + currentState;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetStatusReport();
            lbl_notification.Text = " Fault in : \n " + logString;
        }
    }
}
