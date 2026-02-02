using System;

public abstract class Animal
{
    //Abstarct method (no body); forces derived classes to define their sound
    public abstract void makesound();

    //Non-Abstract method (with body) - common functionality for all animals
    public void eat()
    {
        Console.WriteLine("Is eating bone");
    }

}

public class Dog : Animal
{
//// Must override the abstract method
    public override void makesound()
    {
        Console.WriteLine("Bhauu");
    }
}

class Solution
{
    public static void Main(string[] args){
    Animal mydog = new Dog();
    mydog.makesound();
    mydog.eat();

}
}