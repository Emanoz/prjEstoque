using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Produto
    {
        private DBUtils db = null;

        public MODEL_Produto()
        {
            db = new DBUtils();
        }

        public List<Produto> GetAll()
        {
            string query = "SELECT * FROM tbProduto";
            using (SqlDataReader reader = db.CallExecuteReader(query))
            {
                List<Produto> list = new List<Produto>();

                while (reader.Read())
                {
                    Produto p = new Produto();

                    p.CodProd = int.Parse(reader["id"].ToString());
                    p.CodForn = int.Parse(reader["id_fornecedor"].ToString());
                    p.CodCat = int.Parse(reader["id_categoria"].ToString());
                    p.Descricao = reader["descricao"].ToString();
                    p.Quantidade = int.Parse(reader["quantidade"].ToString());
                    p.Cadastrado_em = DateTime.Parse(reader["cadastrado_em"].ToString());
                    p.Valor = float.Parse(reader["valor_varejo"].ToString());

                    list.Add(p);
                }

                return list;
            }
        }

        public bool Insert(Produto p)
        {
            string query = "INSERT INTO tbProduto(id_fornecedor, id_categoria, descricao, quantidade, cadastrado_em, valor_varejo)" +
                           " VALUES(@id_fornecedor, @id_categoria, @descricao, @quantidade, @cadastrado_em, @valor_varejo)";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id_fornecedor", p.CodForn),
                                              new SqlParameter("@id_categoria", p.CodCat),
                                              new SqlParameter("@descricao", p.Descricao),
                                              new SqlParameter("@quantidade", p.Quantidade),
                                              new SqlParameter("@cadastrado_em", p.Cadastrado_em),
                                              new SqlParameter("@valor_varejo", p.Valor)) > 0)
                return true;
            return false;
        }

        public bool Update(Produto p)
        {
            string query = "UPDATE tbProduto SET id_fornecedor = @id_fornecedor, id_categoria = @id_categoria, descricao = @descricao," +
                           " quantidade = @quantidade, cadastrado_em = @cadastrado_em, valor_varejo = @valor_varejo WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id_fornecedor", p.CodForn),
                                              new SqlParameter("@id_categoria", p.CodCat),
                                              new SqlParameter("@descricao", p.Descricao),
                                              new SqlParameter("@quantidade", p.Quantidade),
                                              new SqlParameter("@cadastrado_em", p.Cadastrado_em),
                                              new SqlParameter("@valor_varejo", p.Valor),
                                              new SqlParameter("@id", p.CodProd)) > 0)
                return true;
            return false;
        }

        public bool Delete(int cod)
        {
            string query = "DELETE FROM tbProduto WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id", cod)) > 0)
                return true;
            return false;
        }
    }
}
