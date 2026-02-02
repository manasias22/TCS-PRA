dynamic myVar = 100; // Type is integer at runtime
Console.WriteLine(myVar.GetType().Name); // Output: Int32

myVar = "Hello, C#!"; // Type changes to string at runtime
Console.WriteLine(myVar.GetType().Name); // Output: String

// This would compile fine, but crash at runtime if the object doesn't have a 'Show' method
// myVar.Show(); 
