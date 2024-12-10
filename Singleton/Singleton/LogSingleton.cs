namespace Singleton;

public class LogSingleton
{
    private static LogSingleton? Instancia;

    private LogSingleton()
    {
        
    }

    public static LogSingleton GetInstance
    {
        get { return Instancia ?? (Instancia = new()); }
    }

    public void Write(string message)
    {
        Console.WriteLine(message);
    }
}