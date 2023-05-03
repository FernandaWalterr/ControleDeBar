using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    internal class RepositorioCliente : RepositorioBase
    {
        public RepositorioCliente(ArrayList listaGarcom) => this.listaRegistros = listaRegistros;

        public override Cliente SelecionarPorId(int id)
        {
            return (Cliente)base.SelecionarPorId(id);
        }
    }
}