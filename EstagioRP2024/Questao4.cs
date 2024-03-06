using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstagioRP2024
{
    public class Questao4
    {
        public static void Main(string[] args)
        {
            bool lamp1 = false;
            bool lamp2 = false;
            bool lamp3 = false;

            Random rnd = new Random();
            int switch1 = rnd.Next(1, 4);

            Console.WriteLine("Primeira ida: Ligou o interruptor " + switch1);
            if (switch1 == 1)
            {
                lamp1 = !lamp1;
                Console.WriteLine("O interruptor 1 controla a lâmpada 1.");
            }
            else if (switch1 == 2)
            {
                lamp2 = !lamp2;
                Console.WriteLine("O interruptor 1 controla a lâmpada 2.");
            }
            else
            {
                lamp3 = !lamp3;
                Console.WriteLine("O interruptor 1 controla a lâmpada 3.");
            }

            int switch2;
            do
            {
                switch2 = rnd.Next(1, 4);
            } while (switch2 == switch1);

            Console.WriteLine("Segunda ida: Ligou o interruptor " + switch2);
            if (switch2 == 1)
            {
                lamp1 = !lamp1;
                Console.WriteLine("O interruptor 2 controla a lâmpada 1.");
            }
            else if (switch2 == 2)
            {
                lamp2 = !lamp2;
                Console.WriteLine("O interruptor 2 controla a lâmpada 2.");
            }
            else
            {
                lamp3 = !lamp3;
                Console.WriteLine("O interruptor 2 controla a lâmpada 3.");
            }
            Console.WriteLine("O interruptor que sobrar controla a lâmpada que sobrou.");
        }
    }
}