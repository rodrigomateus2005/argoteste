using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste1
    {
        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public decimal Media(params int[] valores)
        {
            if (valores == null || valores.Length == 0) return 0;
            return (decimal)valores.Average();
        }

    }
}
