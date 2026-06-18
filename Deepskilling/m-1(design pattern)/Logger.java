public class Logger {

    // Stores the single Logger object
    private static Logger instance;

    // Private constructor
    // Prevents object creation using new Logger()
    private Logger() {
        System.out.println("Logger Created");
    }

    // Returns the same Logger object every time
    public static Logger getInstance() {

        if (instance == null) {
            instance = new Logger();
        }

        return instance;
    }

    public void log(String message) {
        System.out.println("LOG: " + message);
    }
}