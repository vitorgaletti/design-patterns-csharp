namespace ChainOfResponsability;

public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 0 and < 10)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");;
        }
        
        else if (succesor != null)
        {
            succesor.HandleRequest(request);
        }
    }
}

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 10 and < 20)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");;
        }
        
        else if (succesor != null)
        {
            succesor.HandleRequest(request);
        }
    }
}

public class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 20 and < 30)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");;
        }
        
        else if (succesor != null)
        {
            succesor.HandleRequest(request);
        }
    }
}