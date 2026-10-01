using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLayer
{

    public class clsDriver
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUser;
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
            this.CreatedByUser = clsUser.Find(CreatedByUserID);
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



    }

}
