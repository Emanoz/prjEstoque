using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;
using System.Data;

namespace prjEstoque.Model
{
    class MODEL_Categoria
    {
        private DBUtils db = null;

        public MODEL_Categoria()
        {
            db = new DBUtils();
        }
        
        public List<Categoria> GetAll()
        {
            string query = "SELECT * FROM tbCategoria";
            using (SqlDataReader reader = db.CallExecuteReader(query))
            {
                List<Categoria> list = new List<Categoria>();

                while (reader.Read())
                {
                    Categoria cat = new Categoria();

                    cat.CodCat = int.Parse(reader["id"].ToString());
                    cat.Descricao = reader["descricao"].ToString();

                    list.Add(cat);
                }
                return list;
            }
        }

        public bool Insert(Categoria cat)
        {
            string query = "INSERT INTO tbCategoria(descricao) VALUES(@descricao)"; 

            if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", cat.Descricao)) > 0)
                return true;
            return false;
        }

        public bool Update(Categoria cat)
        {
            string query = "UPDATE tbCategoria SET descricao = @descricao WHERE id = @id";

            if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", cat.Descricao),
                                              new SqlParameter("@id", cat.CodCat)) > 0)
                return true;
            return false;
        }

        public bool Delete(int cod)
        {
            string query = "DELETE FROM tbCategoria WHERE id = @id";

            if (db.CallExecuteNonQuery(query, new SqlParameter("@id", cod)) > 0)
                return true;
            return false;
        }
        
    }
}   
