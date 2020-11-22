using System.Collections.Generic;
using System.Linq;
using static System.Console;

//PrintName();
//PrintCar();
PrintIsEqual();

static void PrintName()
{
    var p = new Person { Name = "Bryan" };

    Pet petOne = new Dog { Name = "Jack" };

    var petTwo = petOne with
    {
        Name = "Sally"
    };

    var petThree = petOne with
    {
        Name = "Jack"
    };

    var a = new Animal("Cat");

    var someAnimal = new Something("Cat", "Dog");

    var (cat, dog) = someAnimal;

    //p.Name = "James"; doesn't work now

    WriteLine("Hello: " + p.Name);

    WriteLine(cat, dog);

    WriteLine(petTwo);

    WriteLine(Equals(petOne, petThree));
}

static void PrintIsEqual()
{
    var myMustang = new Car("Mustang", new Owner("Bryan"));

    var myCamaro = myMustang with
    {
        Model = "Camaro"
    };

    WriteLine(Equals(myMustang, myCamaro)); //This will print false

    var myNewMustang = myCamaro with
    {
        Model = "Mustang"
    };

    WriteLine(Equals(myNewMustang, myCamaro)); //this will print false


    WriteLine(Equals(myNewMustang, myMustang)); //this will print true

    var (model, owner) = myNewMustang;

    WriteLine(owner); // this will print the owner's properties 
    WriteLine(model); // this will print the model
}

static void PrintCar()
{
    var myCar = new Car("Mustang", new Owner("Bryan"));

    WriteLine(myCar);
}

record Car(string Model, Owner Owner) : Vehicle(Model);

record Owner(string Name);

record Vehicle(string Model);

//record Car : Vehicle
//{
//    public Owner Owner { get; init; }
//}

//record Owner
//{
//    public string Name { get; init; }
//}

//record Vehicle
//{
//    public string Model { get; init; }
//}

class Person
{
    public string Name { get; init; }
}


// a class that has value like behavior
record Animal(string Type);

record Something(string Type, string Name) : Animal(Type);

record Pet
{ 
    public string Name { get; init; }

    public Person Owner { get; init; }

    public bool GetName()
    {
        return true; 
    }
}


record Dog : Pet
{
    public bool Barks { get; set; }
}
