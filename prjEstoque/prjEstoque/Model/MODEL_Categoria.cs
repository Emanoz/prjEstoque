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
        private DBUtils db;

        public MODEL_Categoria()
        {
            db = new DBUtils();
        }

        public List<Categoria> GetAll()
        {
            string query = "SELECT * FROM Categoria";
            List<Categoria> list = new List<Categoria>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Categoria c = new Categoria();

                    c.CodCategoria = int.Parse(reader["CodCategoria"].ToString());
                    c.Descricao = reader["Descricao"].ToString();

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

        public List<Categoria> GetCategoria()
        {
            string query = "SELECT Descricao FROM Categoria";
            List<Categoria> list = new List<Categoria>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Categoria c = new Categoria();
                    
                    c.Descricao = reader["Descricao"].ToString();

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

        public int Insert(Categoria c)
        {
            string query = "INSERT INTO Categoria VALUES(@descricao)";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@descricao", c.Descricao));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Update(Categoria c)
        {
            string query = "UPDATE Categoria SET Descricao = @descricao WHERE CodCategoria = @codCategoria";

            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codCategoria", c.CodCategoria),
                                                  new SqlParameter("@descricao", c.Descricao));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Delete(int cod)
        {
            string query = "DELETE FROM Categoria WHERE CodCategoria = @codCategoria";
            try
            {
                return db.CallExecuteNonQuery(query, new SqlParameter("@codCategoria", cod));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
