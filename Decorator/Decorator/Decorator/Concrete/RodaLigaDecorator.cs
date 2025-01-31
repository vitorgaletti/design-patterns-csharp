using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete;

public class RodaLigaDecorator(ICarro carro) : CarroDecorator(carro)
{
    public override string RetornarCarro()
    {
        return base.RetornarCarro() + " com Roda de Liga Leve";
    }
}