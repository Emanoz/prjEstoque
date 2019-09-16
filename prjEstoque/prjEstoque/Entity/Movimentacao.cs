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

        public Movimentacao(int codMovimentacao, int codUsuario, int codEquipamento, int codEstoque, string estado, DateTime dataMovimentacao)
        {
            CodMovimentacao = codMovimentacao;
            CodUsuario = codUsuario;
            CodEquipamento = codEquipamento;
            CodEstoque = codEstoque;
            Estado = estado;
            DataMovimentacao = dataMovimentacao;
        }

        public int CodMovimentacao { get; set; }
        public int CodUsuario { get; set; }
        public int CodEquipamento { get; set; }
        public int CodEstoque { get; set; }
        public string Estado { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}
