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

        public void Insert(Categoria c)
        {
            string query = "INSERT INTO Categoria VALUES(@descricao)";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", c.Descricao)) == 0)
                    throw new Exception("Nenhuma linha foi cadastrada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Categoria c)
        {
            string query = "UPDATE Categoria SET Descricao = @descricao";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", c.Descricao)) == 0)
                    throw new Exception("Nenhuma linha foi alterada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int cod)
        {
            string query = "DELETE FROM Categoria WHERE CodCategoria = @codCategoria";
            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codCategoria", cod)) == 0)
                    throw new Exception("Nenhuma linha foi excluída");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
