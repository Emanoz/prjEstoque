using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjEstoque.Entity;
using System.Data.SqlClient;

namespace prjEstoque.Model
{
    class MODEL_Equipamento
    {
        private DBUtils db;

        public MODEL_Equipamento()
        {
            db = new DBUtils();
        }

        public List<Equipamento> GetAll()
        {
            string query = "SELECT * FROM Equipamento";
            List<Equipamento> list = new List<Equipamento>();

            try
            {
                SqlDataReader reader = db.CallExecuteReader(query);
                while (reader.Read())
                {
                    Equipamento e = new Equipamento();

                    e.CodEquipamento = int.Parse(reader["CodEquipamento"].ToString());
                    e.Descricao = reader["Descricao"].ToString();
                    e.NumSerie = reader["NumSerie"].ToString();
                    e.Estado = reader["Estado"].ToString();
                    e.CodCategoria = int.Parse(reader["CodCategoria"].ToString());
                    e.Pertencente = reader["Pertencente"].ToString();
                    e.Patrimonio = reader["Patrimonio"].ToString();

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

        public void Insert(Equipamento e)
        {
            string query = "INSERT INTO Equipamento VALUES(@descricao, @numSerie, @estado, @codCategoria, @pertencente, @patrimonio)";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", e.Descricao),
                                                  new SqlParameter("@numSerie", e.NumSerie),
                                                  new SqlParameter("@estado", e.Estado),
                                                  new SqlParameter("@codCategoria", e.CodCategoria),
                                                  new SqlParameter("@pertencente", e.Pertencente),
                                                  new SqlParameter("@patrimonio", e.Patrimonio)) == 0)
                    throw new Exception("Nenhuma linha foi cadastrada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Update(Equipamento e)
        {
            string query = "UPDATE Equipamento SET Descricao = @descricao, NumSerie = @numSerie, Estado = @estado, CodCategoria = @codCategoria, Pertencente = @pertencente, Patrimonio = @patrimonio";

            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@descricao", e.Descricao),
                                                  new SqlParameter("@numSerie", e.NumSerie),
                                                  new SqlParameter("@estado", e.Estado),
                                                  new SqlParameter("@codCategoria", e.CodCategoria),
                                                  new SqlParameter("@pertencente", e.Pertencente),
                                                  new SqlParameter("@patrimonio", e.Patrimonio)) == 0)
                    throw new Exception("Nenhuma linha foi alterada");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Delete(int cod)
        {
            string query = "DELETE FROM Equipamento WHERE CodEquipamento = @codEquipamento";
            try
            {
                if (db.CallExecuteNonQuery(query, new SqlParameter("@codEquipamento", cod)) == 0)
                    throw new Exception("Nenhuma linha foi excluída");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
