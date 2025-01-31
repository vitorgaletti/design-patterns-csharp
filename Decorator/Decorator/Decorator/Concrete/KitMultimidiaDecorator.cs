using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete;

public class KitMultimidiaDecorator(ICarro carro) : CarroDecorator(carro)
{
    public override string RetornarCarro()
    {
        return base.RetornarCarro() + " com Kit Multimidia";
    }
}