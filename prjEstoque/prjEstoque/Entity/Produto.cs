using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Produto
    {

        public Produto()
        {

        }

        public Produto(int codProd, int codForn, int codCat, string descricao, int quantidade, double valor, DateTime cadastrado_em)
        {
            CodProd = codProd;
            CodForn = codForn;
            CodCat = codCat;
            Descricao = descricao;
            Quantidade = quantidade;
            Valor = valor;
            Cadastrado_em = cadastrado_em;
        }

        public int CodProd { get; set; }
        public int CodForn { get; set; }
        public int CodCat { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime Cadastrado_em { get; set; }

    }
}
