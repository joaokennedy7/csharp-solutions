using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    internal class Exercise05
    {

            /*A série de Fibonacci é formada pela seqüência 1,1,2,3,5,8,13,21,34,55,... Faça um programa capaz de gerar a série até o n−ésimo termo.*/
                public void Exercise5() 
                {
                
           
                Console.Write("Digite o número de termos da série de Fibonacci: ");
                int n = int.Parse(Console.ReadLine());

                // Verifica se o número de termos é maior que zero
                if (n <= 0)
                {
                    Console.WriteLine("O número de termos deve ser maior que zero.");
                }
                else
                {
                    // Inicializa os dois primeiros termos da série
                    int primeiroTermo = 1, segundoTermo = 1;

                    Console.WriteLine("Série de Fibonacci:");

                    // Exibe o primeiro termo
                    Console.WriteLine(primeiroTermo);

                    // Se o número de termos for maior que 1, exibe o segundo termo
                    if (n > 1)
                    {
                        Console.WriteLine(segundoTermo);
                    }

                    // Calcula e exibe os termos subsequentes
                    for (int i = 3; i <= n; i++)
                    {
                        int proximoTermo = primeiroTermo + segundoTermo;
                        Console.WriteLine(proximoTermo);

                        // Atualiza os valores dos termos para o próximo cálculo
                        primeiroTermo = segundoTermo;
                        segundoTermo = proximoTermo;
                    }
                }
            }
        }

    }

    