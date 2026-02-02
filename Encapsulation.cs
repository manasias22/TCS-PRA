public class Person
{
    // Private field: not directly accessible from outside
    private string name;

    // Private field: store age
    private int age;

/*
Setting up the getters and setters
    public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
*/

    // Public property: provides controlled access to _name
    public string Name
    {
        get { 
            return name; 
            }
        set
        {
            // We can add validation logic here
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Invalid name. Name cannot be empty.");
            }
        }
    }
    
    // Public property: provides controlled access to _age
    public int Age
    {
        get { return age; }
        set
        {
            // Make sure age is valid
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age must be between 0 and 120.");
            }
        }
    }

    // Constructor to initialize Person
    public Person(string name, int age)
    {
        Name = name; // Using the property instead of directly setting name
        Age = age;   // Using the property instead of directly setting age
    }
}
public class Program
{
    public static void Main()
    {
        Person person = new Person("Alice", 25);

        // Accessing the 'Name' property
        Console.WriteLine("Name: " + person.Name);
        
        // Setting a valid age
        person.Age = 30; 
        Console.WriteLine("Age: " + person.Age);

        // Trying to set an invalid age
        person.Age = 200; // Will show a validation message instead
    }
}
