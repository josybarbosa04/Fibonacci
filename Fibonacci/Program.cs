using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            bool pertence = VerificarFibonacci(numero);

            if (pertence)
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");

            Console.ReadLine();
        }

        static bool VerificarFibonacci(int num)
        {
            int a = 0, b = 1, c = 0;

            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c == num || num == 0; 
        }
    }

}
