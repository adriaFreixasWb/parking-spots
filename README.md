# parking-spots
Application that manages parking spots

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

# Parking exercise

From this point on we are going to base our exercises on the fames [Parking spot Object oriented princials test](https://www.geeksforgeeks.org/design-parking-lot-using-object-oriented-principles/).
We are going to aim for a simplified form.

## 06-Vehicle parent class

Since Car and Motorcycle classes are similiar, let's create a parent class holding the methods.
A parent class is a type of abstraction that let's you share code between objects.

The new feature is going to be add a Vehicle type, to the parent class.
Now from the constructor we will set them
