using prjEstoque.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    class MODEL_Usuario
    {
        private DBUtils db = null;
        public MODEL_Usuario()
        {
            db = new DBUtils();
        }

        public Usuario Logar(string usuario, string senha)
        {
            string query = "SELECT CodUsuario, Nome, Cargo, Pin FROM USUARIO WHERE Usuario = @usuario AND Senha = @senha";
            Usuario u = new Usuario(usuario, senha);

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query, new SqlParameter("@usuario", u._Usuario),
                                                                   new SqlParameter("@senha", u.Senha));
                reader.Read();

                u.CodUsuario = int.Parse(reader["CodUsuario"].ToString());
                u.Nome = reader["Nome"].ToString();
                u.Cargo = reader["Cargo"].ToString();
                u.Pin = reader["Pin"].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
            return u;
        }

        public Usuario GetById(int cod)
        {
            string query = "SELECT CodUsuario, Nome, Cargo, Pin FROM USUARIO WHERE CodUsuario = @codUsuario";
            Usuario u = new Usuario();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query, new SqlParameter("@codUsuario", u.CodUsuario));
                reader.Read();

                u.CodUsuario = int.Parse(reader["CodUsuario"].ToString());
                u.Nome = reader["Nome"].ToString();
                u.Cargo = reader["Cargo"].ToString();
                u.Pin = reader["Pin"].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
            return u;
        }
    }
}
