using AbstractFactory.Product;

namespace AbstractFactory.Factory;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}