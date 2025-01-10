namespace Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaBridge janela;

        public JanelaAbstrata(IJanelaBridge j)
        {
            janela = j;
        }

        public void DesenharJanela(string titulo)
        {
            Console.WriteLine("Desenhando janela...");
            janela.DesenharJanela(titulo);
        }
        public void DesenharBotao(string titulo)
        {
            janela.DesenharBotao(titulo);
        }
        public abstract void Desenhar();
    }
}
