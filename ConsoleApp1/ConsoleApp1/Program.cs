using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Produtos produtos = new Produtos();
            bool key = true;

            while (key)
            {
                Console.SetCursorPosition(50, 10); Console.WriteLine("----------------------");
                Console.SetCursorPosition(50, 11); Console.WriteLine("        MENU");
                Console.SetCursorPosition(50, 12); Console.WriteLine("----------------------");
                Console.SetCursorPosition(50, 13); Console.WriteLine(" 0 - Sair");
                Console.SetCursorPosition(50, 14); Console.WriteLine(" 1 - Adicione Produto");
                Console.SetCursorPosition(50, 15); Console.WriteLine(" 2 - Pesquise Produto");
                Console.SetCursorPosition(50, 16); Console.WriteLine(" 3 - Remova Produto");
                Console.SetCursorPosition(50, 17); Console.WriteLine(" 4 - Liste Produto");
                Console.SetCursorPosition(50, 18); Console.WriteLine("----------------------");
                Console.SetCursorPosition(50, 19); Console.Write(" Digite sua opção: ");
                Console.SetCursorPosition(50, 20); Console.WriteLine("----------------------");

                Console.SetCursorPosition(69, 19); int entrada = int.Parse(Console.ReadLine());

                Console.Clear();
                if (entrada == 1)
                {
                    Console.SetCursorPosition(45, 10); Console.Write("Digite o Codigo do Produto: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(45, 11); Console.Write("Digite a Descricão do Produto: ");
                    string descricao = Console.ReadLine();
                    Console.SetCursorPosition(45, 12); Console.Write("Digite a Quantidade do Produto: ");
                    int qtde = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(45, 13); Console.Write("Digite o Preço do Produto: ");
                    double preco = double.Parse(Console.ReadLine());
                    Console.SetCursorPosition(45, 14); Console.Write("Tecle algo para adicionar. ");
                    produtos.adicionar(new Produto(codigo, descricao, qtde, preco));

                }
                else if(entrada == 2)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Produto result = produtos.pesquisar(new Produto(codigo,"",0, 0));
                    Console.WriteLine("Codigo : "+result.Codigo+"\nDescrição : "+result.Descricao+"\nQtde : "+result.Qtde+"\nPreco : "+result.Preco);
                }
                else if (entrada == 3)
                {
                    Console.WriteLine("Digite o Codigo: ");
                    int codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Tem certeza S ou N? ");
                    string x = Console.ReadLine();
                    bool decisao = (x == "S" || x == "s")? true : false;
                    if (decisao)
                    {
                        bool result = produtos.remover(new Produto(codigo, "", 0, 0));
                        if (result)
                        {
                            Console.WriteLine("Produto Removido com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possivel remover o Produto");
                        }
                    }
                 }
                else if (entrada == 4)
                {
                    foreach(Produto elemento in produtos.ListaProdutos)
                    {
                        Produto result = produtos.pesquisar(new Produto(elemento.Codigo, "", 0, 0));
                        Console.WriteLine("Codigo : " + result.Codigo + "\nDescrição : " + result.Descricao + "\nQtde : " + result.Qtde + "\nPreco : " + result.Preco+"\n");
                    }
                    Console.WriteLine("Custo total= " + produtos.custoTotal());
                }
                else if (entrada == 0)
                {
                    key = false;
                }
                else 
                {
                    Console.WriteLine("Valor invalido");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
