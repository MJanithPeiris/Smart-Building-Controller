using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace Smart_Building_Controller
{
    public class IDoorManagerStub : IDoorManager
    {
        public bool OpenDoor(int doorID)
        {
            return false;
        }
    
        public bool LockDoor(int doorID)
        {
            return true;
        }
    
        public override bool OpenAllDoors()
        {
            return true;
        }
    
        public bool LockAllDoors()
        {
            return true;
        }
    
        public string GetStatus()
        {
            return "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,";
        }
    
        public bool SetEngineerRequired(bool needsEngineer)
        {
            return needsEngineer;
        }
    
    }
    
    public class ILightManagerStub : ILightManager
    {
        public void SetLight(bool isOn, int lightID)
        {
    
        }
    
        public void SetAllLights(bool isOn)
        {
    
        }
    
        public string GetStatus()
        {
            return "Lights,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,";
        }
    
        public  bool SetEngineerRequired(bool needsEngineer)
        {
            return needsEngineer;
        }
    
    }
    
    public class IFireAlarmManagerStub : IFireAlarmManager
    {
        public void SetAlarm(bool isActive)
        {
    
        }
    
        public string GetStatus()
        {
            return "FireAlarm,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,";
        }
    
        public bool SetEngineerRequired(bool needsEngineer)
        {
            return needsEngineer;
        }
    }
    
    public class IEmailServiceStub : IEmailService
    {
        public void SendMail(string emailAddress, string subject, string message)
        {
        }
    }
    
    public class IWebServiceStub : IWebService
    {
        public void LogStateChange(string logDetails)
        {
    
        }
    
        public void LogEngineerRequired(string logDetails)
        {
    
        }
    
        public void LogFireAlarm(string logDetails)
        {
            throw new ArgumentException("Exception from LogFireAlarm");
        }
    }



    [TestFixture]
    class BuildingControllerTests
    {
        // Level 01 Requirement

        // test GetBuildingID() method returns the same building id that is set using Single Parameter Constructor
        // checking using two different IDs
        [TestCase("b0010")] // 01
        [TestCase("b0020")] // 02
        public void BuildingControllerSingleParameterConstructor_GetBuildingId_ReturnsSameBuildingID(string buildingId)
        {
            //Arrange
            BuildingController buildingController = new BuildingController(buildingId);

            //Act
            var result = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId, result);
        }


        // test Single Parameter Constructor converts the upper case letters to lower case letters of the building ID
        // checking using two different IDs containing upper case letters
        [TestCase("B0010")] // 03
        [TestCase("A0020")] // 04
        public void BuildingControllerSingleParameterConstructor_BuildingId_ConvertToLowercase(string buildingId)
        {
            //Arrange
            BuildingController buildingController = new BuildingController(buildingId);

            //Act
            string result = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId.ToLower(), result);
        }


        // test whether any other building ID gets assigned when passed into it using SetBuildingID()
        // checking using two different IDs
        [TestCase("b0020")] // 05
        [TestCase("b0030")] // 06
        public void BuildingControllerSetBuildingID_BuildingID_SetToSamePassingID(string buildingId)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetBuildingID(buildingId);
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId, bid);
        }


        // test SetBuildingID() method converts the upper case letters to lower case letters of the building ID
        // checking using two different IDs containing upper case letters
        [TestCase("B0010")] // 07
        [TestCase("C0020")] // 08
        public void BuildingControllerSetBuildingID_BuildingID_ConvertToLowercase(string buildingId)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetBuildingID(buildingId);
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId.ToLower(), bid);
        }


        // test GetCurrentState() check whether the same current state that is set is returned
        [Test] // 09
        public void BuildingControllerGetCurrentState_CurrentState_ReturnsTheCurrentStateAsOutOfHours()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            var result = buildingController.GetCurrentState();

            //Assert
            Assert.AreEqual("out of hours", result);
        }


        // test SingleParameterConstructor set the initial state as "out of hours" when the constructor is called
        [Test] // 10
        public void BuildingControllerSingleParameterConstructor_CurrentState_SetCurrentStateToOutOfHours()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            string result = buildingController.GetCurrentState();

            //Assert
            Assert.AreEqual("out of hours", result);
        }


        // test SetCurrentState() checks whether only if the valid states ("closed", "out of hours", "open", "fire drill" or "fire alarm") is able to set 
        [TestCase("open", true)] // 11
        [TestCase("closed", true)] // 12
        [TestCase("out of hours", true)] // 13
        [TestCase("fire alarm", true)] // 14
        [TestCase("fire drill", true)] // 15
        [TestCase("close", false)] // 16
        public void BuildingControllerSetCurrentState_CurrentState_OnlyForIntroducedStates(string bState,
            bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            bool result = buildingController.SetCurrentState(bState);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }


        // Level 02 Requirement

        // test SetCurrentState() states are set in reference to the state transition diagram.
        [TestCase("open", "closed", false)] // 17  // checks whether current state is open and is able to change into closed state
        [TestCase("closed", "open", false)] // 18  // checks whether current state is closed and is able to change into open state
        [TestCase("closed", "fire alarm", true)] // 19  // checks whether current state is closed and is able to change into fire alarm state
        [TestCase("open", "fire alarm", true)] // 20  // checks whether current state is open and is able to change into fire alarm state
        [TestCase("out of hours", "fire alarm", true)] // 21  // checks whether current state is out of hours and is able to change into fire alarm state
        [TestCase("closed", "fire drill", true)] // 22  // checks whether current state is closed and is able to change into fire drill state
        [TestCase("open", "fire drill", true)] // 23 // checks whether current state is open and is able to change into fire drill state
        [TestCase("out of hours", "fire drill", true)] // 24  // checks whether current state is out of hours and is able to change into fire drill state
        [TestCase("open", "open", true)] // 25  // checks whether current state is open and is able to change into open state
        [TestCase("closed", "closed", true)] // 26  // checks whether current state is closed and is able to change into closed state
        [TestCase("out of hours", "out of hours", true)] // 27  // checks whether current state is out of hours and is able to change into out of hours state
        [TestCase("fire drill", "fire alarm", false)] // 28  // checks whether current state is fire drill and is able to change into fire alarm state
        [TestCase("fire alarm", "fire drill", false)] // 29  // checks whether current state is fire alarm and is able to change into fire drill state
        public void BuildingControllerSetCurrentState_SetCurrentState_ReturnTrueItIsPossible(string bState,
            string nextState, bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetCurrentState(bState);
            bool result = buildingController.SetCurrentState(nextState);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }


        // test SetCurrentState() method returns true and remains in the same state
        [TestCase("open", true)] // 30
        [TestCase("closed", true)] // 31
        [TestCase("out of hours", true)] // 32
        [TestCase("fire alarm", true)] // 33
        [TestCase("fire drill", true)] // 34
        public void BuildingControllerSetCurrentState_CurrentState_ReturnsTrueIfSameState(string bState,
            bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetCurrentState(bState);
            bool result = buildingController.SetCurrentState(bState);
            string state = buildingController.GetCurrentState();
            //Assert
            Assert.AreEqual(exceptedOutput, result);
            Assert.AreEqual(bState, state);
        }


        // test whether the state that is passing always gets converted to lower case
        [TestCase("b0010", "Open")] // 35
        [TestCase("b0010", "CLOSED")] // 36 
        [TestCase("b0010", "Out Of Hours")] // 37
        [TestCase("b0010", "Out Of HOURS")] // 38
        public void BuildingControllerDoubleParameterConstructor_ConstructorSetCurrentStatus_ConvertToLowercase(
            string buildingId, string bState)
        {
            //Arrange
            BuildingController buildingController = new BuildingController(buildingId, bState);

            //Act
            var buildingState = buildingController.GetCurrentState();
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId, bid);
            Assert.AreEqual(bState.ToLower(), buildingState);
        }


        // test double parameter constructor can only be initialised to one of the three normal operation states("closed", "out of hours" or "open")
        // should assign to current state
        [TestCase("b0010", "open")] // 39
        [TestCase("b0010", "closed")] // 40
        [TestCase("b0010", "out of hours")] // 41
        // should not assign the current state to fire alarm and fire drill
        [TestCase("b0010", "fire alarm")] // 42
        [TestCase("b0010", "fire drill")] // 43
        public void BuildingControllerDoubleParameterConstructor_ConstructorSetCurrentStatus_AssignAllowedUserInputs(
            string buildingId, string bState)
        {
            //Arrange
            BuildingController buildingController = new BuildingController(buildingId, bState);

            //Act
            var buildingState = buildingController.GetCurrentState();
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual(buildingId, bid);
            Assert.AreEqual(bState, buildingState);
        }


        // test whether the exception is thrown when the double parameter constructor is attempting to initialise the
        // state to "fire drill" or "fire alarm" or any other state except "closed", "out of hours" or "open"
        // should throw exception
        [TestCase("b0010", "fire alarm")] // 44
        [TestCase("b0010", "fire drill")] // 45
        [TestCase("b0010", "close")] // 46
        // should not throw exception
        [TestCase("b0010", "open")] // 47
        [TestCase("b0010", "closed")] // 48
        [TestCase("b0010", "out of hours")] //49
        public void BuildingControllerConstructor_ConstructorSetCurrentStatus_ExceptionThrown(string buildingId,
            string bState)
        {
            //Arrange
            string exceptionMessage = " ";
            string expectExMessage =
                "Argument Exception: BuildingController can only be initialised to the following states 'open', 'closed', 'out of hours'";
            try
            {
                BuildingController buildingController = new BuildingController(buildingId, bState);

                //Act
                var buildingStatus = buildingController.GetCurrentState();
                string bId = buildingController.GetBuildingID();
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
            }

            //Assert
            Assert.AreEqual(expectExMessage, exceptionMessage);
        }


        // Level 03 Requirement

        // test GetStatus() checks whether the status gets returned via the 3 manager classes 
        [Test] // 50
        public void ManagerClassGetStatus_Status_ReturnStatusAsString()
        {
            //Arrange
            IDoorManagerStub doorManagerStub = new IDoorManagerStub();
            ILightManagerStub lightManagerStub = new ILightManagerStub();
            IFireAlarmManagerStub fireAlarmManagerStub = new IFireAlarmManagerStub();

            //Act
            string doorStatus = doorManagerStub.GetStatus();
            string lightStatus = lightManagerStub.GetStatus();
            string fireAlarmStatus = fireAlarmManagerStub.GetStatus();

            //Assert
            Assert.AreEqual("Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", doorStatus);
            Assert.AreEqual("Lights,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,", lightStatus);
            Assert.AreEqual("FireAlarm,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,", fireAlarmStatus);

        }

        // test GetStatusReport() method returns all three manager classes' status as a single string
        [Test] // 51
        public void BuildingControllerGetStatusReport_Status_ReturnAllStatusOfManagerClasses()
        {
            //Arrange
            string expectStatus =
                "Lights,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,FireAlarm,OK,OK,FAULT,OK,OK,OK,OK,FAULT,OK,OK,";

            BuildingController buildingController = new BuildingController("b0010");

            //Act
            string status = buildingController.GetStatusReport();

            //Assert
            Assert.AreEqual(expectStatus, status);
        }


        // Level 04 Requirement

        // test HaveFault() method returns true if the status string contains a FAULT
        [TestCase("Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", false)] // 52
        [TestCase("Lights,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,OK,", true)] // 53
        [TestCase("FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,FAULT,", true)] // 54
        public void BuildingControllerHaveFault_Status_ReturnFalseIfNoFault(string status, bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            bool result = buildingController.HaveFault(status);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }


        // test inside GetStatusReport() checks whether it identifies the name of device that has shown a fault using HaveFault method
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "")] // 55
        [TestCase("Lights,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Lights,")] // 56
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,")] // 57
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,", "FireAlarm,")] // 58
        [TestCase("Lights,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Lights,Doors,")] // 59
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,", "Doors,FireAlarm,")] // 60
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,", "Lights,FireAlarm,")] // 61
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,",
            "FireAlarm,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,", "Lights,Doors,FireAlarm,")] // 62
        public void GetStatusReport_CheckFault_AssignFaultDeviceName(string lightStatus, string doorStatus,
            string alarmStatus, string expectedOutput) // get the full status about all classes
        {
            //Arrange
            string logString = "";
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            // if a fault is in the status, then it will assign the name of the object to log string
            if (buildingController.HaveFault(lightStatus))
            {
                logString += "Lights,";
            }

            if (buildingController.HaveFault(doorStatus))
            {
                logString += "Doors,";
            }

            if (buildingController.HaveFault(alarmStatus))
            {
                logString += "FireAlarm,";
            }

            if (logString != "")
            {
                // webService.LogEngineerRequired(logString);
            }

            //Assert
            Assert.AreEqual(expectedOutput, logString);


            // create a one string for all status
            string status = lightStatus + doorStatus + alarmStatus;
            //return status;
        }

    }
}
