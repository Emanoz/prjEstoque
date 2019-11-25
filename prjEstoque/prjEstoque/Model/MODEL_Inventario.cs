using prjEstoque.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEstoque.Model
{
    class MODEL_Inventario
    {
        private DBUtils db;

        public MODEL_Inventario()
        {
            db = new DBUtils();
        }

        public List<Inventario> GetAll()
        {
            string query = "SELECT * FROM MostrarInventario";
            List<Inventario> list = new List<Inventario>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Inventario c = new Inventario();

                    c.Descricao = reader["Descricao"].ToString();
                    c.Estado = reader["Estado"].ToString();
                    c.Pertencente = reader["Pertencente"].ToString();
                    c.Estoque = reader["Estoque"].ToString();

                    list.Add(c);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }
    }
}
