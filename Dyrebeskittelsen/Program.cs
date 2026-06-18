using Dyrebeskittelsen;

Cat c1 = new Cat("Nuka", "Tuxedo", 2);
Cat c2 = new Cat("Luna");
Cat c3 = new Cat("Miso", "Orange");

// Console.WriteLine($"{c1.Name}, {c1.Breed}, {c1.Age}");
// Console.WriteLine($"{c2.Name}");
// Console.WriteLine($"{c3.Name}, {c3.Breed}");

c1.PrintInfo();
c2.PrintInfo();
c3.PrintInfo();

c1.Adopt();

c1.PrintInfo();