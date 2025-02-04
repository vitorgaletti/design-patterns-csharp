namespace Facade;

public class ReceitaFederalAPI
{
    public bool CPFAtivo(string CPF)
    {
        var random = new Random();
        var x = random.Next(0, 1).ToString();
        return x != "0";
    }
}