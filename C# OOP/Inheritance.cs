//Single Inheritance
public class Animal // Base class
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Dog : Animal // Derived class
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}
class Solution{
    public static void Main(string[] args){
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Bark();
    }
}


//Multilevel Inheritance
public class Animal // Grandparent class
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Dog : Animal // Parent class (inherits from Animal)
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

public class Poodle : Dog // Child class (inherits from Dog, and thus Animal)
{
    public void DoTrick()
    {
        Console.WriteLine("The poodle is doing a trick.");
    }
}

// Usage:
// Poodle myPoodle = new Poodle();
// myPoodle.Eat(); 
// myPoodle.Bark(); 
// myPoodle.DoTrick();



//Multiple Inheritance
public interface ISwimmer
{
    void Swim();
}

public interface IRunner
{
    void Run();
}

public class Duck : ISwimmer, IRunner // Inherits from two interfaces
{
    public void Swim()
    {
        Console.WriteLine("The duck is swimming.");
    }

    public void Run()
    {
        Console.WriteLine("The duck is running.");
    }
}

// Usage:
// Duck myDuck = new Duck();
// myDuck.Swim();
// myDuck.Run();



//Hierarchial Inheriatnce
public class Animal // Base class
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Cat : Animal // Derived class 1
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing.");
    }
}

public class Horse : Animal // Derived class 2
{
    public void Neigh()
    {
        Console.WriteLine("The horse is neighing.");
    }
}

// Usage:
// Cat myCat = new Cat();
// myCat.Eat();
// Horse myHorse = new Horse();
// myHorse.Eat();



//Hybrid Inheritance
public class Animal // Base class
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Cat : Animal // Derived class 1
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing.");
    }
}

public class Horse : Animal // Derived class 2
{
    public void Neigh()
    {
        Console.WriteLine("The horse is neighing.");
    }
}

// Usage:
// Cat myCat = new Cat();
// myCat.Eat();
// Horse myHorse = new Horse();
// myHorse.Eat();

