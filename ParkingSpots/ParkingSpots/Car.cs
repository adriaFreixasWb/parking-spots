namespace ParkingSpots
{
    public class Car
    {
        public string Color { get; set; }
        public string LicencePlate { get; set; }
        public VehicleType VehicleType { get; }

        public Car()
        {
            VehicleType = VehicleType.Car;
        }
    }
}
