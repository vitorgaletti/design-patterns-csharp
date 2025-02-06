namespace Template_Method;

public abstract class OrdenadorTemplate
{
    public abstract bool IsPrimeiro(Filme filme1, Filme filme2);

    // Método de ordenação bolha (Bubble Sort)
    public List<Filme> OrdenarFilme(List<Filme> lista)
    {
        for(var i= 0; i< lista.Count; i++)
        {
            for(var j= i+1; j< lista.Count; j++)
            {
                if (IsPrimeiro(lista[i], lista[j])) continue;
                (lista[i], lista[j]) = (lista[j], lista[i]);
            }
        }

        return lista;
    }
}