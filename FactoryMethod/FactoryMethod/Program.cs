using FactoryMethod.Creator;
using FactoryMethod.Product;

var tela1 = new ConcreteTelaWebCreator().CriaTela();
var tela2 = new ConcreteTelaSmartphoneCreator().CriaTela();
var tela3 = new ConcreteTelaSmartwatchCreator().CriaTela();
var tela4 = new ConcreteTelaSmarttvCreator().CriaTela();

Console.WriteLine("TELA WEB => " + tela1.GetMessageText());
Console.WriteLine("TELA SMARTPHONE => " + tela2.GetMessageText());
Console.WriteLine("TELA SMARTWATCH => " + tela3.GetMessageText());
Console.WriteLine("TELA SMARTTV => " + tela4.GetMessageText());

/*
 * Factory Method
 *
 * Definir uma interface para criar um objeto
 * mas deixar as subclasses decidirem que classe instanciar.
 * O Factory Method permite adiar a instaciação para subclasses
 */