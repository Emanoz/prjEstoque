using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Composicao
    {
        private DBUtils db = null;

        public MODEL_Composicao()
        {
            db = new DBUtils();
        }

        public List<Composicao> GetAll()
        {
            string query = "SELECT * FROM tbLComposicao";
            using (SqlDataReader reader = db.CallExecuteReader(query))
            {
                List<Composicao> list = new List<Composicao>();

                while (reader.Read())
                {
                    Composicao c = new Composicao();

                    c.CodComp = int.Parse(reader["id"].ToString());
                    c.CodProd_1 = int.Parse(reader["id_produto_1"].ToString());
                    c.CodProd_2 = int.Parse(reader["id_produto_2"].ToString());
                    c.CodProd_3 = int.Parse(reader["id_produto_3"].ToString());
                    c.Quantidade_1 = int.Parse(reader["quantidade_1"].ToString());
                    c.Quantidade_2 = int.Parse(reader["quantidade_2"].ToString());
                    c.Quantidade_3 = int.Parse(reader["quantidade_3"].ToString());

                    list.Add(c);
                }

                return list;
            }
        }

        public bool Insert(Composicao c)
        {
            string query = "INSERT INTO tbComposicao(id_produto_1, id_produto_2, id_produto_3, quantidade_1, quantidade_2, quantidade_3)" +
                            " VALUES(@id_produto_1, @id_produto_2, @id_produto_3, @quantidade_1, @quantidade_2, @quantidade_3)";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id_produto_1", c.CodProd_1),
                                              new SqlParameter("@id_produto_2", c.CodProd_2),
                                              new SqlParameter("@id_produto_2", c.CodProd_3),
                                              new SqlParameter("@quantidade_1", c.Quantidade_1),
                                              new SqlParameter("@quantidade_2", c.Quantidade_2),
                                              new SqlParameter("@quantidade_3", c.Quantidade_3)) > 0)
                return true;
            return false;
        }

        public bool Update(Composicao c)
        {
            string query = "UPDATE tbComposicao SET id_produto_1 = @id_1, id_produto_2 = @id_2, id_produto_3 = @id_3, " +
                           "quantidade_1 = @quantidade_1, quantidade_2 = @quantidade_2, quantidade_3 = @quantidade_3 WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id_1", c.CodProd_1),
                                              new SqlParameter("@id_2", c.CodProd_2),
                                              new SqlParameter("@id_3", c.CodProd_3),
                                              new SqlParameter("@quantidade_1", c.Quantidade_1),
                                              new SqlParameter("@quantidade_2", c.Quantidade_2),
                                              new SqlParameter("@quantidade_3", c.Quantidade_3),
                                              new SqlParameter("@id", c.CodComp)) > 0)
                return true;
            return false;
        }

        public bool Delete(int cod)
        {
            string query = "DELETE FROM tbComposicao WHERE id = @id";
            if (db.CallExecuteNonQuery(query, new SqlParameter("@id", cod)) > 0)
                return true;
            return false;
        }
    }
}
