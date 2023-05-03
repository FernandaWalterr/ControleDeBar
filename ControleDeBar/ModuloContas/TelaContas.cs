using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloMesas;
using System.Collections;


namespace ControleDeBar
{
    public class TelaContas : TelaBase
    {
        private RepositorioContas repositorioContas;
        private RepositorioGarcom repositorioGarcom;
        private ControleBar repositorioMesa; 
        private RepositorioProduto repositorioProduto; 

        private TelaGarcom telaGarcom;
        private TelaMesa telaMesa;
        private TelaProduto telaProduto;
        private RepositorioCliente repositorioCliente;
        private ControleBar repositorioMesas;
        private TelaMesa telaMesas;
        private TelaCliente telaCliente;
        private ControleBar repositorioMesas1;
        private ControleBar repositorioMesas2;
        private ControleBar repositorioMesas3;
        private RepositorioMesa repositorioMesas4;

        public TelaContas(RepositorioContas repositorioContas, RepositorioProduto repositorioProduto, ControleBar repositorioMesa,
            RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaProduto telaProduto)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioProduto = repositorioProduto;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas; 
            this.telaProduto = telaProduto;
        }

        public TelaContas(RepositorioContas repositorioContas, RepositorioCliente repositorioCliente, ControleBar repositorioMesas, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaCliente telaCliente)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMesas = repositorioMesas;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas;
            this.telaCliente = telaCliente;
        }

        public TelaContas(RepositorioContas repositorioContas, RepositorioCliente repositorioCliente, ControleBar repositorioMesas1, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaCliente telaCliente)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMesas1 = repositorioMesas1;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas;
            this.telaCliente = telaCliente;
        }

        public TelaContas(RepositorioContas repositorioContas, RepositorioCliente repositorioCliente, ControleBar repositorioMesas2, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaCliente telaCliente)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMesas2 = repositorioMesas2;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas;
            this.telaCliente = telaCliente;
        }

        public TelaContas(RepositorioContas repositorioContas, RepositorioCliente repositorioCliente, ControleBar repositorioMesas3, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaCliente telaCliente)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMesas3 = repositorioMesas3;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas;
            this.telaCliente = telaCliente;
        }

        public TelaContas(RepositorioContas repositorioContas, RepositorioCliente repositorioCliente, RepositorioMesa repositorioMesas4, RepositorioGarcom repositorioGarcom, TelaGarcom telaGarcom, TelaMesa telaMesas, TelaCliente telaCliente)
        {
            this.repositorioContas = repositorioContas;
            this.repositorioCliente = repositorioCliente;
            this.repositorioMesas4 = repositorioMesas4;
            this.repositorioGarcom = repositorioGarcom;
            this.telaGarcom = telaGarcom;
            this.telaMesas = telaMesas;
            this.telaCliente = telaCliente;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Número", "Mesa", "Garçom", "Produto", "Quantidade", "Valor");

            Console.WriteLine("------------------------------------------------------------------------------------------------");

            foreach (Contas contas in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", contas.id, contas.numero, contas.mesa.numero, contas.garcom.nome, contas.produto.nome, contas.produto.quantidade, contas.produto.valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o numero da Conta: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Produto produto = ObterProduto();

            Mesa mesa = ObterMesa();

            Garcom garcom = ObterGarcom();

            Console.Write("Digite a data: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());



            return new Contas(numero, mesa, produto, garcom, data);
        }
        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do funcionário: ");

            Console.WriteLine();

            return produto;
        }

        private Mesa ObterMesa()
        {
            telaMesas.VisualizarRegistros(false); 

            Mesa mesa = (Mesa)telaMesas.EncontrarRegistro("Digite o id da mesa: "); 

            Console.WriteLine();

            return mesa;
        }
        private Garcom ObterGarcom()
        {
            telaGarcom.VisualizarRegistros(false);

            Garcom garcom = (Garcom)telaGarcom.EncontrarRegistro("Digite o id do Garçom: ");

            Console.WriteLine();

            return garcom;
        }
    }
}