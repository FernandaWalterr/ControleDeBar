using ControleDeBar.ModuloGarcom;
using ControleDeBar;
using System.Collections;
using ControleDeBar.ModuloMesas;

namespace ControleBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList()); 
            RepositorioCliente repositorioCliente = new RepositorioCliente(new ArrayList());
            RepositorioContas repositorioContas = new RepositorioContas(new ArrayList());

            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);  
            TelaMesa telaMesas = new TelaMesa(repositorioMesa);
            TelaCliente telaCliente = new TelaCliente(repositorioCliente); 
            TelaContas telaContas = new TelaContas(repositorioContas, repositorioCliente, repositorioMesa, repositorioGarcom, telaGarcom, telaMesas, telaCliente);


            ApresentarMenu principal = new ApresentarMenu(); 


            while (true)
            {
                string opcao = principal.ApresentarMenu;

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaMesas.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesas.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesas.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesas.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesas.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaCliente.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaCliente.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaCliente.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaCliente.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaCliente.ExcluirRegistro();
                    }
                }
                else if (opcao == "4")
                {
                    string subMenu = telaContas.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaContas.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaContas.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaContas.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaContas.ExcluirRegistro();
                    }

                }
            }
        }
    }
}