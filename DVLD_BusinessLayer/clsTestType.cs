using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsTestType
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }
        public enTestType ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public float Fees { set; get; }

        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;
        }

        clsTestType(enTestType ID, string TestTypeTitle, string Description, float Fees)
        {
            this.ID = ID;
            this.Title = TestTypeTitle;
            this.Description = Description;
            this.Fees = Fees;
        }

        public static clsTestType Find(enTestType ID)
        {
            string ApplicationTypeTitle = "", TestTypeDescription = "";
            float ApplicationFees = 0;

            if (clsTestTypeData.GetTestTypeInfoByID((int)ID, ref ApplicationTypeTitle, ref TestTypeDescription, ref ApplicationFees))
                return new clsTestType(ID, ApplicationTypeTitle, TestTypeDescription, ApplicationFees);
            else
                return null;
        }

        public bool Save()
        {

            if (clsTestTypeData.UpdateTestType((int)this.ID, this.Title, this.Description, this.Fees))
                return true;
            else
                return false;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

    }

}
