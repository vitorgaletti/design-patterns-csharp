using Template_Method;

var filme1 = new Filme(1, "Titanic", 1997, 4.9);
var filme2 = new Filme(2, "Click", 2006, 4.7);
var filme3 = new Filme(3, "Náufrago", 2000, 4.8);
var filme4 = new Filme(4, "Invencível", 2014, 5);
var filme5 = new Filme(5, "O Grande Dragão Branco", 1988, 4.6);

List<Filme> lista =
[
    filme1,
    filme2,
    filme3,
    filme4,
    filme5
];

OrdenadorTemplate ordenador;

ordenador = new OrdenadorPorAvaliacao();
var estoque = ordenador.OrdenarFilme(lista);

foreach (var item in estoque)
{
    Console.WriteLine(item.Id + " - " + item.Titulo + " (" + item.Ano + ") => " + item.Avaliacao);
}
