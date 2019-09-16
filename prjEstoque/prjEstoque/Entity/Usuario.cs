using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Entity
{
    class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(int codUsuario, string nome, string cargo, string pin, string senha)
        {
            CodUsuario = codUsuario;
            Nome = nome;
            Cargo = cargo;
            Pin = pin;
            Senha = senha;
        }

        public int CodUsuario { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Pin { get; set; }

        public string Senha { get; set; }

    }
}
