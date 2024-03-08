using System;

// Base class
public class Animal
{
    // Method
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Derived class 1
public class Dog : Animal
{
    // Override method
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

// Derived class 2
public class Cat : Animal
{
    // Override method
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Animal, Dog, and Cat
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        // Call MakeSound method for each object
        animal.MakeSound(); // Output: The animal makes a sound
        dog.MakeSound();    // Output: The dog barks
        cat.MakeSound();    // Output: The cat meows
    }
}
