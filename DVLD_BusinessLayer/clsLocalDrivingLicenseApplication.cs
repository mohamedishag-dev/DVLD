using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public clsApplication ApplicationInfo;
        public int LicenseClassID { set; get; }
        public clsLicenseClass LecenseClassInfo;

        public clsLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.ApplicationInfo = new clsApplication();
            this.LicenseClassID = -1;
            this.LecenseClassInfo = new clsLicenseClass();
            this.Mode = enMode.AddNew;
        }
        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindBaseApplication(this.ApplicationID);
            this.LicenseClassID = LicenseClassID;
            this.LecenseClassInfo = clsLicenseClass.Find(this.LicenseClassID);
            this.Mode = enMode.Update;
        }


        public static clsLocalDrivingLicenseApplication Find(int ApplicantPersonID, int LicenseClassID)
        {
            int ApplicationID = -1, LocalDrivingLicenseApplicationID = -1;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationIdAndLicenseClassID(ApplicantPersonID, LicenseClassID, ref ApplicationID, ref LocalDrivingLicenseApplicationID))

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }

        public static clsLocalDrivingLicenseApplication Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            else
                return null;
        }

        public static bool IsApplicationExist(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExistForApplicationIdAndLicenseClassID(ApplicantPersonID, LicenseClassID);
        }

        public static bool IsApplicationExist(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationData.IsLocalDrivingLicenseApplicationExistByID(LocalDrivingLicenseApplicationID);
        }

        public static bool CancelApplication(int LocalDrivingLicenseApplicationID)
        {

            clsApplication Application = Find(LocalDrivingLicenseApplicationID).ApplicationInfo;
            return Application.Cancel();

        }

        public static bool Delete(int LocalDrivingLicenseApplicationID)
        {
            clsApplication Application = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseApplicationID).ApplicationInfo;

            if (clsLocalDrivingLicenseApplicationData.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID))
            {
                return Application.Delete();
            }

            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationData.GetAllLocalDrivingLicenseApplication();

        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {

            if (IsApplicationExist(this.ApplicationInfo.ApplicantPersonID, this.LicenseClassID))
                return false;

            if (this.ApplicationInfo.Save())
            {
                ApplicationID = ApplicationInfo.ApplicationID;
                this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
                return (this.LocalDrivingLicenseApplicationID != -1);
            }
            else
                return false;

        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {

            return clsLocalDrivingLicenseApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID, this.ApplicationID, this.LicenseClassID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalDrivingLicenseApplication();

            }

            return false;
        }

    }

}
