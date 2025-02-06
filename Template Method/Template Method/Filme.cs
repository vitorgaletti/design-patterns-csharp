namespace Template_Method;

public class Filme(int id, string titulo, int ano, double avaliacao)
{
    public int Id { get; set; } = id;
    public string Titulo { get; set; } = titulo;
    public int Ano { get; set; } = ano;
    public double Avaliacao { get; set; } = avaliacao;
}