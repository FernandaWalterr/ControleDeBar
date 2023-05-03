using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    public class RepositorioProduto : RepositorioBase
    {
        public RepositorioProduto(ArrayList listaProdutos)
        {
            this.listaRegistros = listaProdutos;
        }

        public override Produto SelecionarPorId(int id)
        {
            return (Produto)base.SelecionarPorId(id);
        }
    }
}