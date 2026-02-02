//Method Overloading(Static Binding)
public class Calculator
{
    public int Add(int a, int b) => a + b; // Method 1: two int parameters
    public double Add(double a, double b) => a + b; // Method 2: two double parameters
    public int Add(int a, int b, int c) => a + b + c; // Method 3: three int parameters
}

// The compiler knows which Add method to call based on the arguments provided.



//Method Overriding(Dynamic Binding)

public class Animal
{
    // Base class method marked as virtual to allow overriding
    //Virtual keyword: If we use Virtual keyword, then we tell to compiler that this method can be overridden by the derived classes.
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Dog : Animal
{
    // Derived class method overrides the base class implementation
    //Override keyword: If we use Overrride keyword, then we tell to the compiler that this method is overriding the same named method in the base class.
    public override void MakeSound()
    {
        //Base keyword: If we use base keyword, then we tell to the compiler that this method calls the base class method for overriding functionality.
        
        base.MakeSound();
        Console.WriteLine("Bark!");
    }
}

public class Cat : Animal
{
    // Another derived class with its own override
    //Override keyword: If we use Overrride keyword, then we tell to the compiler that this method is overriding the same named method in the base class.
    public override void MakeSound()
    {
        //Base keyword: If we use base keyword, then we tell to the compiler that this method calls the base class method for overriding functionality.
        
        base.MakeSound();
        Console.WriteLine("Meow!");
    }
}

class Solution{
    public static void Main(string[] args){

        Animal myDog = new Dog(); // A Dog object treated as an Animal
        Animal myCat = new Cat(); // A Cat object treated as an Animal
        myDog.MakeSound(); // Outputs "Bark!" (runtime decides which method to call)
        myCat.MakeSound(); // Outputs "Meow!"
    }
}