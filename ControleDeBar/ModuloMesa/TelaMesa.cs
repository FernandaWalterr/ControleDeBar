using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloMesas;
using System.Collections;

namespace ControleDeBar
{
    public class TelaMesa : TelaBase
    {
        private object numeroMesa;
        private RepositorioMesa repositorioMesa;

        public TelaMesa(ControleBar repositorioMesa)
        {
            repositorioBase = repositorioMesa;
            nomeEntidade = "Mesas";
            sufixo = "as";
        }

        public TelaMesa(RepositorioMesa repositorioMesa) => this.repositorioMesa = repositorioMesa;

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "CPF");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}",
                                  numeroMesa.id,
                                  numeroMesa.numero);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Numero da mesa: ");
            string numeroMesa = Console.ReadLine();

            Console.Write("Quantidade de lugares: ");
            string quantidadeLugares = Console.ReadLine();

            return new Garcom(numeroMesa, quantidadeLugares);
        }
    }
}
