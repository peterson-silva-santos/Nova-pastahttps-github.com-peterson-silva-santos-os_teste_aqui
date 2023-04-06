using System;
using static TESTE_Fibonacci.Fibo_class;
using System;
using System.Collections.Generic;

namespace TESTE_Fibonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Chama o método "calcular" para gerar a sequência de Fibonacci
            var fibo = calcular();
            Fibo_class F =new Fibo_class();

            // Solicita um número para verificar se está na sequência
            Console.WriteLine("Digite um número para verificar se está na sequência de Fibonacci:");
            int num = int.Parse(Console.ReadLine());

            // Verifica se o número está na sequência de Fibonacci
            if (verific(num, fibo))
            {
                Console.WriteLine($"O número {num} está na sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} não está na sequência de Fibonacci.");
            }

            Console.ReadKey();
        }

       

        }

    }




  
