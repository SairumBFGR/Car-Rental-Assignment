
namespace Car_Rental.Common.Classes
{
    public class Costumer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string ssc { get; set; }

        public Costumer(string firstNameCon, string lastNameCon, string sscCon)
        {
            firstName = firstNameCon;
            lastName = lastNameCon;
            ssc = sscCon;
        }
    }
}
