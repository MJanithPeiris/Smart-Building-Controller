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
    public class IDoorManagerStub : Manager
    {
        public bool OpenDoor(int doorID)
        {
            return true;
        }
    
        public bool LockDoor(int doorID)
        {
            return true;
        }
    
        public bool OpenAllDoors()
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
    
    public class ILightManagerStub : Manager
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
    
    public class IFireAlarmManagerStub : Manager
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

        
        [Test] // 03
        public void BuildingControllerSingleParameterConstructor_BuildingId_ConvertToLowercase()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("B0010");

            //Act
            string result = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual("b0010", result);
        }


        [Test] // 04
        public void BuildingControllerGetCurrentState_CurrentState_ReturnsTheCurrentStateAsOutOfHours()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            var result = buildingController.GetCurrentState();

            //Assert
            Assert.AreEqual("out of hours", result);
        }


        [Test] // 05
        public void BuildingControllerSingleParameterConstructor_CurrentState_SetCurrentStateToOutOfHours()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            string result = buildingController.GetCurrentState();

            //Assert
            Assert.AreEqual("out of hours", result);
        }

        
        [TestCase("open", true)] // 06
        [TestCase("closed", true)] // 07
        [TestCase("out of hours", true)] // 08
        [TestCase("fire alarm", true)] // 09
        [TestCase("fire drill", true)] // 10
        [TestCase("close", false)] // 11
        public void BuildingControllerSetCurrentState_CurrentState_OnlyForIntroducedStates(string bState, bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");
            
            //Act
            bool result = buildingController.SetCurrentState(bState);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }

       
        // should assign to current state
        [TestCase("b0010" , "open")] // 12
        [TestCase("b0010", "closed")]  // 13  
        [TestCase("b0010", "out of hours")] // 14
        // should not assign the current state to fire alarm and fire drill
        [TestCase("b0010", "fire alarm")] // 15
        [TestCase("b0010", "fire drill")] // 16
        public void BuildingControllerDoubleParameterConstructor_ConstructorSetCurrentStatus_AssignWhatUserInputs(string buildingId , string bState)
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


        // should throw exception
        [TestCase("b0010", "fire alarm")] // 17
        [TestCase("b0010", "fire drill")] // 18
        // should not throw exception
        [TestCase("b0010", "open")] // 19
        public void BuildingControllerConstructor_ConstructorSetCurrentStatus_ExceptionThrown(string buildingId, string bState)
        {
            //Arrange
            string exceptionMessage = " ";
            string expectExMessage = "Argument Exception: BuildingController can only be initialised to the following states 'open', 'closed', 'out of hours'";
            try
            {
                BuildingController buildingController = new BuildingController(buildingId, bState);

                //Act
                var buildingStatus = buildingController.GetCurrentState();
                string bId = buildingController.GetBuildingID();
            }
            catch(Exception ex)
            {
                exceptionMessage = ex.Message;
            }
            //Assert
            Assert.AreEqual(expectExMessage, exceptionMessage);
        }

        
        [TestCase("open" ,"closed" , false)] // 20
        [TestCase("closed", "open", false)] // 21
        [TestCase("closed", "fire alarm", true)] // 22
        [TestCase("open", "fire alarm", true)] // 23
        [TestCase("out of hours", "fire alarm", true)] // 24
        [TestCase("open", "open", true)] // 25
        [TestCase("closed", "closed", true)] // 26
        [TestCase("fire drill", "fire alarm", false)] // 27
        [TestCase("fire alarm", "fire drill", false)] // 28
        public void BuildingControllerSetCurrentState_SetCurrentState_ReturnTrueItIsPossible(string bState, string nextState , bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");
            
            //Act
            buildingController.SetCurrentState(bState);
            bool result = buildingController.SetCurrentState(nextState);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }


        [Test] // 29
        public void BuildingControllerSetBuildingID_BuildingID_SameToPassingID()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetBuildingID("b0020");
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual("b0020", bid);
        }

        [Test] // 30
        public void BuildingControllerSetBuildingID_BuildingID_ConvertToLowercase()
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            buildingController.SetBuildingID("B0020");
            string bid = buildingController.GetBuildingID();

            //Assert
            Assert.AreEqual("b0020", bid);
        }


        [TestCase("Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", false)] // 31
        [TestCase("Lights,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,OK,", true)] // 32
        [TestCase("FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,FAULT,", true)] // 33
        public void BuildingControllerHaveFault_Status_ReturnFalseIfNoFault(string status, bool exceptedOutput)
        {
            //Arrange
            BuildingController buildingController = new BuildingController("b0010");

            //Act
            bool result = buildingController.HaveFault(status);

            //Assert
            Assert.AreEqual(exceptedOutput, result);
        }


        [Test] // 34
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


        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "")] // 35
        [TestCase("Lights,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Lights,")] // 36
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,")] // 37
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,", "FireAlarm,")] // 38
        [TestCase("Lights,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Lights,Doors,")] // 39
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,FAULT,OK,OK,OK,OK,OK,OK,", "Doors,FireAlarm,")] // 40
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,", "Doors,OK,OK,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,", "Lights,FireAlarm,")] // 41
        [TestCase("Lights,OK,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,", "Doors,OK,FAULT,OK,OK,OK,OK,OK,OK,OK,OK,", "FireAlarm,OK,OK,OK,OK,OK,FAULT,OK,OK,OK,OK,", "Lights,Doors,FireAlarm,")] // 42
        public void GetStatusReport_CheckFault_AssignFaultDeviceName(string lightStatus, string doorStatus, string alarmStatus, string expectedOutput) // get the full status about all classes
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


        // [Test] // 43
        // public void IWebServiceLogFireAlarm_LogFireAlarm_ExceptionThrown()
        // {
        //     string exceptionMessage = "";
        //     BuildingController buildingController = new BuildingController("b0010");
        //
        //     try
        //     {
        //         buildingController.webService.LogFireAlarm("fire alarm");
        //     }
        //     catch (Exception ex)
        //     {
        //         exceptionMessage = ex.Message;
        //     }
        //
        //     Assert.AreEqual("Exception from LogFireAlarm", exceptionMessage);
        // }
        

    }
}
