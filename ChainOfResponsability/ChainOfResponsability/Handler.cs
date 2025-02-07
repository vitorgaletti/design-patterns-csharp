namespace ChainOfResponsability;

public abstract class Handler
{
    protected Handler succesor;
    
    public void SetSuccessor(Handler succesor)
    {
        this.succesor = succesor;
    }
    
    public abstract void HandleRequest(int request);
}