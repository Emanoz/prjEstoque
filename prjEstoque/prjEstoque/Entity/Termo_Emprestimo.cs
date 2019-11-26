using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Termo_Emprestimo
    {
        public Termo_Emprestimo()
        {

        }

        public Termo_Emprestimo(DateTime dataRetirada, string rg, int codEquipamento)
        {
            DataRetirada = dataRetirada;
            Rg = rg;
            CodEquipamento = codEquipamento;
        }

        public Termo_Emprestimo(int codTermo, DateTime dataRetirada, string rg, DateTime dataDevolucao, int codEquipamento)
        {
            CodTermo = codTermo;
            DataRetirada = dataRetirada;
            Rg = rg;
            DataDevolucao = dataDevolucao;
            CodEquipamento = codEquipamento;
        }

        public Termo_Emprestimo(DateTime dataRetirada, string rg, DateTime dataDevolucao, int codEquipamento)
        {
            DataRetirada = dataRetirada;
            Rg = rg;
            DataDevolucao = dataDevolucao;
            CodEquipamento = codEquipamento;
        }

        public Termo_Emprestimo(int codTermo, DateTime dataRetirada, string rg, int codEquipamento)
        {
            CodTermo = codTermo;
            DataRetirada = dataRetirada;
            Rg = rg;
            CodEquipamento = codEquipamento;
        }

        public int CodTermo { get; set; }
        public DateTime DataRetirada { get; set; }
        public int CodEquipamento { get; set; }
        public string Rg { get; set; }
        public DateTime DataDevolucao { get; set; }
        
    }
}
