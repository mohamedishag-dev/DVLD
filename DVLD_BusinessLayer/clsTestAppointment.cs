using DVLD_DataAccessLayer;
using System;
using System.Data;
using static DVLD_BusinessLayer.clsTestType;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointment
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID;
        public clsTestType.enTestType TestTypeID;
        public clsTestType TestTypeInfo;
        public int LocalDrivingLicenseApplicationID;
            public clsLocalDrivingLicenseApplication DrivingLicenseApp = new clsLocalDrivingLicenseApplication();
        public DateTime AppointmentDate;
        public float PaidFees;
        public int CreatedByUserID;
        public clsUser CreatedByUser;
        public bool IsLocked;
        public int RetakeTestApplicationID;
        public clsApplication RetakeTestAppInfo;
        public int TestID
        {
            get { return _GetTestID(); }

        }
        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            this.Mode = enMode.AddNew;
        }
        private clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID,
            int LocalDrivingLicenseAppointmentID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestAppointmentID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.TestTypeInfo = clsTestType.Find(TestTypeID);
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseAppointmentID;
                 this.DrivingLicenseApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseAppointmentID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.FindByUserID(CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestAppointmentID;
            this.RetakeTestAppInfo = clsApplication.FindBaseApplication(RetakeTestAppointmentID);
            this.Mode = enMode.Update;

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();

            }

            return false;
        }

        public int _GetTestID()
        {
            return clsTestAppointmentData.GetTestID(this.TestAppointmentID);
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentData.GetAllTestAppointments();
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            float PaidFees = 0;
            bool IsLocked = false;
            DateTime AppointmentDate = DateTime.Now;
            int TestTypeID = (int)clsTestType.enTestType.VisionTest;
            int CreatedByUserID = -1, LocalDrivingLicenseTestAppointmentID = -1, RetakeTestAppointmentID = -1;

            if (clsTestAppointmentData.GetTestAppointmentInfoByID(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseTestAppointmentID, ref AppointmentDate, ref PaidFees,
                ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))

                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseTestAppointmentID, AppointmentDate, PaidFees,
                     CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDrivingLicenseAppointmentID, enTestType TestTypeID)
        {
            return clsTestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDrivingLicenseAppointmentID, (int)TestTypeID);

        }



        public static int GetLestRetakeTest()
        {
            return clsTestAppointmentData.GetLestRetakeTest();
        }
        public static int GetPassedTestCount(int LocalDrivingLicenseAppointmentID)
        {
            return clsTestAppointmentData.GetPassedTestCount(LocalDrivingLicenseAppointmentID);
        }
        public static bool IsActiveAppointment(int LocalDrivingLicenseTestAppointmentID)
        {
            //incase the ActiveAppointmentID ID !=-1 return true.
            return GetActiveAppointmentID(LocalDrivingLicenseTestAppointmentID) != -1;
        }
        public static int GetActiveAppointmentID(int LocalDrivingLicenseTestAppointmentID)
        {
            return clsTestAppointmentData.GetActiveTestAppointment(LocalDrivingLicenseTestAppointmentID);

        }
        public static bool IsTackTest(int LocalDrivingLicenseTestAppointmentID, int TestTypeID)
        {
            return clsTestAppointmentData.IsTackTest(LocalDrivingLicenseTestAppointmentID, TestTypeID);
        }
        public static int CountTackTest(int LocalDrivingLicenseTestAppointmentID, int TestTypeID)
        {
            return clsTestAppointmentData.CountTackTest(LocalDrivingLicenseTestAppointmentID, TestTypeID);
        }
        public static clsTestAppointment FindForDrivingLicenseApp(int LocalDrivingLicenseTestAppointmentID)
        {
            float PaidFees = 0;
            bool IsLocked = false;
            DateTime AppointmentDate = DateTime.Now;
            int TestTypeID = (int)clsTestType.enTestType.VisionTest;
            int CreatedByUserID = -1, TestAppointmentID = -1, RetakeTestAppointmentID = -1;

            if (clsTestAppointmentData.GetTestAppointmentInfoForLocalDrivingLicenseApplicationID(LocalDrivingLicenseTestAppointmentID, ref TestTypeID, ref TestAppointmentID, ref AppointmentDate, ref PaidFees,
                ref CreatedByUserID, ref IsLocked, ref RetakeTestAppointmentID))

                return new clsTestAppointment(TestAppointmentID, (clsTestType.enTestType)TestTypeID, LocalDrivingLicenseTestAppointmentID, AppointmentDate, PaidFees,
                     CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }



    }

}