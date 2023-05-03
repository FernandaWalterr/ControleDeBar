using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    internal class TelaCliente : TelaBase
    {
        private RepositorioCliente repositorioCliente;

        public TelaCliente(RepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public TelaCliente(RepositorioCliente repositorioCliente, ModuloGarcom.RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioCliente;
            nomeEntidade = "Cliente";
            sufixo = "s"; 
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Cliente cliente in registros)
            {
                Console.WriteLine(cliente.id);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite Numero da Mesa : ");
            string id = Console.ReadLine();

            Console.Write("Digite Nome Do Cliente : ");
            string nome = Console.ReadLine();

            Cliente cliente = new Cliente(id, nome);

            return cliente;
        }
    }
}