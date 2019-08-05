using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    class MODEL_Composicao
    {

        public MODEL_Composicao()
        {

        }

        public MODEL_Composicao(int codComp, int quantidade_1, int quantidade_2, int quantidade_3, int codProd_, int codProd_1, 
                                int codProd_2, int codProd_3)
        {
            CodComp = codComp;
            Quantidade_1 = quantidade_1;
            Quantidade_2 = quantidade_2;
            Quantidade_3 = quantidade_3;
            CodProd_1 = codProd_1;
            CodProd_2 = codProd_2;
            CodProd_3 = codProd_3;
        }

        public int CodComp { get; set; }
        public int Quantidade_1 { get; set; }
        public int Quantidade_2 { get; set; }
        public int Quantidade_3 { get; set; }
        public int CodProd_1 { get; set; }
        public int CodProd_2 { get; set; }
        public int CodProd_3 { get; set; }
    }
}
