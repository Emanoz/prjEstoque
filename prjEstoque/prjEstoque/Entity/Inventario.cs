using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Inventario
    {
        public Inventario()
        {

        }

        public Inventario(string descricao, string estado, string pertencente, string estoque)
        {
            Descricao = descricao;
            Estado = estado;
            Pertencente = pertencente;
            Estoque = estoque;
        }

        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Pertencente { get; set; }
        public string Estoque { get; set; }

    }
}
