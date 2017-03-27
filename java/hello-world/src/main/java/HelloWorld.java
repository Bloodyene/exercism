public class HelloWorld {
    public static String hello(String text)
    {
        
        if (text == null || text.equals("")) {
            return "Hello, World!";
        }
        return "Hello, " + text +"!"; 
    }
}
