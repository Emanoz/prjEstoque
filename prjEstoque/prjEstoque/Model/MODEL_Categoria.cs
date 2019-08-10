using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

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
        
    }
}
