using DVLD_DataAccessLayer;
using System;
using static DVLD_BusinessLayer.clsApplication;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public clsTestAppointment TestAppointment;
        public string Notes { set; get; }
        public bool TestResult { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUser;

        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.Notes = "";
            this.TestResult = false;
            this.CreatedByUserID = -1;

            this.Mode = enMode.AddNew;
        }
        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.Find(CreatedByUserID);
            this.Mode = enMode.Update;
        }


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();

            }

            return false;
        }

        private bool _AddNewTest()
        {

            this.TestID = clsTestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, (byte)this.CreatedByUserID);
            return (this.TestID != -1);

        }

        private bool _UpdateTest()
        {

            return clsTestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, (byte)this.CreatedByUserID);

        }

        public static bool IsTestExist(int ApplicationID)
        {
            return clsTestData.IsTestExist(ApplicationID);
        }

    }
}