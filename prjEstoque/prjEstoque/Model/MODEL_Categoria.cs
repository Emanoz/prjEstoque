using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    class MODEL_Categoria
    {

        public MODEL_Categoria()
        {

        }

        public MODEL_Categoria(int codCat, string descricao)
        {
            CodCat = codCat;
            Descricao = descricao;
        }

        public int CodCat { get; set; }
        public string Descricao { get; set; }
    }
}
