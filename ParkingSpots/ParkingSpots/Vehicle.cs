namespace ParkingSpots
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string LicencePlate { get; set; }
        public VehicleType VehicleType { get; }

        protected Vehicle(VehicleType vehicleType)
        {
            VehicleType = vehicleType;
        }

    }
}
