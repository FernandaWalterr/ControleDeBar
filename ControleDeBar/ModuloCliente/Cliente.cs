using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    public class Cliente : EntidadeBase
    {

        public string Id;
        public string Nome;

        public Cliente(string id, string nome)
        {
            Id = id;
            Nome = Nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Cliente cliente = (Cliente)registroAtualizado;

            this.id = id;
            this.Nome = cliente.Nome;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
