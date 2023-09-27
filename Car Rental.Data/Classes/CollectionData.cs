using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Classes;

public class CompanyData : IData
{
    List<IVehicle> _vehicles = new();
    List<Costumer> _costumers = new();
    List<Booking> _bookings = new();
    
    public CompanyData()
    {
        _vehicles.Add(new Car("ABC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatuses.Available));
        _vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatuses.Available));
        _vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatuses.Booked));
        _vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, VehicleStatuses.Available));
        _vehicles.Add(new Motorcycle("MNO345", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatuses.Available));
        _costumers.Add(new Costumer("Robin", "Klasson", "1991-11-02"));
        _costumers.Add(new Costumer("Frida", "Haraldsson", "1994-09-04"));
        _bookings.Add(new Booking("GHI789", "Robin Klasson (91-11-02)", 1000, null, "2023-09-23","", null, VehicleStatuses.Open));
        _bookings.Add(new Booking("ABC123", "Frida Haraldsson (94-09-04)", 9900, 10000, "2023-09-20", "2023-09-21", 300, VehicleStatuses.Closed));
    }
    public List<IVehicle> GetVehicles()
    {
        return _vehicles;
    }  
    public List<Costumer> GetCostumers()
    {
        return _costumers;
    }
    public List<Booking> GetBookings()
    {
        return _bookings;
    }
}

