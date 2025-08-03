namespace Lab5;


class Animal
{
    // Virtual method 
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}
// Step 2 Create Class: Cat
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

// Step 2 Create Class: Dog
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

// Step 2 Create Class: My own Class: Cow
class Cow : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cow says: moo moo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3 Test in Main

        //  Animal object reference
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();
        Animal myCow = new Cow();

        //  animalSound method on each object
        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
        myCow.animalSound();
    }
}

