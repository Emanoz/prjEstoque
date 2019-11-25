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
                    e.Local = reader["Local"].ToString();

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

        public Estoque GetById(int cod)
        {
            string query = "SELECT * FROM Estoque WHERE local = @local";

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query, new SqlParameter("@codEstoque", cod));
                reader.Read();

                Estoque e = new Estoque();

                e.CodEstoque = int.Parse(reader["CodEstoque"].ToString());
                e.Local = reader["Local"].ToString();

                reader.Close();
                return e;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Insert(Estoque e)
        {
            string query = "INSERT INTO Estoque VALUES(@local)";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@local", e.Local));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Estoque e)
        {
            string query = "UPDATE Estoque SET Local = @local WHERE CodEstoque = @codEstoque";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@local", e.Local),
                                                     new SqlParameter("@codEstoque", e.CodEstoque));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Delete(int cod)
        {
            string query = "DELETE FROM Estoque WHERE CodEstoque = @codEstoque";
            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codEstoque", cod));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
