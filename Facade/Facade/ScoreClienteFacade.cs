namespace Facade;

public class ScoreClienteFacade
{
    DetranAPI detran = new DetranAPI();
    SerasaAPI serasa = new SerasaAPI();
    ReceitaFederalAPI receita = new ReceitaFederalAPI();

    public double Score(string CPF, string CNH)
    {
        var cnhValida = detran.CNHValida(CNH);
        var scoreSerasa = serasa.Score(CPF);
        var cpfAtivo = receita.CPFAtivo(CPF);

        var scoreSerasa20p100 = scoreSerasa * 0.2;
        var scoreSerasa30p100 = scoreSerasa * 0.3;
        var score = scoreSerasa * 1.0;
        
        if (!cnhValida)
            score -= scoreSerasa20p100;

        if (!cpfAtivo)
            score -= scoreSerasa30p100;

        return score;
    }

    
}