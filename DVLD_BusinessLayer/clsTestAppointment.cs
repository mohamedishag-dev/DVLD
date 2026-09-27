using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointment
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestAppointmentID;
        public clsTestType.enTestType TestTypeID;
        public clsTestType TestType;
        public int LocalDrivingLicenseAppointmentID;
        public clsLocalDrivingLicenseApplication LicenseAppointment;
        public DateTime AppointmentDate;
        public float PaidFees;
        public int CreatedByUserID;
        public clsUser CreatedByUser;
        public bool IsLocked;
        public int RetakeTestAppointmentID;

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.LocalDrivingLicenseAppointmentID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestAppointmentID = -1;
            this.Mode = enMode.AddNew;
        }
        private clsTestAppointment(int TestAppointmentID, clsTestType.enTestType TestTypeID, int LocalDrivingLicenseAppointmentID, DateTime AppointmentDate,
            float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestAppointmentID)
        {
            this.TestAppointmentID= TestAppointmentID ;
            this.TestTypeID = TestTypeID;
            this.TestType = clsTestType.Find(this.TestTypeID);
            this.LocalDrivingLicenseAppointmentID = LocalDrivingLicenseAppointmentID;
            this.LicenseAppointment = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseAppointmentID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.Find(CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestAppointmentID = RetakeTestAppointmentID;
            this.Mode = enMode.Update;

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
                     CreatedByUserID,  IsLocked, RetakeTestAppointmentID);
            else
                return null;
        }

        public static DataTable GetAllTestAppointments(int LocalDrivingLicenseAppointmentID, int TestTypeID)
        {
            return clsTestAppointmentData.GetAllTestAppointments(LocalDrivingLicenseAppointmentID, TestTypeID);
        }

        private bool _AddNewTestAppointment()
        {

            this.TestAppointmentID = clsTestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.LocalDrivingLicenseAppointmentID, this.AppointmentDate,
                this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppointmentID);

            return (this.TestAppointmentID != -1);

        }

        private bool _UpdateTestAppointment()
        {

            return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.LocalDrivingLicenseAppointmentID, this.AppointmentDate,
                this.PaidFees, this.CreatedByUserID, this.IsLocked, this.RetakeTestAppointmentID);

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

        public static bool IsTestAppointmentExist(int AppointmentID)
        {
            return clsTestAppointmentData.IsTestAppointmentExistByID(AppointmentID);
        }


    }

}