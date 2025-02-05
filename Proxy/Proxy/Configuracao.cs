namespace Proxy;

public class Configuracao : IConfiguracao
{
    public void Inicializar()
    {
        Console.WriteLine("Configuração inicializadas");
    }

    public void Atualizar()
    {
        Console.WriteLine("Configuração atualizadas");
    }

    public void SetConfig(string key, string value)
    {
        Console.WriteLine($"configurações registradas => {key}:{value}");
    }

    public string GetConfig(string key)
    {
        Random random = new();
        return $"valor da configuração {key} é : {random.NextInt64()}";
    }
}