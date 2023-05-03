namespace ControleDeBar
{
    internal class ApresentarMenu
    {
        public string ApresentarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Opções");

            Console.WriteLine("Digite 1 para Mesa");
            Console.WriteLine("Digite 2 para Garçom");
            Console.WriteLine("Digite 3 para Produto");
            Console.WriteLine("Digite 4 para Contas");
            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}