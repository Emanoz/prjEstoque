using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Fornecedor
    {
        private DBUtils db = null;

        public MODEL_Fornecedor()
        {
            db = new DBUtils();
        }

        public List<Fornecedor> GetAll()
        {
            string query = "SELECT * FROM tbFornecedor";
            using (SqlDataReader reader = db.CallExecuteReader(query))
            {
                List<Fornecedor> list = new List<Fornecedor>();

                while(reader.Read())
                {
                    Fornecedor f = new Fornecedor();

                    f.CodForn = int.Parse(reader["id"].ToString());
                    f.Nome = reader["nome"].ToString();
                    f.Telefone = reader["telefone"].ToString();
                    f.Email = reader["email"].ToString();
                    f.Tipo_Prod = reader["tipoProduto"].ToString();
                    f.Cpf = reader["cpf"].ToString();
                    f.Cnpj = reader["cnpj"].ToString();
                    f.Cep = reader["cep"].ToString();

                    list.Add(f);
                }

                return list;
            }
        }

        public bool Insert(Fornecedor f)
        {
            string query = "INSERT INTO tbFornecedor(nome, telefone, email, tipoProduto, cpf, cnpj, cep) VALUES " +
                           "(@nome, @telefone, @email, @tipoProduto, @cpf, @cnpj, @cep)";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@nome", f.Nome),
                                              new SqlParameter("@telefone", f.Telefone),
                                              new SqlParameter("@email", f.Email),
                                              new SqlParameter("@tipoProduto", f.Tipo_Prod),
                                              new SqlParameter("@cpf", f.Cpf),
                                              new SqlParameter("@cnpj", f.Cnpj),
                                              new SqlParameter("@cep", f.Cep)) > 0)
                return true;
            return false;
        }

        public bool Update(Fornecedor f)
        {
            string query = "UPDATE tbFornecedor SET nome = @nome, telefone = @telefone, email = @email, " +
                           "tipoProduto = @tipoProduto, cpf = @cpf, cnpj = @cnpj, cep = @cep WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@nome", f.Nome),
                                              new SqlParameter("@telefone", f.Telefone),
                                              new SqlParameter("@email", f.Email),
                                              new SqlParameter("@tipoProduto", f.Tipo_Prod),
                                              new SqlParameter("@cpf", f.Cpf),
                                              new SqlParameter("@cnpj", f.Cnpj),
                                              new SqlParameter("@cep", f.Cep),
                                              new SqlParameter("@id", f.CodForn)) > 0)
                return true;
            return false;
        }

        public bool Delete(int cod)
        {
            string query = "DELETE FROM tbFornecedor WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id", cod)) > 0)
                return true;
            return false;
        }
    }
}
