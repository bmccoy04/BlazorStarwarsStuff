using static System.Console;

PrintName();

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
