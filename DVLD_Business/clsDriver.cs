using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{

    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUser { set; get; }
        public DateTime CreatedDate { set; get; }

        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;

            this.Mode = enMode.AddNew;
        }
        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.FindByUserID(CreatedByUserID);
            this.CreatedDate = CreatedDate;
            this.Mode = enMode.Update;
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDriver();

            }

            return false;
        }

        public bool Delete()
        {
            return clsDriverData.DeleteDriver(this.DriverID);
        }

        private bool _AddNewDriver()
        {

            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return (this.DriverID != -1);

        }

        private bool _UpdateDriver()
        {

            return clsDriverData.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);

        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverData.GetAllDrivers();
        }

        public static clsDriver Find(int DriverID)
        {

            DateTime CreatedDate = DateTime.Now;
            int PersonID = -1, CreatedByUserID = -1;

            if (clsDriverData.GetDriverInfoByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {

            DateTime CreatedDate = DateTime.Now;
            int DriverID = -1, CreatedByUserID = -1;

            if (clsDriverData.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            else
                return null;
        }

        public static bool IsDriverExist(int DriverID)
        {
            return clsDriverData.IsDriverExist(DriverID);
        }

        public static bool IsDriverExist(string NationalNo)
        {
            return clsDriverData.IsDriverExistForNationalNo(NationalNo);
        }
    
    }

}