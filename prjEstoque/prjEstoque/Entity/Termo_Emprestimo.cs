﻿using System;
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

        public Termo_Emprestimo(int codtermo, DateTime dataRetirada, string caminhoDigitalizado, string rg, DateTime dataDevolucao, int codEquipamento)
        {
            Codtermo = codtermo;
            DataRetirada = dataRetirada;
            CaminhoDigitalizado = caminhoDigitalizado;
            Rg = rg;
            DataDevolucao = dataDevolucao;
            CodEquipamento = codEquipamento;
        }

        public int Codtermo { get; set; }
        public DateTime DataRetirada { get; set; }
        public string CaminhoDigitalizado { get; set; }
        public string Rg { get; set; }
        public DateTime DataDevolucao { get; set; }
        public int CodEquipamento { get; set; }
    }
}
