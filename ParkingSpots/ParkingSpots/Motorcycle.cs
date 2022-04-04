namespace ParkingSpots
{
    public class MotorCycle
    {
        public string Color { get; set; }
        public string LicencePlate { get; set; }
        public VehicleType VehicleType { get; }

        public MotorCycle()
        {
            VehicleType = VehicleType.Motorcycle;
        }
    }
}
