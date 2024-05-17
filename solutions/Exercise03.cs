using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    public class Exercise03
    {

        public void Exercise3()
        {

            /*Faça um programa que peça dois números, base e expoente, calcule e mostre o primeiro número elevado ao segundo número. Não utilize a função de potência da linguagem.*/


            Console.WriteLine("Digite o valor base:");
            int valorBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a expoente:");
            int expoente = Convert.ToInt32(Console.ReadLine());

            int resultadoPotencia = Potencia(valorBase, expoente);

            Console.WriteLine($"{valorBase} elevado a {expoente} é {resultadoPotencia}");
        }

        static int Potencia(int valorBase, int expoente)
        {
            int resultado = 1;

            for (int i = 1; i <= expoente; i++)
            {
                resultado *= valorBase;
            }

            return resultado;
        }
    }
}