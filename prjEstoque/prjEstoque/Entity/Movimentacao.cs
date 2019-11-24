using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Movimentacao
    {
        public Movimentacao()
        {

        }

        public Movimentacao(int codUsuario, int codEquipamento, int codEstoque, string tipoMovimentacao, DateTime dataMovimentacao)
        {
            CodUsuario = codUsuario;
            CodEquipamento = codEquipamento;
            CodEstoque = codEstoque;
            TipoMovimentacao = tipoMovimentacao;
            DataMovimentacao = dataMovimentacao;
        }

        public int CodMovimentacao { get; set; }
        public int CodUsuario { get; set; }
        public int CodEquipamento { get; set; }
        public int CodEstoque { get; set; }
        public string TipoMovimentacao { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}
