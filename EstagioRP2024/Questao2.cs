using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstagioRP2024
{
    public class Questao2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            if (PertenceSequenciaFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }
        }

        static bool PertenceSequenciaFibonacci(int num)
        {
            int a = 0;
            int b = 1;

            while (b < num)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == num;
        }
    }
}