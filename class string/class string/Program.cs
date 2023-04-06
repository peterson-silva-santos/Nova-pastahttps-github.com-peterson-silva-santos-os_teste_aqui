using System;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de entrada de string pelo usuário
            Console.WriteLine("Digite uma string para inverter:");
            string texto = Console.ReadLine();

            // Inverte a string usando um array de caracteres
            char[] arrayCaracteres = texto.ToCharArray();
            Array.Reverse(arrayCaracteres);
            string textoInvertido = new string(arrayCaracteres);

            // Imprime a string invertida
            Console.WriteLine($"Texto invertido: {textoInvertido}");
        }
    }
}
