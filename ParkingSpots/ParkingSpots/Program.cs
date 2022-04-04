// See https://aka.ms/new-console-template for more information
using ParkingSpots;

var carList = new List<Car>();

var redCar = new Car { Color = "Red", LicencePlate = "1234L" };
carList.Add(redCar);

var blueCar = new Car { Color = "Blue", LicencePlate = "4567K" };
carList.Add(blueCar);

for (int i = 0; i < carList.Count; i++)
{
    Console.WriteLine(carList[i] + " car with licence plate " + carList[i].LicencePlate);
}

var motorcycleList = new List<MotorCycle>();
motorcycleList.Add(new MotorCycle { Color = "Yellow", LicencePlate = "A-1357" });
motorcycleList.Add(new MotorCycle { Color = "Green", LicencePlate = "B-2468" });

for (int i = 0; i < motorcycleList.Count; i++)
{
    Console.WriteLine(motorcycleList[i] + " car with licence plate " + motorcycleList[i]);
}