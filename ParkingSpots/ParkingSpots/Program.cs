// See https://aka.ms/new-console-template for more information
using ParkingSpots;

var redCar = new Car { Color = "Red", LicencePlate = "1234L" };
var blueCar = new Car { Color = "Blue", LicencePlate = "4567K" };
Console.WriteLine(redCar.Color + " car with licence plate " + redCar.LicencePlate);
Console.WriteLine(blueCar.Color + " car with licence plate " + blueCar.LicencePlate);
