namespace Template_Method;

public class OrdenadorPorAvaliacao : OrdenadorTemplate
{
    public override bool IsPrimeiro(Filme filme1, Filme filme2)
    {
        return filme1.Avaliacao > filme2.Avaliacao;
    }
}