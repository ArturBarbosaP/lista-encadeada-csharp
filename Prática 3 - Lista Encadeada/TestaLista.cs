using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prática_3___Lista_Encadeada
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c = 0, menu = 0;
            string n, r;

            while (menu != 4)
            {
                Console.Write("Menu\n" +
                    "1) Inserir\n" +
                    "2) Pesquisar\n" +
                    "3) Imprimir Lista\n" +
                    "4) Sair  ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (menu)
                {
                    case 1:
                        Console.Write("Digite um nº e um nome (-1 para sair): ");
                        c = Convert.ToInt32(Console.ReadLine());

                        while (c != -1)
                        {
                            if (l.Pesquisar(c) == null)
                            {
                                n = Console.ReadLine();
                                l.Inserir(new NoLista(c, n));
                            }
                            else
                                Console.WriteLine("Valor já inserido!");

                            Console.Write("Digite outro nº e nome (-1 para sair): ");
                            c = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Digite um nº a ser pesquisado: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        NoLista np = l.Pesquisar(c);

                        if (np == null)
                            Console.WriteLine("Valor não encontrado!");
                        else
                        {
                            Console.WriteLine("Achou: Chave: " + np.chave + " Nome: " + np.nome);
                            Console.Write("Deseja remover o nó da lista? Y(Sim)/N(Não): ");
                            r = Console.ReadLine();
                            if (r == "Y")
                            {
                                l.Remover(c);
                                Console.WriteLine("Removido o nó " + c + " da lista");
                            }
                        }

                        Console.WriteLine();
                        break;

                    case 3:
                        l.Imprimir();
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}