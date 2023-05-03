using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    public class RepositorioContas : RepositorioBase
    {
        public RepositorioContas(ArrayList listaContas)
        {
            this.listaRegistros = listaContas;
        }

        public override Contas SelecionarPorId(int id)
        {
            return (Contas)base.SelecionarPorId(id);
        }
    }
}