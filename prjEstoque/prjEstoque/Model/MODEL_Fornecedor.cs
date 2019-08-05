using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    class MODEL_Fornecedor
    {
        public MODEL_Fornecedor()
        {

        }

        public MODEL_Fornecedor(int codForn, string nome, string telefone, string email, string tipo_prod, string cpf, string cnpj,
                                string cep)
        {
            CodForn = codForn;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Tipo_Prod = tipo_prod;
            Cpf = cpf;
            Cnpj = cnpj;
            Cep = cep;
        }

        public int CodForn { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo_Prod { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
    }
}
