using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Classes
{
    public class Booking
    {
        public string regNo { get; set; }
        public string costumer { get; set; }
        public int kmRented { get; set; }
        public int? kmReturn { get; set; }
        public string rented { get; set; }
        public string? returned { get; set; }
        public int? cost { get; set; }
        public VehicleStatuses status { get; set; }

        public Booking(string regNoCon, string costumerCon, int kmRentedCon, int? kmReturnCon, string rentedCon, string? returnCon, int? costCon, VehicleStatuses statusCon)
        {
            regNo = regNoCon;
            costumer = costumerCon;
            kmRented = kmRentedCon;
            kmReturn = kmReturnCon;
            rented = rentedCon;
            returned = returnCon;
            cost = costCon;
            status = statusCon;
        }
    }
}
