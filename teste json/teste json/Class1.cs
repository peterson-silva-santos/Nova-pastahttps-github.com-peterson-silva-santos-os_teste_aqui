using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_json
{
    internal class Class1
    {
        // Dados de faturamento em formato JSON
      
        // Classe para representar o faturamento mensal
        public class FaturamentoMensal
        {
            public FaturamentoDiario[] FaturamentoDiario { get; set; }
        }

        // Classe para representar o faturamento diário
        public class FaturamentoDiario
        {
            public string Data { get; set; }
            public double Valor { get; set; }
        }


    }
}
