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

        public Categoria(int codCat, string descricao)
        {
            CodCat = codCat;
            Descricao = descricao;
        }

        public int CodCat { get; set; }
        public string Descricao { get; set; }
    }
}
