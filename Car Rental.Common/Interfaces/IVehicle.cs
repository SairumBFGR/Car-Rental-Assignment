using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    public string regNo { get; set; }
    public string make { get; set; }
    public int odometer { get; set; }
    public double costKm { get; set; }
    public VehicleTypes type { get; set; }
    public double costday { get; set; }
    public VehicleStatuses status { get; set; }
}
