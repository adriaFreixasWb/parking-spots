# parking-spots
Application that manages parking spots

For a hello world tutorial use [Microsoft's net 5 learn](https://dotnet.microsoft.com/en-us/learn/dotnet/hello-world-tutorial/intro)

## 01-Car printing
We need to bulid an application that can create cars
* Red car with licence plate 1234L
* Blue car with licence plate 4567K
The application must print all created cars.

## 02-Create cars with their own feature
Let's create a class car with properties:
* Color 
* Licence plate

And use the information for the cars on step 1

## 03-Add cars to a list

A list is a collection of that of a unique type.
In our example we have a List of type car 

```
var carList = new List<Car>();
```

List have numbered positions starting for 0, there for our **first item** is carList[0] and our **second item** is carList[1].

At this exercise we are going to add our created cars from step 2 into a car collection called carList.
Once we are done cars features will be printed accessing our list by car index;

## 04-For loop to print cars

Loops are iterative structures, this very feature makes them ideal to look through all positions of a list.
For loops have a starting point, a maximum number and an increment, the following has:
* i is set as 0 to start
* will increase as far as i is lower that max
* i++ means increment 1 per cycle

```
for(int i = 0; i < max; i++)
```

For this exercise we will loop through the List created a step 4 and print each car feature

## 05-Motorcicle features
As we did in step 2 let's create a motorcycle object, then:
* Create a couple of instances
* Save those instances to a list
* Loop through motorcycle list and print its features

## 06-Vehicle type enumeration

Up until now we set every property on a class from outside, but it is time to start setting properties from inside.
There is no better way to do that than creating a  [read only property](https://docs.microsoft.com/en-us/dotnet/csharp/properties#read-only). To that end let's use the [constructor](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors) to create a [Enumeration](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(enum_CSharpKeyword);k(DevLang-csharp)%26rd%3Dtrue) that depicts vehicle type for our read only property

# Parking exercise

From this point on we are going to base our exercises on the fames [Parking spot Object oriented princials test](https://www.geeksforgeeks.org/design-parking-lot-using-object-oriented-principles/).
We are going to aim for a simplified form.

## 07-Vehicle parent class

We have code duplicated on Car and Motorcycle classes, let's remove it by creating a [parent class](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/classes#14242-base-classes)
A parent class is a type of abstraction that to share code between objects.

The new feature is going to be add a Vehicle type, to the parent class, so all vehicles can be kept in a single list
