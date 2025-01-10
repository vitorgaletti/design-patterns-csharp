namespace Bridge
{
    public class JanelaLinux : IJanelaBridge
    {
        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Linux");
        }

        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Linux");
        }
    }
}
