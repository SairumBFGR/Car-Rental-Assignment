using Car_Rental.Common.Classes;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Buisness.Classes;

public class Buisness
{
    IData _data;

    public Buisness(IData data)
    {
        _data = data;
    }

    public List<IVehicle> GetVehicles()
    {
        return _data.GetVehicles();
    }
    public List<Costumer> GetCostumers()
    {
        return _data.GetCostumers();
    }
    public List<Booking> GetBookings()
    {
        return _data.GetBookings();
    }
}