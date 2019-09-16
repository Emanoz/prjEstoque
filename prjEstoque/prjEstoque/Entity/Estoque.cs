using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Estoque
    {
        public Estoque()
        {

        }

        public Estoque(int codEstoque, int quantidade, string local)
        {
            CodEstoque = codEstoque;
            Quantidade = quantidade;
            Local = local;
        }

        public int CodEstoque { get; set; }

        public int Quantidade { get; set; }

        public string Local { get; set; }

    }
}
