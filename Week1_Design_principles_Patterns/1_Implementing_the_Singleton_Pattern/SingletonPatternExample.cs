// Defines a class named Logger
public class Logger
{
    // Private static instance of the Logger class
    private static volatile Logger? instance;

    // Lock object to ensure thread safety
    private static readonly object obj = new object();

    // Private constructor to prevent external instantiation
    private Logger()
    {
        Console.WriteLine("Logger has been initialized.");
    }

    // Public static method to get the single instance of the Logger class
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (obj)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    // Method to log a message
    public void Log(string message)
    {
        Console.WriteLine($"Log message: {message}");
    }
}

// Test class to verify that only one instance of Logger is created
class Test
{
    public static void Main()
    {
        Logger firstLogger = Logger.GetInstance();
        firstLogger.Log("First login");

        Logger secondLogger = Logger.GetInstance();
        secondLogger.Log("Second login");

        Console.WriteLine($"Do firstLogger and secondLogger reference the same instance? " +
                          $"{object.ReferenceEquals(firstLogger, secondLogger)}");
    }
}
