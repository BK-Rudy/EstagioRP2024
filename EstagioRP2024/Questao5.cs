using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstagioRP2024
{
    public class Questao5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra inverter seus caracteres:");
            string input = Console.ReadLine();

            string invertida = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                invertida += input[i];
            }

            Console.WriteLine("Palavra invertida: " + invertida);
        }
    }
}
