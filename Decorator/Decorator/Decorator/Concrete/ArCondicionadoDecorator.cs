using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete;

public class ArCondicionadoDecorator(ICarro carro) : CarroDecorator(carro)
{
    public override string RetornarCarro()
    {
        return base.RetornarCarro() + " com Ar Condicionado";
    }
    
}