using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    public class Equipamento
    {
        public Equipamento()
        {

        }

        public Equipamento(int codEquipamento, string descricao, string numSerie, string estado, int codCategoria, string pertencente, string patrimonio)
        {
            CodEquipamento = codEquipamento;
            Descricao = descricao;
            NumSerie = numSerie;
            Estado = estado;
            CodCategoria = codCategoria;
            Pertencente = pertencente;
            Patrimonio = patrimonio;
        }

        public Equipamento(string descricao, string numSerie, string estado, int codCategoria, string pertencente, string patrimonio)
        {
            Descricao = descricao;
            NumSerie = numSerie;
            Estado = estado;
            CodCategoria = codCategoria;
            Pertencente = pertencente;
            Patrimonio = patrimonio;
        }

        public int CodEquipamento { get; set; }
        public string Descricao { get; set; }
        public string NumSerie { get; set; }
        public string Estado { get; set; }
        public int CodCategoria { get; set; }
        public string Pertencente { get; set; }
        public string Patrimonio { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}
