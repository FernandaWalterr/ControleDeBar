using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    public class Mesa : EntidadeBase
    {
        public string numeroMesa;
        public int quantidadeLugares;
        private object garcomAtualizado;

        public Mesa(string numeroMesa, int quantidadeLugares)
        {
            this.numeroMesa = numeroMesa;
            this.quantidadeLugares = quantidadeLugares;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.numeroMesa = garcomAtualizado.nome;
            this.quantidadeLugares = garcomAtualizado.cpf;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}