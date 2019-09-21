using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Categoria
    {
        public Categoria()
        {

        }

        public Categoria(int codCategoria, string descricao)
        {
            CodCategoria = codCategoria;
            Descricao = descricao;
        }

        public Categoria(string descricao)
        {
            Descricao = descricao;
        }

        public int CodCategoria { get; set; }
        public string Descricao { get; set; }

    }
}
