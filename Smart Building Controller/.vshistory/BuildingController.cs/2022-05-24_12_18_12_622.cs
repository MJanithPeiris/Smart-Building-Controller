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

        //public BuildingController(string id, ILightManager iLightManager, IFireAlarmManager iFireAlarmManager,
        //    IDoorManager iDoorManager, IWebService iWebService, IEmailService iEmailService)
        //{

        //}

        public string getCurrentState()
        {
            return currentState;
        }

        public bool setCurrentState(string state)
        {
            switch (state.ToLower())
            {
                case "closed":
                    if (currentState == "out of hours" || currentState == "closed")
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

                case "open":
                    if (currentState == "out of hours" || currentState == "open")
                    {
                        currentState = state.ToLower();
                    }
                    else
                    {
                        return false;
                    }

                    break;

                //case "fire drill":
                //    if (currentState == "out of hours")
                //    {
                //        currentState = state.ToLower();
                //    }
                //    else
                //    {
                //        return false;
                //    }

                //    break;

                //case "fire alarm":
                //    if (currentState == "out of hours")
                //    {
                //        currentState = state.ToLower();
                //    }
                //    else
                //    {
                //        return false;
                //    }

                //    break;

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
            string status = " ";

            return status;
        }
    }
}
