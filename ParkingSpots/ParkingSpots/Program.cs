// See https://aka.ms/new-console-template for more information
using ParkingSpots;

var vehicleList = new List<Vehicle>();
vehicleList.Add(new Car { Color = "Red", LicencePlate = "1234L" });
vehicleList.Add(new Car { Color = "Blue", LicencePlate = "4567K" });
vehicleList.Add(new MotorCycle { Color = "Yellow", LicencePlate = "A-1357" });
vehicleList.Add(new MotorCycle { Color = "Green", LicencePlate = "B-2468" });


for (int i = 0; i < vehicleList.Count; i++)
{
    Console.WriteLine(vehicleList[i].Color + " " + vehicleList[i].VehicleType + " with licence plate " + vehicleList[i].LicencePlate);
}
