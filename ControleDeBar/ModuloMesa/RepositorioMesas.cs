using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
        public class ControleBar : RepositorioBase 
        {
        public ControleBar(ArrayList listaMesas)
        {
            this.listaRegistros = listaMesas;
        }

        public override Mesa SelecionarPorId(int id)
        {
            return (Mesa)base.SelecionarPorId(id);
        }
    }
}