using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public float Fees { set; get; }

        public clsApplicationType()
        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
        }

        clsApplicationType(int ID, string Title, float Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = "";
            float Fees = 0;

            if (clsApplicationTypesData.GetApplicationTypeInfoByID(ID, ref Title, ref Fees))
                return new clsApplicationType(ID, Title, Fees);
            else
                return null;
        }

        public bool Save()
        {

            return (clsApplicationTypesData.UpdateApplicationType(this.ID, this.Title, this.Fees));

        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }

    }

}
