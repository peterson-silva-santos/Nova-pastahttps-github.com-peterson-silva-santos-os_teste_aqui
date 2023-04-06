using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using teste_json;
using  static teste_json.Class1;



namespace DistribuidoraFaturamento
{
    class Program
    {
        static void Main(string[] args)

        {
            Class1 class1= new Class1();
            // Dados de faturamento em formato JSON
            string json = @"
            {
                ""faturamentoDiario"": [
                    { ""data"": ""2023-04-01"", ""valor"": 1000.50 },
                    { ""data"": ""2023-04-02"", ""valor"": 0 },
                    { ""data"": ""2023-04-03"", ""valor"": 2500.25 },
                    { ""data"": ""2023-04-04"", ""valor"": 1800.75 },
                    { ""data"": ""2023-04-05"", ""valor"": 2200.00 },
                    { ""data"": ""2023-04-06"", ""valor"": 0 }
                ]
            }";

            // Desserializa o JSON para um objeto C#
            FaturamentoMensal faturamento = JsonConvert.DeserializeObject<FaturamentoMensal>(json);

            // Calcula o menor valor de faturamento
            double menorValor = faturamento.FaturamentoDiario.Min(fd => fd.Valor);

            // Calcula o maior valor de faturamento
            double maiorValor = faturamento.FaturamentoDiario.Max(fd => fd.Valor);

            // Calcula a média mensal de faturamento, ignorando dias sem faturamento
            double mediaMensal = faturamento.FaturamentoDiario.Where(fd => fd.Valor > 0).Average(fd => fd.Valor);

            // Calcula o número de dias com faturamento acima da média mensal
            int numDiasAcimaMedia = faturamento.FaturamentoDiario.Count(fd => fd.Valor > mediaMensal);

            // Exibe os resultados
            Console.WriteLine("Menor valor de faturamento: R$" + menorValor);
            Console.WriteLine("Maior valor de faturamento: R$" + maiorValor);
            Console.WriteLine("Número de dias acima da média: " + numDiasAcimaMedia);
        }
    }

   
}