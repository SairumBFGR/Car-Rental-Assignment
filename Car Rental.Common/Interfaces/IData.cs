using Car_Rental.Common.Classes;

namespace Car_Rental.Common.Interfaces;

public interface IData
{
    List<IVehicle> GetVehicles();
    List<Costumer> GetCostumers();
    List<Booking> GetBookings();
}
