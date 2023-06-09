﻿using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";

        }
        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Nome", "Valor", "Quantidade");

            Console.WriteLine("---------------------------------------------------------------------------------------");

            foreach (Produto produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", produto.id, produto.nome, produto.valor, produto.quantidade);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: "); 
            string nome = Console.ReadLine();

            Console.Write("Digite o Valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            return new Produto(nome, valor, quantidade);
        }
    }
}