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

        public Estoque(int codEstoque, string local)
        {
            CodEstoque = codEstoque;
            Local = local;
        }

        public Estoque(string local)
        {
            Local = local;
        }

        public int CodEstoque { get; set; }
        
        public string Local { get; set; }

        public override string ToString()
        {
            return Local;
        }
    }
}
