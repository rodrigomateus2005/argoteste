using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste2
    {
        public List<int> CriarLista(int quantidade)
        {
            int[] arr = (int[]) Array.CreateInstance(typeof(int), quantidade);
            return arr.ToList();
        }

        public List<int> OrdenarLista(params int[] valores)
        {
            if (valores == null) return null;
            return valores.OrderBy(x => x).ToList();
        }
    }
}
