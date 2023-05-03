using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Cliente;
        public string Id;
        private string? id1;

        public Garcom(string id, string? quantidadeLugares)
        {
            Id = id;
        }

        public Garcom(string? id1)
        {
            this.id1 = id1;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcom = (Garcom)registroAtualizado;
            this.Cliente = Cliente;
            this.id = id;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}