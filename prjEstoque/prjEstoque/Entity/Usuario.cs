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

        public Usuario(int codUsuario, string usuario, string nome, string cargo, string pin, string senha)
        {
            CodUsuario = codUsuario;
            _Usuario = usuario;
            Nome = nome;
            Cargo = cargo;
            Pin = pin;
            Senha = senha;
        }

        public Usuario(string usuario, string senha)
        {
            _Usuario  = usuario;
            Senha = senha;
        }

        public int CodUsuario { get; set; }

        public string _Usuario { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Pin { get; set; }

        public string Senha { get; }

    }
}
