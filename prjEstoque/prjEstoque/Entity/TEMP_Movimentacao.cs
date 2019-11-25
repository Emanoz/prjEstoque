using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    public class TEMP_Movimentacao
    {
        public TEMP_Movimentacao()
        {

        }

        public TEMP_Movimentacao(string usuario, string equipamento, string estoque, string tipoMov, DateTime dataMov)
        {

        }

        public string Usuario { get; set; }
        public string Equipamento { get; set; }
        public string Estoque { get; set; }
        public string TipoMov { get; set; }
        public DateTime DataMov { get; set; }
    }
}
