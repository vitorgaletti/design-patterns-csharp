namespace Decorator.Decorator.Base;

// Decorator (Base)

public class CarroDecorator(ICarro carro) : ICarro
{
    public virtual string RetornarCarro()
    {
        return carro.RetornarCarro();
    }
}