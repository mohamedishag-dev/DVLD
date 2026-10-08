using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsLicense
    {

        public enMode Mode = enMode.AddNew;
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementforDamaged = 3, ReplacementforLost = 4 };

        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public clsApplication ApplicationInfo;
        public int DriverID { set; get; }
        public clsDriver DriverInfo;
        public int LicenseClassID { set; get; }
        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public float PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
        public string IssueReasonText
        {
            get
            {

                switch (IssueReason)
                {
                    case enIssueReason.FirstTime:
                        return "First Time";
                    case enIssueReason.Renew:
                        return "Renew";
                    case enIssueReason.ReplacementforDamaged:
                        return "Replacement for Damaged";
                    case enIssueReason.ReplacementforLost:
                        return "Replacement for Lost.";
                    default:
                        return "First Time";
                }
            }

        }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo;

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.ApplicationInfo = new clsApplication();
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
            this.CreatedByUserID = -1;
            this.CreatedByUserInfo = new clsUser();

            this.Mode = enMode.AddNew;
        }

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
              bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindBaseApplication(ApplicationID);
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
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);

            this.Mode = enMode.Update;
        }

        public static clsLicense Find(int LicenseID)
        {
            string Notes = "";
            float PaidFees = 0;
            byte IssueReason = 0;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            int DriverID = -1, ApplicationID = -1, LicenseClass = -1, CreatedByUserID = -1;

            if (clsLicenseData.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate,
            ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                      Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

        public static clsLicense Find(string NationalNo, int LicenseClass)
        {
            string Notes = "";
            float PaidFees = 0;
            byte IssueReason = 0;
            bool IsActive = false;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            int LicenseID = -1, DriverID = -1, ApplicationID = -1, CreatedByUserID = -1;

            if (clsLicenseData.GetLicenseInfoByNationalNo(NationalNo, LicenseClass, ref LicenseID, ref ApplicationID, ref DriverID, ref IssueDate,
            ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,
                      Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

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
            ApplicationInfo = clsApplication.FindBaseApplication(ApplicationID);

            this.LicenseID = clsLicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            if (!ApplicationInfo.SetComplete())
                return false;

            return (this.LicenseID != -1);

        }

        private bool _UpdateLicense()
        {

            return clsLicenseData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

        }

        public bool Delete()
        {
            return clsLicenseData.DeleteLicenseByID(this.LicenseID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicenseData.IsLicenseExistByID(LicenseID);
        }

        public static DataTable GetAllLicensesForPersonID(int PersonID)
        {
            return clsLicenseData.GetAllLicensesForPersonID(PersonID);
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return clsLicenseData.IsLicenseExistByPersonID(PersonID, LicenseClassID);
        }

    }

}