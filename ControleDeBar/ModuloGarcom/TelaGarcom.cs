using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloGarcom;
using System.Collections;

public class TelaGarcom : TelaBase
{
    private RepositorioGarcom repositorioGarcom;

    public TelaGarcom(RepositorioGarcom repositorioGarcom)
    {
        this.repositorioGarcom = repositorioGarcom;
    }

    protected override void MostrarTabela(ArrayList registros)
    {
        throw new NotImplementedException();
    }

    protected override EntidadeBase ObterRegistro()
    {
        throw new NotImplementedException();
    }

    public class TelaGarcom : TelaBase
    {
        public TelaGarcom()
        {
            this.repositorioBase = repositorioBase;
        }
        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Garcom garcom in registros)
            {
                Console.WriteLine(garcom.id);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite Numero da Mesa : ");
            string id = Console.ReadLine();

            Garcom garcom = new Garcom(id);

            return garcom;
        }
    }
}