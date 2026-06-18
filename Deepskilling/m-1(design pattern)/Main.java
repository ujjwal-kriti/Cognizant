public class Main {

    public static void main(String[] args) {

        Logger logger1 = Logger.getInstance();

        Logger logger2 = Logger.getInstance();

        logger1.log("First Message");

        logger2.log("Second Message");

        // Checks if both references point to same object
        System.out.println(logger1 == logger2);
    }
}