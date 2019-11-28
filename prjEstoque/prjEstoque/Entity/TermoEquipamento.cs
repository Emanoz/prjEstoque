using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    public class TermoEquipamento
    {
        public TermoEquipamento()
        {

        }

        public TermoEquipamento(int codTermo, string rg, DateTime dtpRetirada, string descricao, string patrimonio, 
                                string nSerie, DateTime dtpDevolucao)
        {
            CodTermo = codTermo;
            Rg = rg;
            DtpRetirada = dtpRetirada;
            Descricao = descricao;
            Patrimonio = patrimonio;
            NSerie = nSerie;
            DtpDevolucao = dtpDevolucao; 
        }

        public int CodTermo { get; set; }
        public string Rg { get; set; }
        public DateTime DtpRetirada { get; set; }
        public string Descricao { get; set; }
        public string Patrimonio { get; set; }
        public string NSerie { get; set; }
        public DateTime DtpDevolucao { get; set; }
    }
}
