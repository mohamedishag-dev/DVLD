using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        public int LecenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public int MinimumAllowedAge { set; get; }
        public int DefaultValidityLength { set; get; }
        public float ClassFees { set; get; }

        public clsLicenseClass()
        {
            this.LecenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
        }

        clsLicenseClass(int LecenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, float ClassFees)
        {
            this.LecenseClassID = LecenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClass Find(int LecenseClassID)
        {
            float ClassFees = 0;
            string ClassName = "", ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;

            if (clsLecenseClassData.GetLecenseClassInfoByID(LecenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClass(LecenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        public static clsLicenseClass Find(string ClassName)
        {
            float ClassFees = 0;
            int LecenseClassID = -1;
            string ClassDescription = "";
            byte MinimumAllowedAge = 0, DefaultValidityLength = 0;

            if (clsLecenseClassData.GetLecenseClassInfoByClassName(ClassName, ref LecenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClass(LecenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        public static DataTable GetAllLecenseClasss()
        {
            return clsLecenseClassData.GetAllLicenseClasses();
        }


    }

}

