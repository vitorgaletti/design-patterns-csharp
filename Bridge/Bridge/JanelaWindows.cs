namespace Bridge
{
    public class JanelaWindows : IJanelaBridge
    {
        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Windows");
        }

        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Windows");
        }
    }
}
