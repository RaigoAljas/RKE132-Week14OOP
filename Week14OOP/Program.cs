Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
//Dog myDog = new Dog("Good Boy");
//myDog._name = "Good boy";

Dog neighboursDog = new Dog("Good Girl");
//neighboursDog._name = "Good girl";

Console.WriteLine($"My dogs name is {myDog.Name}. ");
//Console.WriteLine($"My dogs name is {myDog. _name}. ");

Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}. ");
//Console.WriteLine($"My neighbours dogs name is {neighboursDog. _name}. ");

myDog.Rename("Bad Boy");
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

//myDog.Bark();
//Console.WriteLine($"Level of happiness: {myDog.LevelOfHapiness}");

while(myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}
myDog.WagTail();


class Dog
{
    private string _name;  //field
    private int _levelOfHapiness;
    //public string _name = "Koer";
    //public int _levelOfHapiness = 0;


    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }
        public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}


