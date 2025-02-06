namespace Template_Method;

public class OrdenadorPorTitulo : OrdenadorTemplate
{
    public override bool IsPrimeiro(Filme filme1, Filme filme2)
    {
        return string.Compare(filme1.Titulo, filme2.Titulo, StringComparison.Ordinal) <= 0;
    }
}