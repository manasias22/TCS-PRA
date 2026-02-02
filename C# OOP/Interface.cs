//Define a Interface : ILogger defines the contract: anything that implements this interface must have a Log(string message) method. 
public interface ILogger
{
    void Log(string message);
}
//Implment the Interface in different Classes
public class ConsoleLogger : ILogger
{
    public void Log(string message){
        Console.WriteLine($"Console Log: {message}");
    }
}
public class FileLogger : ILogger
{
    public void Log(string message){
        Console.WriteLine($"File Log: {message}");
    }
}
// Use the Interface in the Application Logic ; dependency inversion or loose coupling. 

public class ApplicationProcessor
{
    private readonly ILogger _logger;

    // Dependency Injection via constructor
    public ApplicationProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessData(string data)
    {
        // ... processing logic ...
        _logger.Log($"Processing data: {data}");
        // ... more logic ...
    }
}

// MAIN Program[Runtime Flexibility]
public class Program
{
    public static void Main(string[] args)
    {
        // Use the ConsoleLogger during development
        ILogger devLogger = new ConsoleLogger();
        ApplicationProcessor devApp = new ApplicationProcessor(devLogger);
        devApp.ProcessData("TestData_Dev");

        Console.WriteLine("\nSwitching to File Logger for production simulation...\n");

        // Use the FileLogger in a production environment
        ILogger prodLogger = new FileLogger();
        ApplicationProcessor prodApp = new ApplicationProcessor(prodLogger);
        prodApp.ProcessData("TestData_Prod");
    }
}

