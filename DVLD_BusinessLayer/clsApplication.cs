using DVLD_DataAccessLayer;
using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int ApplicantPersonID { set; get; }
        public clsPerson PersonInfo;
        public int ApplicationTypeID { set; get; }
        public clsApplicationType ApplicationTypeInfo;
        public DateTime ApplicationDate { set; get; }
        public byte Status { set; get; }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUser;
        public clsApplication()
        {
            this.ID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.Status = 1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            this.Mode = enMode.AddNew;
        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
             byte ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);

            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);

            this.Status = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUser = clsUser.Find(CreatedByUserID);
            this.Mode = enMode.Update;
        }

        public static clsApplication Find(int ApplicationID)
        {
            float PaidFees = 0;
            byte ApplicationStatus = 1; 
            int ApplicantPersonID = -1, CreatedByUserID = -1, ApplicationTypeID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;

            if (clsApplicationData.GetApplicationInfoByID(ApplicationID,  ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus, 
                ref LastStatusDate, ref PaidFees,  ref CreatedByUserID))

                return new clsApplication(ApplicationID, ApplicantPersonID,ApplicationDate, ApplicationTypeID, 
                      ApplicationStatus, LastStatusDate, PaidFees,  CreatedByUserID);
            else
                return null;
        }

        private bool _AddNewApplication()
        {

            this.ID = clsApplicationData.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.Status, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ID != -1);

        }

        private bool _UpdateApplication()
        {

            return clsApplicationData.UpdateApplication(this.ID, this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,
                this.Status, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }

            return false;
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationData.IsApplicationExistByID(ApplicationID);
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationData.DeleteApplicationByID(ApplicationID);
        }

        public static bool CancelApplication(int ApplicationID)
        {
            clsApplication application = Find(ApplicationID);

            if (application != null)
            {
                application.Status = 2;
                application.LastStatusDate = DateTime.Now;
                if (application.Save())
                    return true;
            }

            return false;
        }
    
    }

}
