using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete;

public class BancoCouroDecorator(ICarro carro) : CarroDecorator(carro)
{
    public override string RetornarCarro()
    {
        return base.RetornarCarro() + " com Banco de Couro";
    }
}