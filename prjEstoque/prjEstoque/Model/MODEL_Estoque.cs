using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Estoque
    {
        private DBUtils db;

        public MODEL_Estoque()
        {
            db = new DBUtils();
        }

        public List<Estoque> GetAll()
        {
            string query = "SELECT * FROM Estoque";
            List<Estoque> list = new List<Estoque>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while(reader.Read())
                {
                    Estoque e = new Estoque();

                    e.CodEstoque = int.Parse(reader["CodEstoque"].ToString());
                    e.Quantidade = int.Parse(reader["Quantidade"].ToString());
                    e.Local = reader["[Local]"].ToString();

                    list.Add(e);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return list;
        }

        public void Insert(Estoque e)
        {
            string query = "INSERT INTO Estoque VALUES(@quantidade, @local)";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@quantidade", e.Quantidade),
                                                  new SqlParameter("@local", e.Local)) == 0)
                    throw new Exception("Nenhuma linha foi cadastrada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Estoque e)
        {
            string query = "UPDATE Estoque SET Quantidade = @quantidade, [Local] = @local";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@quantidade", e.Quantidade),
                                                  new SqlParameter("@local", e.Local)) == 0)
                    throw new Exception("Nenhuma linha foi alterada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int cod)
        {
            string query = "DELETE FROM Estoque WHERE CodEstoque = @codEstoque";
            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codEstoque", cod)) == 0)
                    throw new Exception("Nenhuma linha foi excluída");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
