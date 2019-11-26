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

        public Inventario(int id, string descricao, string estado, string pertencente, string estoque)
        {
            ID = id;
            Descricao = descricao;
            Estado = estado;
            Pertencente = pertencente;
            Estoque = estoque;
        }

        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }
        public string Pertencente { get; set; }
        public string Estoque { get; set; }

    }
}
