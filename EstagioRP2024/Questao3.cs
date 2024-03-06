using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscritaPorExtenso;

namespace EstagioRP2024
{
    public class Questao3
    {
        public static void Main(string[] args)
        {
            // Sequência de progressão aritmética, cada número é aumentado em 2.
            static int SequenciaA()
            {
                int[] numeros = { 1, 3, 5, 7 };
                return (numeros[3] + 2);
            }
            Console.WriteLine($"O próximo elemento da sequência (a) é: {SequenciaA()}");

            // Progressão geométrica, o próximo número é o dobro do anterior.
            static int SequenciaB()
            {
                int[] numeros = { 2, 4, 8, 16, 32, 64 };
                return (numeros[5] * 2);
            }
            Console.WriteLine($"O próximo elemento da sequência (b) é: {SequenciaB()}.");

            // Sequência de quadrados perfeitos começando com 0.
            // 0 * 0 = 0,   1 * 1 = 1,   2 * 2 = 4,   3 * 3 = 9,   4 * 4 = 16,   5 * 5 = 25...
            static int SequenciaC()
            {
                int[] numeros = { 0, 1, 4, 9, 16, 25, 36 };
                return (numeros.Length) * (numeros.Length);
            }
            Console.WriteLine($"O próximo elemento da sequência (c) é: {SequenciaC()}.");

            // Quadrados de números pares. 2 * 2 = 4,   4 * 4 = 16,   6 * 6 = 36...
            static int SequenciaD()
            {
                // int[] numeros = { 4, 16, 36, 64 };
                int[] numerosParesAté10 = { 2, 4, 6, 8, 10};
                return (numerosParesAté10[4]) * (numerosParesAté10[4]);
            }
            Console.WriteLine($"O próximo elemento da sequência (d) é: {SequenciaD()}.");

            // Sequência de Fibonacci, o próximo número é a soma dos dois anteriores.
            static int SequenciaE()
            {
                int[] numeros = { 1, 1, 2, 3, 5, 8 };
                return numeros[numeros.Length - 1] + numeros[numeros.Length - 2];
            }
            Console.WriteLine($"O próximo elemento da sequência (e) é: {SequenciaE()}.");

            // Não foi possível encontrar nenhuma lógica numérica para identificar o próximo número da sequência.
            // A lógica encontrada é que todos os números do exemplo começam com a letra "D" (dois, dez, doze...).
            static int SequenciaF()
            {
                int[] numerosSequencia = { 2, 10, 12, 16, 17, 18, 19 };
                int numeroAtual = numerosSequencia[6];
                int proximoNumero = numeroAtual + 1;

                while (!ComecaComD(proximoNumero))
                {
                    proximoNumero++;
                }

                return proximoNumero;
            }

            static bool ComecaComD(int numero)
            {
                string numeroPorExtenso = numero.PorExtenso();
                return numeroPorExtenso.StartsWith("d");
            }
            Console.WriteLine($"O próximo elemento da sequência (f) é: {SequenciaF()}.");
        } 
    }
}