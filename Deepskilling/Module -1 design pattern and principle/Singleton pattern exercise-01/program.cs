class Program
{
    static void Main(string[] args)
    {
        // Get first Logger object
        Logger logger1 = Logger.GetInstance();

        // Get second Logger object
        Logger logger2 = Logger.GetInstance();

        logger1.Log("First Message");
        logger2.Log("Second Message");

        // Checks whether both references point
        // to the same object
        Console.WriteLine(logger1 == logger2);
    }
}