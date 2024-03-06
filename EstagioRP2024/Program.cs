using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstagioRP2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 à 4, de acordo com a opção desejada:");
            Console.WriteLine("1 - Executar questão 1");
            Console.WriteLine("2 - Executar questão 2");
            Console.WriteLine("3 - Executar questão 3");
            Console.WriteLine("4 - Executar questão 4");
            Console.WriteLine("5 - Executar questão 5");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Questao1.Main(args);
                    break;
                case "2":
                    Questao2.Main(args);
                    break;
                case "3":
                    Questao3.Main(args);
                    break;
                case "4":
                    Questao4.Main(args);
                    break;
                case "5":
                    Questao5.Main(args);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
