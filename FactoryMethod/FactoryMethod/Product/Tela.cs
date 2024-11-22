namespace FactoryMethod.Product;

public abstract class Tela(string backgroundColor, string messageText)
{
    protected string BackgroundColor { get; } = backgroundColor;

    public string GetMessageText() => messageText;
}