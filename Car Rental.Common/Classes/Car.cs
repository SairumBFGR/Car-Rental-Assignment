using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string regNo { get; set; }
    public string make { get; set; }
    public int odometer { get; set; }
    public double costKm { get; set; }
    public VehicleTypes type { get; set; }
    public double costday { get; set; }
    public VehicleStatuses status { get; set; }

    public Car(string regNoCon, string makeCon, int odometerCon, double costKmCon, VehicleTypes typeCon, double costdayCon, VehicleStatuses statusCon)
    {
        regNo = regNoCon;
        make = makeCon;
        odometer = odometerCon;
        costKm = costKmCon;
        type = typeCon;
        costday = costdayCon;
        status = statusCon;
    }
}