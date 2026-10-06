using DVLD_DataAccessLayer;
using System;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int InternationalLicenseID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            Mode = enMode.AddNew;
        }
        private clsInternationalLicense(int InternationalLicenseID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.Find(DriverID);
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }


        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    {
                        return _UpdateInternationalLicense();
                    }
            }
            return false;

        }

        public bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.DriverID, this.IssuedUsingLocalLicenseID,
                            this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);

        }

        public bool _UpdateInternationalLicense()
        {

            return clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID,this.DriverID, this.IssuedUsingLocalLicenseID,
                           this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            int DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref DriverID, ref IssuedUsingLocalLicenseID,
            ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))

                return new clsInternationalLicense(InternationalLicenseID, DriverID, IssuedUsingLocalLicenseID,
             IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            else
                return null;

        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExist(InternationalLicenseID);
        }



    }


}
