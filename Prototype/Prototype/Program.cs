using Prototype;

InimigoA inimigo1 = new();
inimigo1.Nome = "I1";
inimigo1.Cor = "Azul";
inimigo1.Arma = new Arma("Faca");

Inimigo inimigo2 = new InimigoA();
inimigo2 = inimigo1.DeepCopy();

inimigo1.Arma.Nome = "Espada";

Console.WriteLine("fim");