using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLayer
{
    public class clsLicense : clsApplication
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseID { set; get; }
        //     public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public clsDriver DriverInfo;// { set; get; }
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        //        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public byte IssueReason { set; get; }
        //     public int CreatedByUserID { set; get; }
        //       public clsUser CreatedByUserInfo;

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.DriverInfo = new clsDriver();
            this.LicenseClassID = -1;
            this.LicenseClassInfo = new clsLicenseClass();
            this.ExpirationDate = DateTime.Now;
            this.IssueDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = false;
            this.IssueReason = 0;
            //    this.CreatedByUserID = -1;
            //     this.CreatedByUserInfo = new clsUser();

            this.Mode = enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate,
              DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive,
                   byte IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.Find(DriverID);
            this.LicenseClassID = LicenseClass;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClass);
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.IssueDate = IssueDate;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            //      this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);

            this.Mode = enMode.Update;
        }


        //public static clsLicense Find(string DriverID)
        //{
        //    string Notes = "";
        //    short PaidFees = 1;
        //    bool IsActive = false;
        //    byte IssueReason = 0;
        //    DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
        //    int DriverxID = -1, LicenseClass = -1, LicenseID = -1, CreatedByUserID = -1;

        //    if (clsLicenseData.GetLicenseInfoByID(DriverID, ref, DriverxID, ref  DriverID, ref  LicenseClass, ref  IssueDate,
        //    ref  ExpirationDate, ref  Notes, ref  PaidFees, ref  IsActive,
        //         ref  IssueReason, ref  CreatedByUserID))

        //        return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, ExpirationDate, Notes,
        //              IssueDate, PaidFees, IsActive, IssueReason,  CreatedByUserID);
        //    else
        //        return null;
        //}


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicense();

            }

            return false;
        }

        private bool _AddNewLicense()
        {

            this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID != -1);

        }

        private bool _UpdateLicense()
        {

            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

        }

        public static bool DeleteLicense(int LicenseID)
        {
            return clsLicenseData.DeleteLicenseByID(LicenseID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicenseData.IsLicenseExistByID(LicenseID);
        }


    }

}
