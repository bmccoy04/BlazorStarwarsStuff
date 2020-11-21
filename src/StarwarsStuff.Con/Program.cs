using System.Collections.Generic;
using System.Linq;
using static System.Console;

//PrintName();
PrintCar();

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

    WriteLine(petTwo);

    WriteLine(Equals(petOne, petThree));
}

static void PrintCar()
{
    var carOne = new Car("Mustang", new WindShield(32, new Tire(21, "White")), new List<Tire> { new Tire(28, "Black") });

    var carTwo = carOne with 
    {
        Model = "Camero",
        WindShield = carOne.WindShield with
        {
            Tire = new Tire(5, "BLue")
        },
        Tires = new List<Tire> {carOne.Tires.FirstOrDefault(), new Tire(5, "white")}
    };

    WriteLine(carTwo.Model);
    WriteLine(carTwo.WindShield.Size);
    WriteLine(carTwo.WindShield.Tire.Color);
    WriteLine(carOne.WindShield.GetTireColor());
    WriteLine(carTwo.WindShield.GetTireColor());
    WriteLine(carTwo.Tires.FirstOrDefault().Color);
    WriteLine(carOne.TireCount());
    WriteLine(carTwo.TireCount());
}

class Person
{
    public string Name { get; init; }
}

record Car(string Model, WindShield WindShield, List<Tire> Tires)
{
    public int TireCount()
    {
        return Tires.Count; 
    }
}

record Tire(int Size, string Color);

record WindShield(int Size, Tire Tire)
{
    public string GetTireColor()
    {
        return Tire.Color; 
    }
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
