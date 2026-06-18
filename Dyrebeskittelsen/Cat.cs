namespace Dyrebeskittelsen;
public class Cat
{
    public string Name { get; private set; }
    public string Breed { get; private set; }
    public int Age { get; private set; }
    public bool AvailableForAdoption { get; private set; }

    // public Cat(string name)
    // {
    //     Name = name;
    //     Breed = "boh";
    //     Age = 0;
    //     AvailableForAdoption = true;
    // }

    public Cat(string name, string breed = "Unknown", int age = 0)
    {
        Name = name;
        Breed = breed;
        Age = age;
        AvailableForAdoption = true;
    }

    public void Adopt()
    {
        AvailableForAdoption = false;
        Console.WriteLine($"{Name} has been adopted!");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, {Breed}, {Age}, {AvailableForAdoption}.");
    }
}