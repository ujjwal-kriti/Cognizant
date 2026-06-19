// Singleton Class

public class Logger
{
    // Stores the single object
    private static Logger instance;

    // Private constructor
    // Prevents object creation using new Logger()
    private Logger()
    {
        Console.WriteLine("Logger Created");
    }

    // Returns the same object every time
    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("LOG: " + message);
    }
}