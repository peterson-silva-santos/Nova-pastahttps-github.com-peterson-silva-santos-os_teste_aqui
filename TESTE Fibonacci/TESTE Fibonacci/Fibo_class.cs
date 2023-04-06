using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE_Fibonacci
{
    internal class Fibo_class

    {

        // calcular a sequência de Fibonacci
        public static List<int> calcular()
        {
            var numerofibo = new List<int> { 1, 1 };

            while (numerofibo.Count <= 30)
            {
                var numeroAnterior1 = numerofibo[numerofibo.Count - 2];
                var numeroAnterior2 = numerofibo[numerofibo.Count - 1];
                var item = numeroAnterior1 + numeroAnterior2;
                numerofibo.Add(item);
            }

            return numerofibo;
        }


        //  verificar se um número está na sequência de Fibonacci
        public static bool verific(int num, List<int> fibo)
        {
            foreach (var n in fibo)
            {
                if (num == n)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
    

