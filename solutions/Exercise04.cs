using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    internal class Exercise04
    {


        public void Exercise4()
        {

            /*Faça um programa que peça 10 números inteiros, calcule e mostre a quantidade de números pares e a quantidade de números impares.*/

            var pares = 0;
            var impares = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                var numeros = Convert.ToInt32(Console.ReadLine());

                if (numeros % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine($"Você atualmente tem {pares} pares");
            Console.WriteLine($"Você atualmente tem {impares} impares");
        }

    }
}
