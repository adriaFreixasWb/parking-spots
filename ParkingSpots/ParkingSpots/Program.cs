// See https://aka.ms/new-console-template for more information
using ParkingSpots;
var carList = new List<Car>();

var redCar = new Car { Color = "Red", LicencePlate = "1234L" };
carList.Add(redCar);

var blueCar = new Car { Color = "Blue", LicencePlate = "4567K" };
carList.Add(blueCar);

Console.WriteLine(carList[0] + " car with licence plate " + redCar.LicencePlate);
Console.WriteLine(carList[1] + " car with licence plate " + blueCar.LicencePlate);
