using System;
using System.Collections.Generic;

namespace Distribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a distribuidora
            Distribuidora distribuidora = new Distribuidora();

            // Adicionando os faturamentos por estado
            distribuidora.AdicionarFaturamento("SP", 67836.43);
            distribuidora.AdicionarFaturamento("RJ", 36678.66);
            distribuidora.AdicionarFaturamento("MG", 29229.88);
            distribuidora.AdicionarFaturamento("ES", 27165.48);
            distribuidora.AdicionarFaturamento("Outros", 19849.53);

            // Exibindo o percentual de representação por estado
            distribuidora.ExibirPercentualRepresentacao();
        }
    }

    class Distribuidora
    {
        private Dictionary<string, double> faturamentos = new Dictionary<string, double>();

        public void AdicionarFaturamento(string estado, double valor)
        {
            faturamentos[estado] = valor;
        }

        public void ExibirPercentualRepresentacao()
        {
            double total = 0;
            foreach (double valor in faturamentos.Values)
            {
                total += valor;
            }

            Console.WriteLine("Percentual de representação por estado:");
            foreach (string estado in faturamentos.Keys)
            {
                double percentual = faturamentos[estado] / total * 100;
                Console.WriteLine($"{estado}: {percentual:0.00}%");
            }
        }
    }
}
