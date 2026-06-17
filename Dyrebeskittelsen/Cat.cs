namespace Dyrebeskittelsen;
public class Cat
{
    public string Name { get; private set; }
    public string Breed { get; private set; }
    public int Age { get; private set; }
    public bool AvailableForAdoption { get; private set; }

    public Nuka(string name)
    {
        Name = name;
    }

    public Miso(string name, string breed, int age, bool adoptable)
    {
        Name = name;
        Breed = breed;
        Age = age;
        AvailableForAdoption = adoptable;
    }
}