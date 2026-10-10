using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public clsLicense IssuedUsingLocalLicenseInfo { get; set; }
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
        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID,
            int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindBaseApplication(this.ApplicationID);
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.IssuedUsingLocalLicenseInfo = clsLicense.Find(IssuedUsingLocalLicenseID);
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
            this.InternationalLicenseID = clsInternationalLicenseData.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID,
                            this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);

        }

        public bool _UpdateInternationalLicense()
        {

            return clsInternationalLicenseData.UpdateInternationalLicense(this.InternationalLicenseID, this.DriverID, this.IssuedUsingLocalLicenseID,
                           this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);
        }

        public static clsInternationalLicense FindByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1, ApplicationID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByDriverID(DriverID, ref InternationalLicenseID, ref ApplicationID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
             IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            else
                return null;

        }

        public static clsInternationalLicense FindByID(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLocalLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicenseData.GetInternationalLicenseInfoByID(InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
             IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            else
                return null;

        }

        public static bool IsInternationalLicenseExist(int InternationalLicenseID)
        {
            return clsInternationalLicenseData.IsInternationalLicenseExistByID(InternationalLicenseID);
        }

        public static int GetActiveInternationalLicenseID(int LicenseID)
        {
            return clsInternationalLicenseData.GetActiveInternationalLicenseID(LicenseID);
        }

        public static DataTable GetAllInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses(DriverID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseData.GetAllInternationalLicenses();
        }

        public clsInternationalLicense IssueInternationalLicense(int LicenseID, int CreatedByUserID)
        {

            //First Create Application
            clsApplication Application = new clsApplication();
            Application.ApplicantPersonID = clsLicense.Find(LicenseID).DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find(Application.ApplicationTypeID).Fees;
            Application.CreatedByUserID = CreatedByUserID;

            if (!Application.Save())
            {
                return null;
            }


            this.ApplicationID = Application.ApplicationID;
            this.DriverID = clsLicense.Find(LicenseID).DriverID;
            this.IssueDate = DateTime.Now;
            this.IssuedUsingLocalLicenseID = LicenseID;
            this.ExpirationDate = DateTime.Now.AddYears(1);
            this.IsActive = true;
            this.CreatedByUserID = CreatedByUserID;

            DeactivateInternationalLicense();

            if (!this.Save())
            {
                return null;
            }

            return this;
        }

        public bool DeactivateInternationalLicense()
        {
            return clsInternationalLicenseData.DeactivateInternationalLicense(this.DriverID);
        }



    }
}